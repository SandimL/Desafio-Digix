using Desafio.Database;
using Desafio.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Desafio.Model.Enum;

namespace Desafio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SelecaoController : ControllerBase
    {
        [HttpGet]
        [Route("/teste")]
        public int Get()
        {
            //var p = new Pessoa("123123", "Milton Romero", "pretendente", "1996-12-30");
            //return p.getIdade();
            return 0;
        }

        [HttpPost]
        [Route("/familia/adicionar")]
        [Produces("application/json")]
        public ObjectResult AdicionarFamilia(Familia familia)
        {
            if (familia.Status == ((int)StatusFamilia.CADASTRO_VALIDO).ToString())
            {
                try
                {
                    FamiliaDB familiaDB = new FamiliaDB();
                    PessoaDB pessoaDB = new PessoaDB();
                    RendaDB rendaDB = new RendaDB();

                    familiaDB.adicionarFamilia(familia);

                    foreach (Pessoa pessoa in familia.Pessoas)
                    {
                        pessoaDB.adicionarPessoa(pessoa, familia.Id);
                    }

                    foreach (Renda renda in familia.Rendas)
                    {
                        rendaDB.adicionarRenda(renda);
                    }

                    return Ok(new { mensagem = "Familia adicionada" });
                }
                catch(Exception e)
                {
                    return Problem(e.Message, null, 500, "Exceção ao adicionar familia");
                }
            }
            else
            {
                return Problem("Familia está com um status não permitido", null, 400, "Familia não pode receber o beneficio!");
            }
        }


        [HttpPost]
        [Route("/familia/calcularPontuacao")]
        [Produces("application/json")]
        public ObjectResult CalcularPontuacao(Familia familia)
        {
            try
            {
                familia.calculaPontuacaoTotal();

                dynamic resultadoFamilia = new
                {
                    pontosPorIdadePretendente = familia.calculaPontosPorIdadeDoPretendente(),
                    pontosPorQtdDependentes = familia.calculaPontosPorQtdDependentes(),
                    pontosPorRendaTotal = familia.calculaPontosPorRendaTotal(),
                    pontuacaoTotal = familia.Pontuacao
                };
                
                return Ok( resultadoFamilia );
            }
            catch (Exception e)
            {
                return Problem(e.Message, null, 500, "Exceção ao calcular pontuação da Familia");
            }
        }
    }
}

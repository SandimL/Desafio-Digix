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
        public dynamic Post(Familia familia)
        {
            if (familia.Status == ((int)StatusFamilia.CADASTRO_VALIDO).ToString())
            {
                //Sqlite BD = new Sqlite();
                try
                {
                //    string queryInserirFamilia = string.Format(@"INSERT INTO familia(id, renda_total, status) 
                //                    VALUES ({0}, {1}, {2}", familia.Id, familia.calculaRendaTotal(), familia.Status);

                //    foreach (Pessoa p in familia.Pessoas)
                //    {
                //        p.Renda = familia.Rendas.Find(x => x.PessoaId == p.Id);

                //        string queryInserirPessoas = (@"INSERT INTO familia(id, nome, tipo, data_nascimento, renda, familia_id) 
                //                    VALUES ("+p.Id+", "+p.Nome+", "+ p.Tipo +", "+p.DataDeNascimento+", "+p.Renda.Valor+", "+familia.Id+")");

                //        BD.executeQuery(queryInserirPessoas);
                //    }


                //    BD.executeQuery(queryInserirFamilia);
                    return "por enquanto deu bom";
                }
                catch(Exception e)
                {
                    return e;
                }
            }
            else
            {
                return "Familia não pode receber o beneficio";
            }
        }
    }
}

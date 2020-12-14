using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Model
{
    public class Renda
    {
        public string PessoaId { get; set; }
        public float Valor { get; set; }

        public Renda() { }

        public Renda(string pessoaId, int valor)
        {
            PessoaId = pessoaId;
            Valor = valor;
        }
    }
}

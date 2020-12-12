using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Model
{
    public class Pretendente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public Pretendente(string id, string nome, DateTime dataNasc)
        {
            Id = id;
            Nome = nome;
            DataDeNascimento = dataNasc;
        }

        public int getIdade()
        {
            var hoje = DateTime.Now;
            var idade = hoje.Year - DataDeNascimento.Year;
            if (DataDeNascimento > hoje.AddYears(-idade)) idade--;
            return idade;
        }
    }
}

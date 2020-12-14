using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Model
{
    public class Pessoa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string DataDeNascimento { get; set; }

        public Pessoa() { }

        public Pessoa(string id, string nome, string tipo, string dataDeNascimento)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            DataDeNascimento = dataDeNascimento;
        }

        public int getIdade(string datahoje = null)
        {
            //utilizado caso seja fornecida data específica para calculo de idade
            var hoje = datahoje != null ? DateTime.Parse(datahoje) : DateTime.Now;

            string data = DataDeNascimento.Replace("-", "");
            var ano = Convert.ToInt32(data.Substring(0, 4));
            var mes = Convert.ToInt32(data.Substring(4, 2));
            var dia = Convert.ToInt32(data.Substring(6, 2));

            DateTime dataNascimento = new DateTime(ano, mes, dia);

            var idade = hoje.Year - dataNascimento.Year;
            if (dataNascimento > hoje.AddYears(-idade)) idade--;

            return idade;
        }
    }
}

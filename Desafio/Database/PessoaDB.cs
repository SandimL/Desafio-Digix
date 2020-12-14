using Desafio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Database
{
    public class PessoaDB
    {
        private Sqlite Db = Sqlite.Instancia();

        public void adicionarFamilia(Pessoa pessoa)
        {
            try
            {
                //string queryInserirFamilia = string.Format(@"INSERT INTO familia(id, renda_total, status) 
                //                    VALUES ({0}, {1}, {2}", familia.Id, familia.calculaRendaTotal(), familia.Status);
                //Db.executarQuery(queryInserirFamilia);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

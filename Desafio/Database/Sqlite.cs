using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Desafio.Database
{
    public class Sqlite : IDataBase
    {
        public Sqlite() { }

        public dynamic conexao()
        {
            return new SQLiteConnection("Data Source=selecao.db; Version = 3;"); 
        }

        public dynamic executarQuery(dynamic conexao, dynamic comando)
        {
            conexao.Open();
            int result = comando.ExecuteNonQuery();
            conexao.Close();

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Desafio.Database
{
    public class Sqlite
    {
        private static Sqlite _instance;
        public SQLiteConnection Conexao;

        public static Sqlite Instancia()
        {
            if (_instance == null)
            {
                _instance = new Sqlite();
            }
            return _instance;
        }

        public Sqlite()
        {
            Conexao = new SQLiteConnection("Data Source= selecao.db; Version = 3; New = True; Compress = True; ");
        }

        public void executarQuery(string query)
        {
            SQLiteCommand sqLiteCmd;
            Conexao.Open();
            sqLiteCmd = Conexao.CreateCommand();
            sqLiteCmd.CommandText = query;
            sqLiteCmd.ExecuteNonQuery();
        }
    }
}

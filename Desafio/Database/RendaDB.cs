using Desafio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Database
{
    public class RendaDB
    {
        private IDataBase Db = new Sqlite();

        #region adicionarRenda
        /// <summary>   Adiciona os dados de randa a tabela renda no banco de dados </summary>
        ///
        /// <remarks>   Lucas Sandim, 14/12/2020. </remarks>
        ///
        /// <param name="renda">  Objeto Renda a ser adicionado </param>
        ///
        /// <returns>  Inteiro contendo o resultado da execução da query </returns>
        #endregion
        public int adicionarRenda(Renda renda)
        {
            try
            {
                var conexao = Db.conexao();
                using (var cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO renda(id_pessoa, valor) VALUES (@id_pessoa, @valor)";
                    cmd.Parameters.AddWithValue("@id_pessoa", renda.PessoaId);
                    cmd.Parameters.AddWithValue("@valor", renda.Valor);

                    return Db.executarQuery(conexao, cmd);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }

        #region buscarRendaPorIdPessoa
        /// <summary>   Busca uma ou mais rendas no banco de dados com o ID de uma pessoa</summary>
        ///
        /// <remarks>   Lucas Sandim, 14/12/2020. </remarks>
        ///
        /// <param name="idPessoa"> Id da pessoa na qual a renda pertence </param>
        ///
        /// <returns> retona os objetos Renda encontrados </returns>
        #endregion
        public Renda[] buscarRendaPorIdPessoa(string idPessoa)
        {
            var conexao = Db.conexao();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM familia where(id_pessoa = @idPessoa)";
                cmd.Parameters.AddWithValue("@idPessoa", idPessoa);

                return Db.executarQuery(conexao, cmd);
            }
        }
    }
}

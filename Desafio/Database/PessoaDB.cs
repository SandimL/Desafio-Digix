using Desafio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Database
{
    public class PessoaDB
    {
        private IDataBase Db = new Sqlite();

        #region adicionarPessoa
        /// <summary>   Adiciona os dados de Pessoa a tabela Pessoa no banco de dados </summary>
        ///
        /// <remarks>   Lucas Sandim, 14/12/2020. </remarks>
        ///
        /// <param name="pessoa">  Objeto Pessoa a ser adicionado </param>
        /// <param name="familiaId"> Id da Familia a que ela pertence </param>
        ///
        /// <returns>  Inteiro contendo o resultado da execução da query </returns>
        #endregion
        public int adicionarPessoa(Pessoa pessoa, string familiaId)
        {
            try
            {
                var conexao = Db.conexao();
                using (var cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO pessoa(id, nome, tipo, data_nascimento, familia_id) 
                                        VALUES (@id, @nome, @tipo, @data_nascimento, @familia_id)";

                    cmd.Parameters.AddWithValue("@Id", pessoa.Id);
                    cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@tipo", pessoa.Tipo);
                    cmd.Parameters.AddWithValue("@data_nascimento", pessoa.DataDeNascimento);
                    cmd.Parameters.AddWithValue("@familia_id", familiaId);

                    return Db.executarQuery(conexao, cmd);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }


        #region buscarPessoaPorIdFamilia
        /// <summary>   Busca uma ou mais Pessoas no banco de dados com o ID de uma familia</summary>
        ///
        /// <remarks>   Lucas Sandim, 14/12/2020. </remarks>
        ///
        /// <param name="idFamilia"> Id da Familia na qual a Pessoa pertence </param>
        ///
        /// <returns> retona os objetos Pessoas encontrados </returns>
        #endregion
        public Pessoa[] buscarPessoaPorIdFamilia(string idFamilia)
        {
            var conexao = Db.conexao();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM familia where(id_familia = @idFamilia)";
                cmd.Parameters.AddWithValue("@idFamilia", idFamilia);

                return Db.executarQuery(conexao, cmd);
            }
        }

        #region buscarPessoaPorId
        /// <summary>   Busca uma Pessoa referente ao Id informado</summary>
        ///
        /// <remarks>   Lucas Sandim, 14/12/2020. </remarks>
        ///
        /// <param name="id"> Id da pessoa </param>
        ///
        /// <returns> retona um objeto Pessoa </returns>
        #endregion
        public Pessoa buscarPessoaPorId(string id)
        {
            var conexao = Db.conexao();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM familia where(id = @id)";
                cmd.Parameters.AddWithValue("@id", id);

                return Db.executarQuery(conexao, cmd);
            }
        }
    }
}

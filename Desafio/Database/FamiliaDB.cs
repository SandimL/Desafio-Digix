﻿using Desafio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Database
{
    public class FamiliaDB
    {
        private IDataBase Db = new Sqlite();

        #region adicionarFamilia
        /// <summary>   Adiciona alguns dados da Familia a tabela Familia no banco de dados </summary>
        ///
        /// <remarks>   Lucas Sandim, 14/12/2020. </remarks>
        ///
        /// <param name="familia">  Objeto Familia a ser adicionado </param>
        ///
        /// <returns>  Inteiro contendo o resultado da execução da query </returns>
        #endregion
        public int adicionarFamilia(Familia familia)
        {
            try
            {
                var conexao = Db.conexao();
                using (var cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO familia(id, status) VALUES (@id, @status)";
                    cmd.Parameters.AddWithValue("@Id", familia.Id);
                    cmd.Parameters.AddWithValue("@status", familia.Status);

                    return Db.executarQuery(conexao, cmd);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }

        #region buscarFamiliaPorId
        /// <summary>   Busca uma Familia referente ao Id informado</summary>
        ///
        /// <remarks>   Lucas Sandim, 14/12/2020. </remarks>
        ///
        /// <param name="id"> Id da Familia </param>
        ///
        /// <returns> retona um objeto Familia com alguns dados </returns>
        #endregion
        public dynamic buscarFamiliaPorId(string id)
        {
            var conexao = Db.conexao();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM familia where(id = @id)";
                cmd.Parameters.AddWithValue("@Id", id);

                return Db.executarQuery(conexao, cmd);
            }
        }
    }
}

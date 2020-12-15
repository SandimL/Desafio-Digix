using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Database
{
    public interface IDataBase
    {
        public dynamic conexao();
        public dynamic executarQuery(dynamic conexao, dynamic comando);
    }
}

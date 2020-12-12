using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Model
{
    public class Enum
    {
        #region StatusFamilia
        /// <summary>     Valores que representam o status de uma Família </summary>
        ///
        /// <remarks>   Lucas, 11/12/2020. </remarks>
        #endregion
        public enum StatusFamilia : int
        {
            CADASTRO_VALIDO = 0,
            TEM_CASA = 1,
            JA_SELECIONADA = 2,
            CADASTRO_INCOMPLETO = 3,
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Model
{
    public class Familia
    {
        public int Id { get; set; }
        public int RendaTotal { get; set; }
        public Enum.StatusFamilia Status { get; set; }
        public Pretendente Pretendente { get; set; }
    }
}

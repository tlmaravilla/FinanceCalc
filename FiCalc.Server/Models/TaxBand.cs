using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiCalc.Server.Models
{
    public class TaxBand
    {
        public decimal Lower { get; set; }
        public decimal Upper { get; set; }
        public decimal Rate { get; set; }
    }
}

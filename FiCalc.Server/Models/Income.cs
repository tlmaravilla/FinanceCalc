using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FiCalc.Server.Enums;

namespace FiCalc.Server.Models
{
    public class Income
    {
        public int TaxBracket { get; set; }

        [Required]
        public decimal Gross { get; set; }

        public decimal TakeHome { get; set; }

        [Required]
        public FileStatusEnum FileStatus { get; set; }
    }
}

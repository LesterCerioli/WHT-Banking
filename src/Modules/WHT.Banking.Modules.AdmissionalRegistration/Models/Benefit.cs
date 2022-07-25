using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHT.Banking.Infrastructure.Models;

namespace WHT.Banking.Modules.AdmissionalRegistration.Models
{
    public class Benefit : EntityBase
    {
        public int Type { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}

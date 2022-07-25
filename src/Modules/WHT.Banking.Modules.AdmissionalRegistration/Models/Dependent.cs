using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHT.Banking.Modules.AdmissionalRegistration.Models
{
    public class Dependent
    {
        public string Name { get; set; }
        public int Kinship { get; set; }
        public bool IsDependentIRRF { get; set; }
        public DateTime dtBirth { get; set; }
        public string TaxPayerRegistry { get; set; }
    }
}

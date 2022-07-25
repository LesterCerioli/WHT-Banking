using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHT.Banking.Infrastructure.Models;

namespace WHT.Banking.Modules.AdmissionalRegistration.Models
{
    public class BankAccount : EntityBase
    {
        public int? BankId { get; set; }
        public string Branch { get; set; }
        public string BranchDigit { get; set; }
        public string Account { get; set; }
        public string AccountDigit { get; set; }
    }
}

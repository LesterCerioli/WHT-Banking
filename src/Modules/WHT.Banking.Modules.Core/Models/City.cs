using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHT.Banking.Infrastructure.Models;

namespace WHT.Banking.Modules.Core.Models
{
    public class City : EntityBase
    {
        public string StateOrProvinceId { get; set; }

        public string Name { get; set; }
    }
}

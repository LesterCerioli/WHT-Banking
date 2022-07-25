using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHT.Banking.Infrastructure.Models;

namespace WHT.Banking.Modules.Core.Models
{
    public class Address : EntityBase
    {
        public int CountryId { get; set; }
        public int StateOrProvinceId { get; set; }

        public StateOrProvince StateOrProvince { get; set; }
        public int CityId { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string Description { get; set; }
        public int? Number { get; set; }
        public string Complement { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHT.Banking.Infrastructure.Models;

namespace WHT.Banking.Infrastructure.Localization
{
    public class LocalizedContentProperty : EntityBase
    {
        public long EntityId { get; set; }

        [StringLength(450)]
        public string EntityType { get; set; }

        [Required]
        public string CultureId { get; set; }

        public Culture Culture { get; set; }

        [Required]
        [StringLength(450)]
        public string ProperyName { get; set; }

        public string Value { get; set; }
    }
}

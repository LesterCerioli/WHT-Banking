﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHT.Banking.Infrastructure.Models;

namespace WHT.Banking.Modules.Core.Models
{
    public class Role : IdentityRole<long>, IEntityWithTypedId<long>
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Entities.Model
{
    public class Role: IdentityRole<Guid>
    {
        public List<Account>? Accounts { get; set; } 
    }
}
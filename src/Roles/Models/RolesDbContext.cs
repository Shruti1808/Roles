using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Roles.Models
{
    public class RolesDbContext : IdentityDbContext<ApplicationUser, MyIdentityRole, string>
     {
        public RolesDbContext(DbContextOptions<RolesDbContext> options) : base(options)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Roles.Models
{
    public class MyIdentityRole :IdentityRole
    {
        public string Description { get; set; }
    }
}

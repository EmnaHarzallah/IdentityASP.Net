using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApp1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string FullName { get; set; }
        public required string City { get; set; }
    }
}

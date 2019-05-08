using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_11_4.Models
{
    public class AuthenticateUser: IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [BindNever]
        public ICollection<Order> Orders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.DbModels.Identity;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.NET_Angular.Core.DbModels.Identity
{
    public class AppUser:IdentityUser
    {
        public string DisplayName { get; set; }
        public Address Address { get; set; }

    }
}

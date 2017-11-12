using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BethanysPieShop.Auth;

namespace BethanysPieShop.ViewModels
{
    public class UserInfoViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }

        public IEnumerable<Claim> Claims { get; set; }
    }
}

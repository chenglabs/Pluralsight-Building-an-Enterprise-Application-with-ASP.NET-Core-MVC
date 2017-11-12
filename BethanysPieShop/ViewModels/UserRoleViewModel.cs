using System.Collections.Generic;
using BethanysPieShop.Auth;
using Microsoft.AspNetCore.Identity;

namespace BethanysPieShop.ViewModels
{
    public class UserRoleViewModel
    {
        public UserRoleViewModel()
        {
            Users = new List<ApplicationUser>();
        }
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public List<ApplicationUser> Users { get; set; }

    }
}
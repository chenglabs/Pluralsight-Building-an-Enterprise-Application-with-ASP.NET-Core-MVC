using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace BethanysPieShop.Auth
{
    public class MinimumOrderAgeAppUserRequirementHandler : AuthorizationHandler<MinimumOrderAgeAppUserRequirement>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public MinimumOrderAgeAppUserRequirementHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, 
                                                             MinimumOrderAgeAppUserRequirement requirement)
        {


            //var taskGetUser =  _userManager.GetUserAsync(context.User);
            //taskGetUser.Wait();
            //var birthDate = taskGetUser.Result.Birthdate;

            var user = await _userManager.GetUserAsync(context.User);
            var birthDate = user.Birthdate;

            var ageInYears = DateTime.Today.Year - birthDate.Year;

            if (ageInYears >= requirement.MinimumOrderAge)
            {
                context.Succeed(requirement);
            }

            //return Task.CompletedTask;
        }
    }
}
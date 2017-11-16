using Microsoft.AspNetCore.Authorization;

namespace BethanysPieShop.Auth
{
    //https://stackoverflow.com/questions/42423282/dependency-injection-on-authorizationoptions-requirement-in-dotnet-core


    public class MinimumOrderAgeAppUserRequirement : IAuthorizationRequirement
    {
        public int MinimumOrderAge;

        public MinimumOrderAgeAppUserRequirement(int minimumOrderAge)
        {
            MinimumOrderAge = minimumOrderAge;
        }
    }
}
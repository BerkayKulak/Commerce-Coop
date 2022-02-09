using System.Linq;
using System.Security.Claims;

namespace ECommerce.NET_Angular.API.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string RetrieveEmailFromPrimcipal(this ClaimsPrincipal user)
        {
            return user?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
        }
    }
}

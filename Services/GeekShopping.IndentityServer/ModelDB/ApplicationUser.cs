using Microsoft.AspNetCore.Identity;

namespace GeekShopping.IndentityServer.ModelDB
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}

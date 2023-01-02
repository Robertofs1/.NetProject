using GeekShopping.IndentityServer.ModelDB;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.IdentityServer.Model.Context
{
    public class MYSQLContext : IdentityDbContext<ApplicationUser>
    {
        public MYSQLContext()
        {

        }
        public MYSQLContext(DbContextOptions<MYSQLContext> options)
            : base(options) { }
    }
}

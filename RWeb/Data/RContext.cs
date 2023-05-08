using Microsoft.EntityFrameworkCore;

namespace RWeb.Data
{
    public class RContext : DbContext
    {
        public RContext(DbContextOptions<RContext> options) : base(options)
        { 

        }
    }
}

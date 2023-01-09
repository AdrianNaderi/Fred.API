using Microsoft.EntityFrameworkCore;

namespace Fred.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //public virtual DbSet<Product> Products { get; set; }
        
    }
}

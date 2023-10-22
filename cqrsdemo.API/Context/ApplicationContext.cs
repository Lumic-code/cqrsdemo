using cqrsdemo.API.Models;
using Microsoft.EntityFrameworkCore;

namespace cqrsdemo.API.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}

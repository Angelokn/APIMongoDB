using APIMongoDB.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIMongoDB.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }


    }
}

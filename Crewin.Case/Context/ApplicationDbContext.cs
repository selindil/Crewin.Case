using Crewin.Case.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crewin.Case.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dimensions> Dimensions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Meta> Metas { get; set; }
    }
}

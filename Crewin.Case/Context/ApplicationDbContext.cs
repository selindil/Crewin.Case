using Crewin.Case.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crewin.Case.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    
    }
}

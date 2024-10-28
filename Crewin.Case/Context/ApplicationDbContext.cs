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
// Bu kod, ApplicationDbContext sınıfını tanımlayarak Category varlığını veritabanında bir tabloya bağlar ve bu tablo üzerinde işlem yapabilmemizi sağlar.
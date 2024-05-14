using Microsoft.EntityFrameworkCore;

namespace MesTaches.Data
{
    public class TacheContext : DbContext
    {
        public TacheContext(DbContextOptions<TacheContext> options) : base(options)
        {
        }

        public DbSet<Tache> Taches { get; set; }
    }
}

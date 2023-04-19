using ApiEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEnd.Data
{
    public class AllContext : DbContext
    {
        public AllContext(DbContextOptions<AllContext> options)
           : base(options)
        {

        }

       
        public DbSet<Eleve> Eleves { get; set; } = null!;
        public DbSet<Administrateurs> Administrateurs { get; set; } = null!;
        public DbSet<Coordinateurs> Coordinateurs { get; set; } = null!;
        public DbSet<Presence> Presences { get; set; } = null!;
    }
}

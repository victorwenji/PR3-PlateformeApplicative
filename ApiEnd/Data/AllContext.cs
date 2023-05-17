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

       
        public DbSet<Etudiant> Eleves { get; set; } = null!;
        public DbSet<Administrateurs> Administrateurs { get; set; } = null!;
        public DbSet<Coordinateurs> Coordinateurs { get; set; } = null!;
        public DbSet<Presence> Presences { get; set; } = null!;
        public DbSet<ApiEnd.Models.Groupe> Groupe { get; set; } = default!;
        public DbSet<ApiEnd.Models.Promotion> Promotion { get; set; } = default!;
    }
}

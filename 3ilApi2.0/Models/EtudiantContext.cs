using Microsoft.EntityFrameworkCore;

namespace _3ilApi2._0.Models
{
    public class EtudiantContext : DbContext
    {
        public EtudiantContext(DbContextOptions<EtudiantContext> options) 
            : base (options)
        { 

        }

        public DbSet<Etudiant> Etudiants { get; set; } = null!;
    }
}

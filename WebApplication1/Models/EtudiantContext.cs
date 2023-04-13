using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class EtudiantContext : DbContext
    {
        public EtudiantContext(DbContextOptions<EtudiantContext> options)
            : base(options)
        {
        }

        public DbSet<Etudiant> Etudiants { get; set; } = null!;
    }
}

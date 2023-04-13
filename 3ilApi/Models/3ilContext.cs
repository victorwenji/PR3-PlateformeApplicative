
using Microsoft.EntityFrameworkCore;

namespace _3ilApi.Models
{
    public class _3ilContext : DbContext
    {
        public _3ilContext(DbContextOptions<_3ilContext> options)
            : base(options)
        {

        }

        public DbSet<Compte> Compte { get; set; } = null!;
    }
}

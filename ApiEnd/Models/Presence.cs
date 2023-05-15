using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEnd.Models
{
    public class Presence
    {
        public int Id { get; set; }
        public DateTime HeureDate { get; set; }

        [ForeignKey("Etudiant")]
        public string EtudiantId { get; set; }
        public Presence()
        {
            
        }
    }
}

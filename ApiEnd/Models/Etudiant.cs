using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEnd.Models
{
    public class Etudiant 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; } = string.Empty;

        [ForeignKey("Groupe")]
        public string GroupeId { get; set; }

        [ForeignKey("Promotion")]
        public string PromotionId { get; set; }
        public Etudiant()
        {
            
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Mobile.Models
{
    public class Etudiant 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public int GroupeId { get; set; }
    
        public int PromotionId { get; set; }
        public Etudiant()
        {
            
        }
    }
}

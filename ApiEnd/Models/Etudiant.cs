using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEnd.Models
{
    public class Etudiant 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        [ForeignKey("GroupeId")]
        //pourquoi crée groupr de type groupe
        //public Groupe Groupes { get; set; }
        public int GroupeId { get; set; }

        [ForeignKey("PromotionId")]
        //public Promotion Promotions { get; set; }
        public int PromotionId { get; set; }
        public Etudiant()
        {
            
        }
    }
}

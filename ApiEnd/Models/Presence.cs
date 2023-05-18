using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEnd.Models
{
    public class Presence
    {
        public int Id { get; set; }
        public DateTime HeureDate { get; set; }
        public bool Status { get; set; } 

        //public enum Statuts 
        //{
        //    Present, //0
        //    Absent //1  
        //}

        [ForeignKey("Etudiant")]
        //pourqoui la redondance de donnée
        //public Etudiant Etudiants { get; set; }
        public int EtudiantId { get; set; }
        public Presence()
        {
            
        }
    }
}

namespace ApiEnd.Models
{
    public class Eleve 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Mdp { get; set; }
        public string Referentielle { get; set; }
        public string Promotion { get; set; }
        public Eleve()
        {
            
        }
    }
}

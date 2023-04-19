namespace ApiEnd.Models
{
    public class Coordinateurs 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Mdp { get; set; }
        public Coordinateurs() 
        {

        }
    }
}

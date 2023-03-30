namespace _3ilApi2._0.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string REferentielle { get; set; }

        public DateTime DateDeCreation { get; set; }
        public Etudiant() { }

    }
}

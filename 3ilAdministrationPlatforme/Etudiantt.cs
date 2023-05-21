using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ilAdministrationPlatforme
{
    internal class Etudiantt
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public int GroupeId { get; set; }

        public int PromotionId { get; set; }
        public Etudiantt()
        {

        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3ilAdministrationPlatforme
{
    public partial class CreationEtudiant : Form
    {
        //private Etudiantt OldEtudiant;
        public CreationEtudiant()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            tbEmail.Clear();
            tbName.Clear();
            tbPrenom.Clear();
        }
        private async void btnsave_Click(object sender, EventArgs e)
        {   
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7219");
           
            Etudiant etudiantt = new Etudiant();
            etudiantt.Nom= tbName.Text;
            etudiantt.Email= tbEmail.Text;
            etudiantt.Prenom = tbPrenom.Text;
            string Groupes = comboGRoupe.Text;
            if(Groupes != null)
            {
                //l'id correspondant a la promotion MS2D-Fa = 4
                if(Groupes == "MS2D-FA")
                {
                    Groupes = "4";
                }
                else
                {
                    // l'id 7 correspond a MS2D-FE
                    Groupes = "7";
                }
            }
            etudiantt.GroupeId = Int32.Parse(Groupes);
            string Promotions = comboPromo.Text;
            if (Promotions != null)
            {
                //l'id correspondant a la promotion MS2D-Fa = 4
                if (Promotions == "2022-2023")
                {
                    Promotions = "1";
                }
                else
                {
                    // l'id 7 correspond a MS2D-FE
                    Promotions = "2";
                }
            }
            etudiantt.PromotionId = Int32.Parse(Promotions);

            HttpResponseMessage response = await client.PostAsJsonAsync("api/Etudiants", etudiantt);

            Clear();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void CreationEtudiant_Load(object sender, EventArgs e)
        {

        }
    }
}

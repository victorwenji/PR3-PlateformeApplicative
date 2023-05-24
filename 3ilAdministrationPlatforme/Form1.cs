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
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Xml.Linq;
using System.Reflection;

namespace _3ilAdministrationPlatforme
{
    public partial class Form1 : Form
    {
        private Etudiant OldEtudiantt;
        private readonly HttpClient _httpClient;
        public Form1()
        {
            InitializeComponent();
          
        }

        public async void ListEtudiant(object sender, EventArgs e)
        {
            //string Url = "https://localhost:7219/api/Etudiant";
            //HttpResponseMessage request = await _httpClient.GetAsync(Url);
            //if (request.IsSuccessStatusCode)
            //{
            //    var content = await request.Content.ReadAsStringAsync();
            //    var Etudiants = JsonConvert.DeserializeObject<List<Etudiant>>(content);
            //    foreach (var Etudiant in Etudiants)
            //    {
            //        dataGridView1.DataSource = Etudiant;
            //    }
            //}

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            CreationEtudiant creationEtudiant = new CreationEtudiant();
            creationEtudiant.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   // la meilleur solution etait de recupere les donne de lapi via le model 
            //mais je n'ais pa reussi et jai du cree une classe qui reproduit le modelle d'origine
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7219");

            HttpResponseMessage response = client.GetAsync("api/Etudiants").Result;
            if(response.IsSuccessStatusCode)
            {

                var mp = response.Content.ReadAsAsync<IEnumerable<Etudiant>>().Result;
                dataGridView1.DataSource = mp;
            }
            //le nombre de ligne
            ToTal.Text = $"Nombre D'étudiant :{dataGridView1.RowCount}";
           
            dataGridView1.Refresh();
        }
        private void Init()
        {
            dataGridView1.Rows[0].Selected = true;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.OldEtudiantt.GetType.ToString()           (
            //        X=>
            //        X.Nom.Tolower().Contains(textBox1.Text.ToLower()) ||
            //        X.PreNom.Tolower().Contains(textBox1.Text.ToLower()),
            //        Form1_Load
            //    );
            //List<Etudiant> results = new List<Etudiant>();
            //foreach (var Etudiant in results)
            //{
            //    if (Etudiant.Nom.ToLower().Contains(textBox1.Text.ToLower()))
            //    {
            //        results.Add(Etudiant);
            //    }
            //}

            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
            //    String.Format("Nom like '%" + textBox1.Text + "%'");
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(e.KeyChar == (char)13)
            {

            }
        }

        private void ToTal_Click(object sender, EventArgs e)
        {
            //ToTal.Text = $"Nombre D'étudiant :{dataGridView1.RowCount}";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //selectione une ligne et ouvre le formulaire de modification en fonction des donne de cette ligne 
            if(e.RowIndex != null)
            {
                this.OldEtudiantt = dataGridView1.SelectedRows[0].DataBoundItem as Etudiant;
                tbId.Text = this.OldEtudiantt.Id.ToString();
                tbName.Text = this.OldEtudiantt.Nom;
                tbPrenom.Text = this.OldEtudiantt.Prenom;
                tbEmail.Text = this.OldEtudiantt.Email;
                comboGRoupe.Text = this.OldEtudiantt.GroupeId.ToString();
                comboPromo.Text = this.OldEtudiantt.PromotionId.ToString();
                this.Refresh();
            }
            //ModifierEtudiant md = new ModifierEtudiant();
            //md.Show();
           

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //modifier les donne avant d'afficher
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count >0)
            {
                this.OldEtudiantt = dataGridView1.SelectedRows[0].DataBoundItem as Etudiant;
                tbId.Text = this.OldEtudiantt.Id.ToString();
                tbName.Text = this.OldEtudiantt.Nom;
                tbPrenom.Text = this.OldEtudiantt.Prenom;
                tbEmail.Text = this.OldEtudiantt.Email;
                comboGRoupe.Text = this.OldEtudiantt.GroupeId.ToString();
                comboPromo.Text = this.OldEtudiantt.PromotionId.ToString();
                this.Refresh();
            }
        }
        public void Clear()
        {   
            tbId.Clear();
            tbEmail.Clear();
            tbName.Clear();
            tbPrenom.Clear();
        }

        private async void btnModifier_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7219");

            Etudiant etudiantt = new Etudiant();
            string Id = tbId.Text;
            etudiantt.Id = Int32.Parse(Id); 
            etudiantt.Nom = tbName.Text;
            etudiantt.Email = tbEmail.Text;
            etudiantt.Prenom = tbPrenom.Text;
            string Groupes = comboGRoupe.Text;
            if (Groupes != null)
            {
                //l'id correspondant a la promotion MS2D-Fa = 4
                if (Groupes == "MS2D-FA")
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

            HttpResponseMessage response = await client.PutAsJsonAsync("api/Etudiants/" + etudiantt.Id, etudiantt);
            Clear();
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7219");

            Etudiant etudiantt = new Etudiant();
            string Id = tbId.Text;
            etudiantt.Id = Int32.Parse(Id);
            etudiantt.Nom = tbName.Text;
            etudiantt.Email = tbEmail.Text;
            etudiantt.Prenom = tbPrenom.Text;
            string Groupes = comboGRoupe.Text;
            if (Groupes != null)
            {
                //l'id correspondant a la promotion MS2D-Fa = 4
                if (Groupes == "MS2D-FA")
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

            HttpResponseMessage response = await client.DeleteAsync("api/Etudiants/" + etudiantt.Id);
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3ilAdministrationPlatforme
{
    public partial class Groupes : Form
    {
        public Groupes()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            tbName.Clear();
            tbPrenom.Clear();
        }

        private async void btnModifier_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7219");
            Groupe groupe = new Groupe();
            groupe.Name = tbName.Text;
            groupe.Description = tbPrenom.Text;
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Groupes", groupe);
            Clear();
            Groupes groupes = new Groupes();
            groupes.Show();
            this.Close();
            dataGridView1.Refresh();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7219");

            Groupe groupe2 = new Groupe();
            string Id = tbId.Text;
            groupe2.Id = Int32.Parse(Id);
            groupe2.Name = tbName.Text;
            groupe2.Description =tbPrenom.Text;
            HttpResponseMessage response = await client.PutAsJsonAsync("api/Groupes/" + groupe2.Id, groupe2);
            Clear();
            Groupes groupe = new Groupes();
            groupe.Show();
            this.Close();
            dataGridView1.Refresh();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7219");

            Groupe groupe3 = new Groupe();
            string Id = tbId.Text;
            groupe3.Id = Int32.Parse(Id);
            groupe3.Name = tbName.Text;
            groupe3.Description = tbPrenom.Text;
            HttpResponseMessage response = await client.DeleteAsync("api/Groupes/" + groupe3.Id);
            Groupes groupe = new Groupes();
            groupe.Show();
            this.Close();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Accéder aux valeurs des cellules de la ligne sélectionnée
                string id = selectedRow.Cells["id"].Value.ToString();
                string nom = selectedRow.Cells["name"].Value.ToString();
                string des = selectedRow.Cells["description"].Value.ToString();

                tbId.Text = id;
                tbName.Text = nom;
                tbPrenom.Text = nom;


            }
        }

        private void Groupes_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7219");

            HttpResponseMessage response = client.GetAsync("api/Groupes").Result;
            if (response.IsSuccessStatusCode)
            {
                var groupes = response.Content.ReadAsAsync<IEnumerable<Groupe>>().Result;
                dataGridView1.DataSource = groupes.ToList();
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite lors de la récupération des groupes.");
            }
        }
    }
}

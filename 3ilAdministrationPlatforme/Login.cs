using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3ilAdministrationPlatforme
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=3ildatabase;Integrated Security=true");


        private void btnsave_Click(object sender, EventArgs e)
        {
            string Email, Motdepasse;
            Email = txtIden.Text;
            Motdepasse = txtpasseword.Text;

            try
            {
                string querry = "SELECT * FROM Administrateurs WHERE Email = '" + txtIden.Text + "' AND MDP = '" + txtpasseword.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Email = txtIden.Text;
                    Motdepasse = txtpasseword.Text;

                    Form1 form = new Form1();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("connexion invalide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIden.Clear();
                    txtpasseword.Clear();
                    txtIden.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Base de donnée non vaide");
            }
            finally { conn.Close(); }
           
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
            this.Close();
        }
    }
}

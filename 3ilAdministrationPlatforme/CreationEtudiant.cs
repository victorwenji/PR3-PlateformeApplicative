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

namespace _3ilAdministrationPlatforme
{
    public partial class CreationEtudiant : Form
    {
        public CreationEtudiant()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=3il2;integrated security=True;TrustServerCertificate=True");
        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=3il2;integrated security=True;TrustServerCertificate=True");
            int ID = int.Parse(tbId.Text);
            string name = tbName.Text;
            string Prennom = tbPrenom.Text;
            string Ref = tbRef.Text;
            DateTime dateTime = DateTime.Parse(dateTimePicker1.Text) ;
            con.Open();
            SqlCommand c = new SqlCommand("exec Insert_E '" + ID + "','" + name + "','" + Prennom + "','" + Ref + "','" + dateTime + "'");
            c.ExecuteNonQueryAsync();
            MessageBox.Show("Etudiant Enregistre....");
            con.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}

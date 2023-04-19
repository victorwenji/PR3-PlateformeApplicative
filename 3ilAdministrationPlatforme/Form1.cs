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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=3il2;integrated security=True;TrustServerCertificate=True"); 

        void GetList()
        {
            SqlCommand c = new SqlCommand("exec LIST_E", con);
            SqlDataAdapter adapter = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            CreationEtudiant creationEtudiant = new CreationEtudiant();
            creationEtudiant.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetList();
        }
    }
}

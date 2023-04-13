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
         
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=3il;integrated security=True;TrustServerCertificate=True"); 

        void GetComptes()
        {
            SqlCommand c = new SqlCommand("exec");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            CreationEtudiant creationEtudiant = new CreationEtudiant();
            creationEtudiant.ShowDialog();
        }
    }
}

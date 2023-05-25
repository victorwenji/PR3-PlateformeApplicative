using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3ilBorne
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            //Borne borne = new Borne(); 
            //borne.Show();

            Capteur capteur = new Capteur();
            capteur.Show();
            this.Close();
        }
    }
}

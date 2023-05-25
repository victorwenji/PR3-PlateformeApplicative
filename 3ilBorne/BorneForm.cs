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
    public partial class Borne : Form
    {
        public Borne()
        {
            InitializeComponent();
            Random alea = new Random();
        }
        
        
        

       

        private void button1_Click(object sender, EventArgs e)
        {
            Random alea = new Random();
            int Code = alea.Next(1, 100);
            string SCode = Code.ToString();
            Zen.Barcode.CodeQrBarcodeDraw QrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = QrCode.Draw(SCode, 100);
        }
    }
}

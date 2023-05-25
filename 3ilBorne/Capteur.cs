using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace _3ilBorne
{
    public partial class Capteur : Form
    {
        private FilterInfoCollection CaptureDivice;
        private VideoCaptureDevice FinalFrame;
        public Capteur()
        {
            InitializeComponent();
        }

        private void Capteur_Load(object sender, EventArgs e)
        {
            CaptureDivice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo Device in CaptureDivice)
            {
                comboCamera.Items.Add(Device.Name);
            }
            comboCamera.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDivice[comboCamera.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start(); 
        } 

        private void FinalFrame_NewFrame(object sender,NewFrameEventArgs eventArgs )
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Capteur_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FinalFrame.IsRunning == true) 
            {
                FinalFrame.Stop(); 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                if (result != null)
                {
                    
                    var decode = result.ToString().Trim();
                    if (decode != "")
                    {
                        textBox1.Text = decode;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la manipulation du résultat du décodage du code-barres : " + ex.Message);

            }
        }

        private void btnScane_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
  
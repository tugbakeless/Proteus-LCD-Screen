using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lcd_ekran
{
    public partial class SplashS : Form
    {
        public SplashS()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void SplashS_Load(object sender, EventArgs e)
        {

            timer1.Interval = 1500;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
    }
}

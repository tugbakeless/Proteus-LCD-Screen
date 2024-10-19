using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lcd_ekran
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();



            label1.Text = "MİKRODENETLEYİCİLER";
            label1.Location = new Point(this.Width, label1.Location.Y); // Yazıyı formun sağından başlat
            timer1.Interval = 50;  // Timer intervalini ayarla (ms)
            timer1.Start();  // Timer'ı başlat


        }


        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int t = 0;
        int f = 0;
        int g = 0;
        int h = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.BackColor == Color.SteelBlue)
            {

                button1.BackColor = Color.White;
                a = a - 16;

            }
            else
            {
                button1.BackColor = Color.SteelBlue;
                a += 16;



            }
            label7.Text = Convert.ToString(a);
            label16.Text = Convert.ToString(a) + ",";



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Label'ı sola doğru kaydır
            label1.Left -= 5;  // Her adımda 5 piksel sola kaydır

            // Eğer yazı formun solundan çıktıysa, sağdan tekrar başlat
            if (label1.Right < 0)
            {
                label1.Left = this.Width;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (button2.BackColor == Color.SteelBlue)
            {
                button2.BackColor = Color.White;
                a = a - 8;

            }
            else
            {
                button2.BackColor = Color.SteelBlue;
                a += 8;

            }
            label7.Text = Convert.ToString(a);
            label16.Text = Convert.ToString(a) + ",";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button3.BackColor == Color.SteelBlue)
            {
                button3.BackColor = Color.White;
                a = a - 4;


            }
            else
            {
                button3.BackColor = Color.SteelBlue;
                a += 4;

            }
            label7.Text = Convert.ToString(a);
            label16.Text = Convert.ToString(a) + ",";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (button4.BackColor == Color.SteelBlue)
            {
                button4.BackColor = Color.White;
                a -= 2;

            }
            else
            {
                button4.BackColor = Color.SteelBlue;
                a += 2;

            }
            label7.Text = Convert.ToString(a);
            label16.Text = Convert.ToString(a) + ",";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (button8.BackColor == Color.SteelBlue)
            {
                button8.BackColor = Color.White;
                b -= 16;

            }
            else
            {

                button8.BackColor = Color.SteelBlue;
                b += 16;

            }
            label8.Text = Convert.ToString(b);
            label17.Text = Convert.ToString(b) + ",";

        }


        private void button7_Click(object sender, EventArgs e)
        {

            if (button7.BackColor == Color.SteelBlue)
            {
                button7.BackColor = Color.White;
                b -= 8;

            }
            else
            {
                button7.BackColor = Color.SteelBlue;
                b += 8;

            }
            label8.Text = Convert.ToString(b);
            label17.Text = Convert.ToString(b) + ",";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (button6.BackColor == Color.SteelBlue)
            {
                button6.BackColor = Color.White;
                b -= 4;

            }
            else
            {
                button6.BackColor = Color.SteelBlue;
                b += 4;

            }
            label8.Text = Convert.ToString(b);
            label17.Text = Convert.ToString(b) + ",";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (button5.BackColor == Color.SteelBlue)
            {
                button5.BackColor = Color.White;
                b -= 2;

            }
            else
            {
                button5.BackColor = Color.SteelBlue;
                b += 2;

            }
            label8.Text = Convert.ToString(b);
            label17.Text = Convert.ToString(b) + ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (button12.BackColor == Color.SteelBlue)
            {
                button12.BackColor = Color.White;
                c -= 16;


            }
            else
            {
                button12.BackColor = Color.SteelBlue;
                c += 16;

            }
            label10.Text = Convert.ToString(c);
            label18.Text = Convert.ToString(c) + ",";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (button11.BackColor == Color.SteelBlue)
            {
                button11.BackColor = Color.White;
                c -= 8;

            }
            else
            {
                button11.BackColor = Color.SteelBlue;
                c += 8;

            }
            label10.Text = Convert.ToString(c);
            label18.Text = Convert.ToString(c) + ",";
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (button10.BackColor == Color.SteelBlue)
            {
                button10.BackColor = Color.White;
                c -= 4;

            }
            else
            {
                button10.BackColor = Color.SteelBlue;
                c += 4;

            }
            label10.Text = Convert.ToString(c);
            label18.Text = Convert.ToString(c) + ",";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (button9.BackColor == Color.SteelBlue)
            {
                button9.BackColor = Color.White;
                c -= 2;

            }
            else
            {
                button9.BackColor = Color.SteelBlue;
                c += 2;

            }
            label10.Text = Convert.ToString(c);
            label18.Text = Convert.ToString(c) + ",";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (button16.BackColor == Color.SteelBlue)
            {
                button16.BackColor = Color.White;
                d -= 16;

            }
            else
            {
                button16.BackColor = Color.SteelBlue;
                d += 16;

            }
            label11.Text = Convert.ToString(d);
            label19.Text = Convert.ToString(d) + ",";
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (button15.BackColor == Color.SteelBlue)
            {
                button15.BackColor = Color.White;
                d -= 8;

            }
            else
            {
                button15.BackColor = Color.SteelBlue;
                d += 8;

            }
            label11.Text = Convert.ToString(d);
            label19.Text = Convert.ToString(d) + ",";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (button14.BackColor == Color.SteelBlue)
            {
                button14.BackColor = Color.White;
                d -= 4;

            }
            else
            {
                button14.BackColor = Color.SteelBlue;
                d += 4;

            }
            label11.Text = Convert.ToString(d);
            label19.Text = Convert.ToString(d) + ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (button13.BackColor == Color.SteelBlue)
            {
                button13.BackColor = Color.White;
                d -= 2;

            }
            else
            {
                button13.BackColor = Color.SteelBlue;
                d += 2;

            }
            label11.Text = Convert.ToString(d);
            label19.Text = Convert.ToString(d) + ",";
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (button20.BackColor == Color.SteelBlue)
            {
                button20.BackColor = Color.White;
                t -= 16;

            }
            else
            {
                button20.BackColor = Color.SteelBlue;
                t += 16;

            }
            label12.Text = Convert.ToString(t);
            label20.Text = Convert.ToString(t) + ",";
        }

        private void button19_Click(object sender, EventArgs e)
        {

            if (button19.BackColor == Color.SteelBlue)
            {
                button19.BackColor = Color.White;
                t -= 8;

            }
            else
            {
                button19.BackColor = Color.SteelBlue;
                t += 8;

            }
            label12.Text = Convert.ToString(t);
            label20.Text = Convert.ToString(t) + ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (button18.BackColor == Color.SteelBlue)
            {
                button18.BackColor = Color.White;
                t -= 4;

            }
            else
            {
                button18.BackColor = Color.SteelBlue;
                t += 4;

            }
            label12.Text = Convert.ToString(t);
            label20.Text = Convert.ToString(t) + ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (button17.BackColor == Color.SteelBlue)
            {
                button17.BackColor = Color.White;
                t -= 2;

            }
            else
            {
                button17.BackColor = Color.SteelBlue;
                t += 2;

            }
            label12.Text = Convert.ToString(t);
            label20.Text = Convert.ToString(t) + ",";
        }

        private void button24_Click(object sender, EventArgs e)
        {

            if (button24.BackColor == Color.SteelBlue)
            {
                button24.BackColor = Color.White;
                f -= 16;

            }
            else
            {
                button24.BackColor = Color.SteelBlue;
                f += 16;

            }
            label13.Text = Convert.ToString(f);
            label21.Text = Convert.ToString(f) + ",";

        }

        private void button23_Click(object sender, EventArgs e)
        {

            if (button23.BackColor == Color.SteelBlue)
            {
                button23.BackColor = Color.White;
                f -= 8;

            }
            else
            {
                button23.BackColor = Color.SteelBlue;
                f += 8;

            }
            label13.Text = Convert.ToString(f);
            label21.Text = Convert.ToString(f) + ",";
        }

        private void button22_Click(object sender, EventArgs e)
        {

            if (button22.BackColor == Color.SteelBlue)
            {
                button22.BackColor = Color.White;
                f -= 4;

            }
            else
            {
                button22.BackColor = Color.SteelBlue;
                f += 4;

            }
            label13.Text = Convert.ToString(f);
            label21.Text = Convert.ToString(f) + ",";
        }

        private void button21_Click(object sender, EventArgs e)
        {

            if (button21.BackColor == Color.SteelBlue)
            {
                button21.BackColor = Color.White;
                f -= 2;


            }
            else
            {
                button21.BackColor = Color.SteelBlue;
                f += 2;

            }
            label13.Text = Convert.ToString(f);
            label21.Text = Convert.ToString(f) + ",";
        }

        private void button28_Click(object sender, EventArgs e)
        {

            if (button28.BackColor == Color.SteelBlue)
            {
                button28.BackColor = Color.White;
                g -= 16;

            }
            else
            {
                button28.BackColor = Color.SteelBlue;
                g += 16;

            }
            label14.Text = Convert.ToString(g);
            label22.Text = Convert.ToString(g) + ",";
        }

        private void button27_Click(object sender, EventArgs e)
        {

            if (button27.BackColor == Color.SteelBlue)
            {
                button27.BackColor = Color.White;
                g -= 8;

            }
            else
            {
                button27.BackColor = Color.SteelBlue;
                g += 8;

            }
            label14.Text = Convert.ToString(g);
            label22.Text = Convert.ToString(g) + ",";
        }

        private void button26_Click(object sender, EventArgs e)
        {

            if (button26.BackColor == Color.SteelBlue)
            {
                button26.BackColor = Color.White;
                g -= 4;

            }
            else
            {
                button26.BackColor = Color.SteelBlue;
                g += 4;

            }
            label14.Text = Convert.ToString(g);
            label22.Text = Convert.ToString(g) + ",";
        }

        private void button25_Click(object sender, EventArgs e)
        {

            if (button25.BackColor == Color.SteelBlue)
            {
                button25.BackColor = Color.White;
                g -= 2;

            }
            else
            {
                button25.BackColor = Color.SteelBlue;
                g += 2;

            }
            label14.Text = Convert.ToString(g);
            label22.Text = Convert.ToString(g) + ",";

        }

        private void button32_Click(object sender, EventArgs e)
        {

            if (button32.BackColor == Color.SteelBlue)
            {
                button32.BackColor = Color.White;
                h -= 16;

            }
            else
            {
                button32.BackColor = Color.SteelBlue;
                h += 16;

            }
            label15.Text = Convert.ToString(h);
            label23.Text = Convert.ToString(h);
        }

        private void button31_Click(object sender, EventArgs e)
        {

            if (button31.BackColor == Color.SteelBlue)
            {
                button31.BackColor = Color.White;
                h -= 8;


            }
            else
            {
                button31.BackColor = Color.SteelBlue;
                h += 8;

            }
            label15.Text = Convert.ToString(h);
            label23.Text = Convert.ToString(h);

        }

        private void button30_Click(object sender, EventArgs e)
        {

            if (button30.BackColor == Color.SteelBlue)
            {
                button30.BackColor = Color.White;
                h -= 4;

            }
            else
            {
                button30.BackColor = Color.SteelBlue;
                h += 4;

            }
            label15.Text = Convert.ToString(h);
            label23.Text = Convert.ToString(h);

        }

        private void button29_Click(object sender, EventArgs e)
        {

            if (button29.BackColor == Color.SteelBlue)
            {
                button29.BackColor = Color.White;
                h -= 2;

            }
            else
            {
                button29.BackColor = Color.SteelBlue;
                h += 2;

            }
            label15.Text = Convert.ToString(h);
            label23.Text = Convert.ToString(h);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

            if (button33.BackColor == Color.SteelBlue)
            {
                button33.BackColor = Color.White;
                h -= 1;

            }
            else
            {
                button33.BackColor = Color.SteelBlue;
                h += 1;

            }
            label15.Text = Convert.ToString(h);
            label23.Text = Convert.ToString(h);



        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button34.BackColor == Color.SteelBlue)
            {
                button34.BackColor = Color.White;
                g -= 1;

            }
            else
            {
                button34.BackColor = Color.SteelBlue;
                g += 1;

            }
            label14.Text = Convert.ToString(g);
            label22.Text = Convert.ToString(g) + ",";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.BackColor == Color.SteelBlue)
            {
                button35.BackColor = Color.White;
                f -= 1;

            }
            else
            {
                button35.BackColor = Color.SteelBlue;
                f += 1;

            }
            label13.Text = Convert.ToString(f);
            label21.Text = Convert.ToString(f) + ",";

        }

        private void button36_Click(object sender, EventArgs e)
        {

            if (button36.BackColor == Color.SteelBlue)
            {
                button36.BackColor = Color.White;
                t -= 1;

            }
            else
            {
                button36.BackColor = Color.SteelBlue;
                t += 1;

            }
            label12.Text = Convert.ToString(t);
            label20.Text = Convert.ToString(t) + ",";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (button37.BackColor == Color.SteelBlue)
            {
                button37.BackColor = Color.White;
                d -= 1;

            }
            else
            {
                button37.BackColor = Color.SteelBlue;
                d += 1;

            }
            label11.Text = Convert.ToString(d);
            label19.Text = Convert.ToString(d) + ",";
        }

        private void button38_Click(object sender, EventArgs e)
        {

            if (button38.BackColor == Color.SteelBlue)
            {
                button38.BackColor = Color.White;
                c -= 1;

            }
            else
            {
                button38.BackColor = Color.SteelBlue;
                c += 1;

            }
            label10.Text = Convert.ToString(c);
            label18.Text = Convert.ToString(c) + ",";

        }

        private void button39_Click(object sender, EventArgs e)
        {

            if (button39.BackColor == Color.SteelBlue)
            {
                button39.BackColor = Color.White;
                b -= 1;

            }
            else
            {
                button39.BackColor = Color.SteelBlue;
                b += 1;

            }
            label8.Text = Convert.ToString(b);
            label17.Text = Convert.ToString(b) + ",";
        }

        private void button40_Click(object sender, EventArgs e)
        {

            if (button40.BackColor == Color.SteelBlue)
            {
                button40.BackColor = Color.White;
                a -= 1;

            }
            else
            {
                button40.BackColor = Color.SteelBlue;
                a += 1;

            }
            label7.Text = Convert.ToString(a);
            label16.Text = Convert.ToString(a) + ",";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {



        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearTable();


        }
        private void ClearTable()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.White;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    t = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    label7.Text = Convert.ToString(a);
                    label8.Text = Convert.ToString(b);
                    label10.Text = Convert.ToString(c);
                    label11.Text = Convert.ToString(d);
                    label12.Text = Convert.ToString(t);
                    label13.Text = Convert.ToString(f);
                    label14.Text = Convert.ToString(g);
                    label15.Text = Convert.ToString(h);

                    label16.Text = Convert.ToString(a) + ",";
                    label17.Text = Convert.ToString(b) + ",";
                    label18.Text = Convert.ToString(c) + ",";
                    label19.Text = Convert.ToString(d) + ",";
                    label20.Text = Convert.ToString(t) + ",";
                    label21.Text = Convert.ToString(f) + ",";
                    label22.Text = Convert.ToString(g) + ",";
                    label23.Text = Convert.ToString(h) + ",";

                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            string yazi = "";
            yazi += label6.Text + label16.Text + label17.Text + label18.Text + label19.Text + label20.Text +
                label21.Text + label22.Text + label23.Text;
            Clipboard.SetText(yazi);
            MessageBox.Show("Metin kopyalandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.Add("Arı", null, (s, ev) => Ari());
            contextMenuStrip.Items.Add("Çiçek", null, (s, ev) => Cicek());
            contextMenuStrip.Items.Add("Güneş", null, (s, ev) => Gunes());
            contextMenuStrip.Items.Add("Kalp", null, (s, ev) => Kalp());
            contextMenuStrip.Items.Add("Ok", null, (s, ev) => Ok());

            // Menü'yü butonun altına göster
            contextMenuStrip.Show(button42, new Point(0, button42.Height));



        }
        private void Cicek()
        {
            ClearTable();

            Button[] buttons = { button3, button4, button40, button6, button39,
                         button9, button10, button38, button15, button19, button20, button24, button28};


            foreach (var button in buttons)
            {
                button.BackColor = Color.Red;
            }

            label16.Text = Convert.ToString("7") + ",";
            label17.Text = Convert.ToString("5") + ",";
            label18.Text = Convert.ToString("7" + ",");
            label19.Text = Convert.ToString("8") + ",";
            label20.Text = Convert.ToString("24") + ",";
            label21.Text = Convert.ToString("16") + ",";
            label22.Text = Convert.ToString("16") + ",";

        }
        private void Ari()
        {
            ClearTable();

            Button[] buttons = { button5, button6, button9, button10, button11,
                         button16, button37, button20, button21, button22, button23, button36, button26, button25 };


            foreach (var button in buttons)
            {
                button.BackColor = Color.Red;
            }

            label17.Text = Convert.ToString("6") + ",";
            label18.Text = Convert.ToString("14" + ",");
            label19.Text = Convert.ToString("17") + ",";
            label20.Text = Convert.ToString("17") + ",";
            label21.Text = Convert.ToString("14") + ",";
            label22.Text = Convert.ToString("6") + ",";






        }
        private void Gunes()
        {
            ClearTable();

            Button[] buttons = { button12, button10, button38, button15, button14,
                         button13, button20, button19, button17, button36, button23, button22, button21, button28, button26, button34  };


            foreach (var button in buttons)
            {

                button.BackColor = Color.Red;
            }
            label18.Text = Convert.ToString("21" + ",");
            label19.Text = Convert.ToString("14") + ",";
            label20.Text = Convert.ToString("27") + ",";
            label21.Text = Convert.ToString("14") + ",";
            label22.Text = Convert.ToString("21") + ",";




        }
        private void Ok()
        {
            ClearTable();

            Button[] buttons = { button10, button15, button20, button19, button18,
                         button17, button36, button23, button26 };


            foreach (var button in buttons)
            {
                button.BackColor = Color.Red;
            }

            label18.Text = Convert.ToString("4" + ",");
            label19.Text = Convert.ToString("8") + ",";
            label20.Text = Convert.ToString("31") + ",";
            label21.Text = Convert.ToString("8") + ",";
            label22.Text = Convert.ToString("4") + ",";

        }
        private void Kalp()
        {
            ClearTable();
            Button[] buttons = { button8, button7, button5, button39, button12,
                         button38, button10, button16, button37,
                         button19, button17, button22 };


            foreach (var button in buttons)
            {
                button.BackColor = Color.Red;
            }
            label17.Text = Convert.ToString("27" + ",");
            label18.Text = Convert.ToString("21" + ",");
            label19.Text = Convert.ToString("17") + ",";
            label20.Text = Convert.ToString("10") + ",";
            label21.Text = Convert.ToString("4") + ",";


        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}


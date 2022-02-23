using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5._31_ButonYakalamaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sure = 0;
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            int x = rnd.Next(1, genislik - 20);
            int y = rnd.Next(1, yukseklik - 70);
            button1.Location = new Point(x, y);
            lGecenSure.Text = sure.ToString();

        }

        int genislik, yukseklik;
        private void Form1_Load(object sender, EventArgs e)
        {
            genislik = this.Width;
            yukseklik = this.Height - 50;
            timer1.Interval = 500;
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(lBasariliTiklamaSayisi.Text);
            sayi++;
            lBasariliTiklamaSayisi.Text = sayi.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int sayi = Convert.ToInt32(lBasarisizTiklamaSayisi.Text);
            sayi++;
            lBasarisizTiklamaSayisi.Text = sayi.ToString();
        }
    }
}

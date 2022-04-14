using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress;
using DevExpress.XtraEditors;

namespace HesapMakinasiOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double S1, S2, islem;
        HesapMakinasiOrnek.Models.Hesapla hesap = new Models.Hesapla();

        private void iletişimPenceresiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iletisim ilet = new Iletisim();
            this.Hide();
            ilet.ShowDialog();
            this.Show();
        }

        private void içeriklerimizHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://memleketyazilim.com/iceriklerimiz-hakkinda/");
        }

        private void nelerYapıyoruzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://memleketyazilim.com/memleket-yazilim-olarak-neler-yapiyoruz/");
        }

        private void vizyonumuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://memleketyazilim.com/vizyonumuz/");
        }

        private void misyonumuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://memleketyazilim.com/misyonumuz/");
        }

        private void Tikla(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = null;
            }
            textBox1.Text += btn.Text;
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($@"{textBox1.Text}");
            listBox1.Items.Add($@"/");
            S1 = double.Parse(textBox1.Text);
            islem = '/';
            textBox1.Text = "0";
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($@"{textBox1.Text}");
            listBox1.Items.Add($@"X");
            S1 = double.Parse(textBox1.Text);
            islem = '*';
            textBox1.Text = "0";
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($@"{textBox1.Text}");
            listBox1.Items.Add($@"-");
            S1 = double.Parse(textBox1.Text);
            islem = '-';
            textBox1.Text = "0";
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($@"{textBox1.Text}");
            listBox1.Items.Add($@"+");
            S1 = double.Parse(textBox1.Text);
            islem = '+';
            textBox1.Text = "0";
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($@"{textBox1.Text}");
            listBox1.Items.Add($@"=");
            S2 = double.Parse(textBox1.Text);
            if (islem == '/')
            {
                textBox1.Text = hesap.Bol(S1, S2).ToString();
                listBox1.Items.Add($@"{hesap.Bol(S1, S2).ToString()}");
            }
            if (islem == '*')
            {
                textBox1.Text = hesap.Carp(S1, S2).ToString();
                listBox1.Items.Add($@"{hesap.Carp(S1, S2).ToString()}");
            }
            if (islem == '-')
            {
                textBox1.Text = hesap.Cikar(S1, S2).ToString();
                listBox1.Items.Add($@"{hesap.Cikar(S1, S2).ToString()}");
            }
            if (islem == '+')
            {
                textBox1.Text = hesap.Topla(S1, S2).ToString();
                listBox1.Items.Add($@"{hesap.Topla(S1, S2).ToString()}");
            }

        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            listBox1.Items.Clear();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text += ",";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
    }
}

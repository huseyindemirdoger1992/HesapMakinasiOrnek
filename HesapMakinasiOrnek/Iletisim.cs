using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasiOrnek
{
    public partial class Iletisim : Form
    {
        public Iletisim()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://memleketyazilim.com/iletisim/");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stevec_klikov
{
    public partial class Okno : Form
    {
        public int Stevec { get; set; }
        public Okno()
        {
            InitializeComponent ();
            this.Stevec = 0;
        }

        private void Napis_Click(object sender, EventArgs e)
        {
            this.Stevec++;
            this.Koliko.Text = this.Stevec + "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semafor
{
    public partial class Okno : Form
    {
        public Okno()
        {
            InitializeComponent();
        }

        private void PrviGumb_Click(object sender, EventArgs e)
        {
            this.Napis.BackColor = Color.Red;
        }

        private void DrugiGumb_Click(object sender, EventArgs e)
        {
            this.Napis.BackColor = Color.Yellow;
        }

        private void TretjiGumb_Click(object sender, EventArgs e)
        {
            this.Napis.BackColor = Color.Green;
        }
    }
}

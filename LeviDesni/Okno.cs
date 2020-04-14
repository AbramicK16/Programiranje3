using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeviDesni
{
    public partial class Okno : Form
    {
        private string Besedilo = "pritisnjen";
        public Okno()
        {
            InitializeComponent();
        }

        private void LeviGumb_MouseDown(object sender, MouseEventArgs e)
        {
            this.Napis.Text = "<- " + this.Besedilo;
        }

        private void LeviGumb_MouseUp(object sender, MouseEventArgs e)
        {
            this.Napis.Text = "";
        }

        private void DesniGumb_MouseDown(object sender, MouseEventArgs e)
        {
            this.Napis.Text = this.Besedilo + " ->";
        }

        private void DesniGumb_MouseUp(object sender, MouseEventArgs e)
        {
            this.Napis.Text = "";
        }
    }
}

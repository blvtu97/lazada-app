using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lazada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tab2_Click(object sender, EventArgs e)
        {
            ctrl21.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            lblmain.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
        }

        private void Tab1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

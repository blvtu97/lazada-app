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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        bool DrawerOpen = true;

        private void BtnToggleDrawer_Click(object sender, EventArgs e)
        {
            DrawerOpen = !DrawerOpen;
            pnlDrawer.Visible = false;

            if (DrawerOpen)
            {
                //animated Drawer Open
                pnlDrawer.Width = 233;
                btnToggleDrawer.Image = imageList1.Images[0];
                bunifuTransition1.ShowSync(pnlDrawer);
            }
            else
            {
                //Aminated Drawer close
                pnlDrawer.Width = 56;
                btnToggleDrawer.Image = imageList1.Images[1];
                bunifuTransition1.ShowSync(pnlDrawer);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            tabMessages1.BringToFront();
        }


        private void BunifuFlatButton1_MouseUp(object sender, EventArgs e)
        {
            tabProfile1.BringToFront();
        }
    }
}

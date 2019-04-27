using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lazada
{
    public partial class tabMessages : UserControl
    {
        public tabMessages()
        {
            if (Program.IsInDesignMode())
            {
                return;
            }
            InitializeComponent();
        }

        private void TabMessages_Load(object sender, EventArgs e)
        {

        }

        private void BtnMailItem1_Click(object sender, EventArgs e)
        {
            resetIndicator();

            ////Thiết lập animation cho panel
            bunifuTransition1.HideSync(pnlMsgContainer);

            btnMailItem item = ((btnMailItem)sender);
            item.Active = true;
            lblFirstName.Text = item.FirstName;
            lblEmail.Text = item.Email;

            lblSubject.Text = item.Subject;
            lblBody.Text = item.Body + "\n\n" + item.FirstName + "\n" + item.Email;

            //Thiết lập animation cho panel
            bunifuTransition1.ShowSync(pnlMsgContainer);

        }

        void resetIndicator()
        {

            foreach (Control item in panel1.Controls)
            {
                btnMailItem curitem = ((btnMailItem)item);
                curitem.Active = false;
            }

        }
    }
}

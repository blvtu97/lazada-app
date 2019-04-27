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
    public partial class btnMailItem : UserControl
    {
        public btnMailItem()
        {
            InitializeComponent();
        }
        //Thêm thuộc tính FirstName cho controls
        public string FirstName
        {
            get
            {
                return lblFirstName.Text;
            }

            set
            {
                lblFirstName.Text = value;
            }
        }

        //Thêm thuộc tính Email cho controls
        public string Email
        {
            get
            {
                return lblEmail.Text;
            }

            set
            {
                lblEmail.Text = value;

            }
        }



        //Thêm thuộc tính Active cho controls
        public bool Active
        {
            get
            {
                return bunifuSeparator1.Visible;
            }
            set
            {
                bunifuSeparator1.Visible = value;
            }
        }

        //Thêm thuộc tính Subject cho controls
        public string Subject { get; set; }


        //Thêm thuộc tính Body cho controls
        public string Body { get; set; }

        private void LblFirstName_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void LblEmail_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}

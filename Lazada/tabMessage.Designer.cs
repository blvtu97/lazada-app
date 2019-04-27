namespace Lazada
{
    partial class tabMessages
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabMessages));
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMailItem1 = new Lazada.btnMailItem();
            this.btnMailItem2 = new Lazada.btnMailItem();
            this.btnMailItem3 = new Lazada.btnMailItem();
            this.btnMailItem4 = new Lazada.btnMailItem();
            this.btnMailItem5 = new Lazada.btnMailItem();
            this.btnMailItem6 = new Lazada.btnMailItem();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMsgContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMsgContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.bunifuDropdown1.BorderRadius = 5;
            this.bunifuTransition1.SetDecoration(this.bunifuDropdown1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(11, 12);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown1.TabIndex = 0;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.bunifuTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnMailItem6);
            this.panel1.Controls.Add(this.btnMailItem2);
            this.panel1.Controls.Add(this.btnMailItem5);
            this.panel1.Controls.Add(this.btnMailItem3);
            this.panel1.Controls.Add(this.btnMailItem4);
            this.panel1.Controls.Add(this.btnMailItem1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(21, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 433);
            this.panel1.TabIndex = 12;
            // 
            // btnMailItem1
            // 
            this.btnMailItem1.Active = true;
            this.btnMailItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMailItem1.Body = resources.GetString("btnMailItem1.Body");
            this.btnMailItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem1, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem1.Email = "blv.tu97@gmail.com";
            this.btnMailItem1.FirstName = "Nguyen Hoang Thinh";
            this.btnMailItem1.Location = new System.Drawing.Point(0, 0);
            this.btnMailItem1.Name = "btnMailItem1";
            this.btnMailItem1.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem1.Subject = "Lap trinh Windows";
            this.btnMailItem1.TabIndex = 0;
            this.btnMailItem1.Click += new System.EventHandler(this.BtnMailItem1_Click);
            // 
            // btnMailItem2
            // 
            this.btnMailItem2.Active = false;
            this.btnMailItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMailItem2.Body = resources.GetString("btnMailItem2.Body");
            this.btnMailItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem2, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem2.Email = "email@email.com";
            this.btnMailItem2.FirstName = "Jon Doe";
            this.btnMailItem2.Location = new System.Drawing.Point(0, 69);
            this.btnMailItem2.Name = "btnMailItem2";
            this.btnMailItem2.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem2.Subject = "Why do we use it?";
            this.btnMailItem2.TabIndex = 1;
            this.btnMailItem2.Click += new System.EventHandler(this.BtnMailItem1_Click);
            // 
            // btnMailItem3
            // 
            this.btnMailItem3.Active = false;
            this.btnMailItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMailItem3.Body = null;
            this.btnMailItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem3, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem3.Email = "email here";
            this.btnMailItem3.FirstName = "Name Here";
            this.btnMailItem3.Location = new System.Drawing.Point(0, 138);
            this.btnMailItem3.Name = "btnMailItem3";
            this.btnMailItem3.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem3.Subject = null;
            this.btnMailItem3.TabIndex = 2;
            this.btnMailItem3.Click += new System.EventHandler(this.BtnMailItem1_Click);
            // 
            // btnMailItem4
            // 
            this.btnMailItem4.Active = false;
            this.btnMailItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMailItem4.Body = null;
            this.btnMailItem4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem4, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem4.Email = "email here";
            this.btnMailItem4.FirstName = "Name Here";
            this.btnMailItem4.Location = new System.Drawing.Point(0, 207);
            this.btnMailItem4.Name = "btnMailItem4";
            this.btnMailItem4.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem4.Subject = null;
            this.btnMailItem4.TabIndex = 28;
            this.btnMailItem4.Click += new System.EventHandler(this.BtnMailItem1_Click);
            // 
            // btnMailItem5
            // 
            this.btnMailItem5.Active = false;
            this.btnMailItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMailItem5.Body = null;
            this.btnMailItem5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem5, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem5.Email = "email here";
            this.btnMailItem5.FirstName = "Name Here";
            this.btnMailItem5.Location = new System.Drawing.Point(0, 276);
            this.btnMailItem5.Name = "btnMailItem5";
            this.btnMailItem5.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem5.Subject = null;
            this.btnMailItem5.TabIndex = 29;
            this.btnMailItem5.Click += new System.EventHandler(this.BtnMailItem1_Click);
            // 
            // btnMailItem6
            // 
            this.btnMailItem6.Active = false;
            this.btnMailItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMailItem6.Body = null;
            this.btnMailItem6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem6, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem6.Email = "email here";
            this.btnMailItem6.FirstName = "Name Here";
            this.btnMailItem6.Location = new System.Drawing.Point(0, 345);
            this.btnMailItem6.Name = "btnMailItem6";
            this.btnMailItem6.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem6.Subject = null;
            this.btnMailItem6.TabIndex = 30;
            this.btnMailItem6.Click += new System.EventHandler(this.BtnMailItem1_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblFirstName, BunifuAnimatorNS.DecorationType.None);
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFirstName.Location = new System.Drawing.Point(77, 19);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(87, 20);
            this.lblFirstName.TabIndex = 23;
            this.lblFirstName.Text = "Name Here";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblEmail, BunifuAnimatorNS.DecorationType.None);
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEmail.Location = new System.Drawing.Point(79, 43);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(117, 20);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "email@eail.com";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblSubject, BunifuAnimatorNS.DecorationType.None);
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSubject.Location = new System.Drawing.Point(18, 92);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(176, 28);
            this.lblSubject.TabIndex = 25;
            this.lblSubject.Text = "Subject goes here";
            // 
            // lblBody
            // 
            this.bunifuTransition1.SetDecoration(this.lblBody, BunifuAnimatorNS.DecorationType.None);
            this.lblBody.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblBody.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBody.Location = new System.Drawing.Point(19, 133);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(396, 276);
            this.lblBody.TabIndex = 26;
            this.lblBody.Text = "email here";
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMsgContainer
            // 
            this.pnlMsgContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMsgContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pnlMsgContainer.Controls.Add(this.pictureBox1);
            this.pnlMsgContainer.Controls.Add(this.lblBody);
            this.pnlMsgContainer.Controls.Add(this.lblSubject);
            this.pnlMsgContainer.Controls.Add(this.lblEmail);
            this.pnlMsgContainer.Controls.Add(this.lblFirstName);
            this.bunifuTransition1.SetDecoration(this.pnlMsgContainer, BunifuAnimatorNS.DecorationType.None);
            this.pnlMsgContainer.Location = new System.Drawing.Point(237, 68);
            this.pnlMsgContainer.Name = "pnlMsgContainer";
            this.pnlMsgContainer.Size = new System.Drawing.Size(453, 433);
            this.pnlMsgContainer.TabIndex = 14;
            // 
            // tabMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMsgContainer);
            this.Controls.Add(this.bunifuDropdown1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.Name = "tabMessages";
            this.Size = new System.Drawing.Size(705, 526);
            this.Load += new System.EventHandler(this.TabMessages_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMsgContainer.ResumeLayout(false);
            this.pnlMsgContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel panel1;
        private btnMailItem btnMailItem1;
        private btnMailItem btnMailItem6;
        private btnMailItem btnMailItem2;
        private btnMailItem btnMailItem5;
        private btnMailItem btnMailItem3;
        private btnMailItem btnMailItem4;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMsgContainer;
    }
}


namespace Eletronic
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidebar = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txtlogout = new System.Windows.Forms.LinkLabel();
            this.productlist = new System.Windows.Forms.LinkLabel();
            this.customer = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardpage = new System.Windows.Forms.LinkLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.billgenerate = new System.Windows.Forms.LinkLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.sidebar.Controls.Add(this.logo);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(324, 616);
            this.sidebar.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = global::Eletronic.Properties.Resources.Tech_hevan;
            this.logo.Location = new System.Drawing.Point(74, 27);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(146, 133);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.txtlogout);
            this.panel1.Controls.Add(this.productlist);
            this.panel1.Controls.Add(this.customer);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dashboardpage);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.billgenerate);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Location = new System.Drawing.Point(3, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 438);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox9.Image = global::Eletronic.Properties.Resources.logout1;
            this.pictureBox9.Location = new System.Drawing.Point(12, 344);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(92, 54);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // txtlogout
            // 
            this.txtlogout.AutoSize = true;
            this.txtlogout.BackColor = System.Drawing.Color.Transparent;
            this.txtlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.txtlogout.LinkColor = System.Drawing.Color.White;
            this.txtlogout.Location = new System.Drawing.Point(96, 353);
            this.txtlogout.Name = "txtlogout";
            this.txtlogout.Size = new System.Drawing.Size(103, 32);
            this.txtlogout.TabIndex = 25;
            this.txtlogout.TabStop = true;
            this.txtlogout.Text = "Logout";
            this.txtlogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtlogout_LinkClicked);
            // 
            // productlist
            // 
            this.productlist.AutoSize = true;
            this.productlist.BackColor = System.Drawing.Color.Transparent;
            this.productlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productlist.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.productlist.LinkColor = System.Drawing.Color.White;
            this.productlist.Location = new System.Drawing.Point(105, 188);
            this.productlist.Name = "productlist";
            this.productlist.Size = new System.Drawing.Size(179, 32);
            this.productlist.TabIndex = 23;
            this.productlist.TabStop = true;
            this.productlist.Text = "Products List";
            this.productlist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.productlist_LinkClicked);
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.BackColor = System.Drawing.Color.Transparent;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.customer.LinkColor = System.Drawing.Color.White;
            this.customer.Location = new System.Drawing.Point(93, 105);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(198, 32);
            this.customer.TabIndex = 21;
            this.customer.TabStop = true;
            this.customer.Text = "Customers Bill";
            this.customer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Eletronic.Properties.Resources.list_view;
            this.pictureBox2.Location = new System.Drawing.Point(12, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Eletronic.Properties.Resources.customer_1;
            this.pictureBox1.Location = new System.Drawing.Point(9, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardpage
            // 
            this.dashboardpage.AutoSize = true;
            this.dashboardpage.BackColor = System.Drawing.Color.Transparent;
            this.dashboardpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardpage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.dashboardpage.LinkColor = System.Drawing.Color.White;
            this.dashboardpage.Location = new System.Drawing.Point(96, 38);
            this.dashboardpage.Name = "dashboardpage";
            this.dashboardpage.Size = new System.Drawing.Size(154, 32);
            this.dashboardpage.TabIndex = 20;
            this.dashboardpage.TabStop = true;
            this.dashboardpage.Text = "Dashboard";
            this.dashboardpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dashboardpage_LinkClicked);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Image = global::Eletronic.Properties.Resources.dashboard;
            this.pictureBox7.Location = new System.Drawing.Point(12, 25);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(92, 54);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // billgenerate
            // 
            this.billgenerate.AutoSize = true;
            this.billgenerate.BackColor = System.Drawing.Color.Transparent;
            this.billgenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billgenerate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.billgenerate.LinkColor = System.Drawing.Color.White;
            this.billgenerate.Location = new System.Drawing.Point(102, 276);
            this.billgenerate.Name = "billgenerate";
            this.billgenerate.Size = new System.Drawing.Size(181, 32);
            this.billgenerate.TabIndex = 16;
            this.billgenerate.TabStop = true;
            this.billgenerate.Text = "Generate Bill";
            this.billgenerate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerlist_LinkClicked);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Image = global::Eletronic.Properties.Resources.billing;
            this.pictureBox6.Location = new System.Drawing.Point(9, 264);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(92, 54);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(324, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1187, 616);
            this.mainpanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tech Haven";
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(324, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1187, 41);
            this.toppanel.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 616);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.sidebar);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel dashboardpage;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.LinkLabel customer;
        private System.Windows.Forms.LinkLabel billgenerate;
        private System.Windows.Forms.LinkLabel productlist;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.LinkLabel txtlogout;
    }
}
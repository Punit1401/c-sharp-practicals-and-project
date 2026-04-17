
namespace Eletronic.Admin
{
    partial class Updateemployee
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
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtuser = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbrole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtlname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtfname = new Guna.UI2.WinForms.Guna2TextBox();
            this.title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdfemale = new System.Windows.Forms.RadioButton();
            this.rdmale = new System.Windows.Forms.RadioButton();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtmobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfetch = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.title.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtaddress
            // 
            this.txtaddress.BorderColor = System.Drawing.Color.Black;
            this.txtaddress.BorderRadius = 10;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.DefaultText = "";
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtaddress.ForeColor = System.Drawing.Color.Black;
            this.txtaddress.Location = new System.Drawing.Point(35, 525);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtaddress.PlaceholderText = "";
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(763, 113);
            this.txtaddress.TabIndex = 36;
            // 
            // txtpass
            // 
            this.txtpass.BorderColor = System.Drawing.Color.Black;
            this.txtpass.BorderRadius = 10;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "";
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.Location = new System.Drawing.Point(442, 413);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtpass.PlaceholderText = "Enter Password";
            this.txtpass.ReadOnly = true;
            this.txtpass.SelectedText = "";
            this.txtpass.Size = new System.Drawing.Size(356, 44);
            this.txtpass.TabIndex = 35;
            // 
            // txtuser
            // 
            this.txtuser.BorderColor = System.Drawing.Color.Black;
            this.txtuser.BorderRadius = 10;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.DefaultText = "";
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.Location = new System.Drawing.Point(35, 413);
            this.txtuser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtuser.Name = "txtuser";
            this.txtuser.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtuser.PlaceholderText = "Enter Username";
            this.txtuser.SelectedText = "";
            this.txtuser.Size = new System.Drawing.Size(356, 44);
            this.txtuser.TabIndex = 34;
            // 
            // cbrole
            // 
            this.cbrole.BackColor = System.Drawing.Color.Transparent;
            this.cbrole.BorderColor = System.Drawing.Color.Black;
            this.cbrole.BorderRadius = 10;
            this.cbrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbrole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbrole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbrole.ItemHeight = 30;
            this.cbrole.Items.AddRange(new object[] {
            "Manager",
            "Sales"});
            this.cbrole.Location = new System.Drawing.Point(35, 307);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(356, 36);
            this.cbrole.TabIndex = 32;
            // 
            // txtlname
            // 
            this.txtlname.BorderColor = System.Drawing.Color.Black;
            this.txtlname.BorderRadius = 10;
            this.txtlname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlname.DefaultText = "";
            this.txtlname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtlname.ForeColor = System.Drawing.Color.Black;
            this.txtlname.Location = new System.Drawing.Point(442, 197);
            this.txtlname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtlname.Name = "txtlname";
            this.txtlname.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtlname.PlaceholderText = "Enter Last Name";
            this.txtlname.SelectedText = "";
            this.txtlname.Size = new System.Drawing.Size(356, 44);
            this.txtlname.TabIndex = 31;
            // 
            // txtfname
            // 
            this.txtfname.BorderColor = System.Drawing.Color.Black;
            this.txtfname.BorderRadius = 10;
            this.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfname.DefaultText = "";
            this.txtfname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtfname.ForeColor = System.Drawing.Color.Black;
            this.txtfname.Location = new System.Drawing.Point(35, 197);
            this.txtfname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfname.Name = "txtfname";
            this.txtfname.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtfname.PlaceholderText = "Enter First Name";
            this.txtfname.SelectedText = "";
            this.txtfname.Size = new System.Drawing.Size(356, 44);
            this.txtfname.TabIndex = 30;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.title.Controls.Add(this.label1);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(60, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(730, 71);
            this.title.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Employee Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 657);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 38);
            this.label9.TabIndex = 27;
            this.label9.Text = "Gender";
            // 
            // rdfemale
            // 
            this.rdfemale.AutoSize = true;
            this.rdfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdfemale.Location = new System.Drawing.Point(158, 712);
            this.rdfemale.Name = "rdfemale";
            this.rdfemale.Size = new System.Drawing.Size(131, 36);
            this.rdfemale.TabIndex = 26;
            this.rdfemale.TabStop = true;
            this.rdfemale.Text = "Female";
            this.rdfemale.UseVisualStyleBackColor = true;
            // 
            // rdmale
            // 
            this.rdmale.AutoSize = true;
            this.rdmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdmale.Location = new System.Drawing.Point(35, 712);
            this.rdmale.Name = "rdmale";
            this.rdmale.Size = new System.Drawing.Size(98, 36);
            this.rdmale.TabIndex = 25;
            this.rdmale.TabStop = true;
            this.rdmale.Text = "Male";
            this.rdmale.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(280, 796);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(261, 53);
            this.btnupdate.TabIndex = 23;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(435, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 38);
            this.label7.TabIndex = 21;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 38);
            this.label8.TabIndex = 19;
            this.label8.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 38);
            this.label6.TabIndex = 16;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 38);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mobile no";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.txtaddress);
            this.guna2Panel2.Controls.Add(this.title);
            this.guna2Panel2.Controls.Add(this.txtpass);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.txtuser);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.txtmobile);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.cbrole);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.txtlname);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.txtfname);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.btnupdate);
            this.guna2Panel2.Controls.Add(this.label9);
            this.guna2Panel2.Controls.Add(this.rdmale);
            this.guna2Panel2.Controls.Add(this.rdfemale);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel2.Location = new System.Drawing.Point(541, 68);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(848, 884);
            this.guna2Panel2.TabIndex = 14;
            // 
            // txtmobile
            // 
            this.txtmobile.BorderColor = System.Drawing.Color.Black;
            this.txtmobile.BorderRadius = 10;
            this.txtmobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmobile.DefaultText = "";
            this.txtmobile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmobile.ForeColor = System.Drawing.Color.Black;
            this.txtmobile.Location = new System.Drawing.Point(442, 307);
            this.txtmobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmobile.MaxLength = 10;
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtmobile.PlaceholderText = "Enter Mobile No.";
            this.txtmobile.SelectedText = "";
            this.txtmobile.Size = new System.Drawing.Size(356, 44);
            this.txtmobile.TabIndex = 33;
            this.txtmobile.TextChanged += new System.EventHandler(this.txtmobile_TextChanged);
            this.txtmobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobile_KeyPress);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnback);
            this.guna2Panel1.Controls.Add(this.btnfetch);
            this.guna2Panel1.Controls.Add(this.label15);
            this.guna2Panel1.Controls.Add(this.txtid);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.Location = new System.Drawing.Point(101, 68);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(379, 207);
            this.guna2Panel1.TabIndex = 15;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(209, 138);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(128, 45);
            this.btnback.TabIndex = 11;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnfetch
            // 
            this.btnfetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.btnfetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfetch.ForeColor = System.Drawing.Color.White;
            this.btnfetch.Location = new System.Drawing.Point(40, 138);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Size = new System.Drawing.Size(117, 45);
            this.btnfetch.TabIndex = 8;
            this.btnfetch.Text = "Fetch";
            this.btnfetch.UseVisualStyleBackColor = false;
            this.btnfetch.Click += new System.EventHandler(this.btnfetch_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 29);
            this.label15.TabIndex = 1;
            this.label15.Text = "Product Id";
            // 
            // txtid
            // 
            this.txtid.BorderColor = System.Drawing.Color.Black;
            this.txtid.BorderRadius = 10;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "";
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(29, 65);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtid.PlaceholderText = "Enter Product Id";
            this.txtid.SelectedText = "";
            this.txtid.Size = new System.Drawing.Size(317, 44);
            this.txtid.TabIndex = 10;
            // 
            // Updateemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1570, 978);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Updateemployee";
            this.Text = "Updateemployee";
            this.Load += new System.EventHandler(this.Updateemployee_Load);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtaddress;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2TextBox txtuser;
        private Guna.UI2.WinForms.Guna2ComboBox cbrole;
        private Guna.UI2.WinForms.Guna2TextBox txtlname;
        private Guna.UI2.WinForms.Guna2TextBox txtfname;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdfemale;
        private System.Windows.Forms.RadioButton rdmale;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnfetch;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private Guna.UI2.WinForms.Guna2TextBox txtmobile;
    }
}
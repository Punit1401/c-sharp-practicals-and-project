
namespace Eletronic.Admin
{
    partial class Products
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcolor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqty = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txts_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtp_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtbrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnclear);
            this.guna2Panel1.Controls.Add(this.title);
            this.guna2Panel1.Controls.Add(this.txtcolor);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtqty);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.txts_price);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.txtp_price);
            this.guna2Panel1.Controls.Add(this.btnadd);
            this.guna2Panel1.Controls.Add(this.txtbrand);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.txtcategory);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txtpname);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.Location = new System.Drawing.Point(448, 111);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(894, 793);
            this.guna2Panel1.TabIndex = 19;
            // 
            // btnclear
            // 
            this.btnclear.AutoSize = true;
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(189)))));
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(525, 672);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(255, 46);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.title.Controls.Add(this.label1);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(86, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(730, 71);
            this.title.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcolor
            // 
            this.txtcolor.BorderColor = System.Drawing.Color.Black;
            this.txtcolor.BorderRadius = 10;
            this.txtcolor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcolor.DefaultText = "";
            this.txtcolor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcolor.ForeColor = System.Drawing.Color.Black;
            this.txtcolor.Location = new System.Drawing.Point(513, 570);
            this.txtcolor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtcolor.PlaceholderText = "Enter colour Name";
            this.txtcolor.SelectedText = "";
            this.txtcolor.Size = new System.Drawing.Size(292, 44);
            this.txtcolor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtqty
            // 
            this.txtqty.BackColor = System.Drawing.Color.Transparent;
            this.txtqty.BorderColor = System.Drawing.Color.Black;
            this.txtqty.BorderRadius = 10;
            this.txtqty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtqty.Location = new System.Drawing.Point(115, 570);
            this.txtqty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(292, 48);
            this.txtqty.TabIndex = 6;
            this.txtqty.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(189)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Purshase Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txts_price
            // 
            this.txts_price.BorderColor = System.Drawing.Color.Black;
            this.txts_price.BorderRadius = 10;
            this.txts_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txts_price.DefaultText = "";
            this.txts_price.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txts_price.ForeColor = System.Drawing.Color.Black;
            this.txts_price.Location = new System.Drawing.Point(513, 458);
            this.txts_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txts_price.Name = "txts_price";
            this.txts_price.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txts_price.PlaceholderText = "Selling Price Name";
            this.txts_price.SelectedText = "";
            this.txts_price.Size = new System.Drawing.Size(292, 44);
            this.txts_price.TabIndex = 5;
            this.txts_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txts_price_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "qty";
            // 
            // txtp_price
            // 
            this.txtp_price.BorderColor = System.Drawing.Color.Black;
            this.txtp_price.BorderRadius = 10;
            this.txtp_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtp_price.DefaultText = "";
            this.txtp_price.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtp_price.ForeColor = System.Drawing.Color.Black;
            this.txtp_price.Location = new System.Drawing.Point(115, 458);
            this.txtp_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtp_price.Name = "txtp_price";
            this.txtp_price.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtp_price.PlaceholderText = "Purchase Price Name";
            this.txtp_price.SelectedText = "";
            this.txtp_price.Size = new System.Drawing.Size(292, 44);
            this.txtp_price.TabIndex = 4;
            this.txtp_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp_price_KeyPress);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(143, 672);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(255, 52);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtbrand
            // 
            this.txtbrand.BackColor = System.Drawing.Color.Transparent;
            this.txtbrand.BorderColor = System.Drawing.Color.Black;
            this.txtbrand.BorderRadius = 10;
            this.txtbrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbrand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtbrand.ItemHeight = 30;
            this.txtbrand.Location = new System.Drawing.Point(513, 332);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(292, 36);
            this.txtbrand.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(505, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 46);
            this.label7.TabIndex = 20;
            this.label7.Text = "Colour";
            // 
            // txtcategory
            // 
            this.txtcategory.BackColor = System.Drawing.Color.Transparent;
            this.txtcategory.BorderColor = System.Drawing.Color.Black;
            this.txtcategory.BorderRadius = 10;
            this.txtcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtcategory.ItemHeight = 30;
            this.txtcategory.Location = new System.Drawing.Point(115, 332);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(292, 36);
            this.txtcategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brand";
            // 
            // txtpname
            // 
            this.txtpname.BorderColor = System.Drawing.Color.Black;
            this.txtpname.BorderRadius = 10;
            this.txtpname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpname.DefaultText = "";
            this.txtpname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpname.ForeColor = System.Drawing.Color.Black;
            this.txtpname.Location = new System.Drawing.Point(115, 199);
            this.txtpname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpname.Name = "txtpname";
            this.txtpname.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtpname.PlaceholderText = "Product Name";
            this.txtpname.SelectedText = "";
            this.txtpname.Size = new System.Drawing.Size(675, 44);
            this.txtpname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(505, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 46);
            this.label8.TabIndex = 22;
            this.label8.Text = "Selling Price";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1373, 1102);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Products_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtcolor;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtqty;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txts_price;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtp_price;
        private System.Windows.Forms.Button btnadd;
        private Guna.UI2.WinForms.Guna2ComboBox txtbrand;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox txtcategory;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtpname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}
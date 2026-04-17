
namespace Eletronic.Admin
{
    partial class delcategory
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
            this.txtcategoryid = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.title.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcategoryid
            // 
            this.txtcategoryid.BorderColor = System.Drawing.Color.Black;
            this.txtcategoryid.BorderRadius = 10;
            this.txtcategoryid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcategoryid.DefaultText = "";
            this.txtcategoryid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcategoryid.ForeColor = System.Drawing.Color.Black;
            this.txtcategoryid.Location = new System.Drawing.Point(99, 226);
            this.txtcategoryid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcategoryid.Name = "txtcategoryid";
            this.txtcategoryid.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtcategoryid.PlaceholderText = "Enter Category Id";
            this.txtcategoryid.SelectedText = "";
            this.txtcategoryid.Size = new System.Drawing.Size(574, 44);
            this.txtcategoryid.TabIndex = 10;
            this.txtcategoryid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcategoryid_KeyPress);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(189)))));
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(406, 323);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(195, 52);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "cancel";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(165, 323);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(195, 52);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.title.Controls.Add(this.label1);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(48, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(659, 71);
            this.title.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id of Category";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.txtcategoryid);
            this.guna2Panel1.Controls.Add(this.title);
            this.guna2Panel1.Controls.Add(this.btnback);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.btndelete);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.Location = new System.Drawing.Point(551, 167);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(726, 461);
            this.guna2Panel1.TabIndex = 17;
            // 
            // delcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 680);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delcategory";
            this.Text = "delcategory";
            this.Load += new System.EventHandler(this.delcategory_Load);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtcategoryid;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

namespace Eletronic.Admin
{
    partial class Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtcategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dispcategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dispcategory)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcategory
            // 
            this.txtcategory.BorderColor = System.Drawing.Color.Black;
            this.txtcategory.BorderRadius = 10;
            this.txtcategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcategory.DefaultText = "";
            this.txtcategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcategory.ForeColor = System.Drawing.Color.Black;
            this.txtcategory.Location = new System.Drawing.Point(90, 218);
            this.txtcategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtcategory.PlaceholderText = "Enter Brand";
            this.txtcategory.SelectedText = "";
            this.txtcategory.Size = new System.Drawing.Size(574, 44);
            this.txtcategory.TabIndex = 16;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(189)))));
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(391, 309);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(195, 52);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(148, 309);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(195, 52);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.title.Controls.Add(this.label1);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(31, 34);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(659, 71);
            this.title.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // dispcategory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dispcategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dispcategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispcategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dispcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dispcategory.ColumnHeadersHeight = 30;
            this.dispcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dispcategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dispcategory.GridColor = System.Drawing.Color.Black;
            this.dispcategory.Location = new System.Drawing.Point(545, 593);
            this.dispcategory.Name = "dispcategory";
            this.dispcategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dispcategory.RowHeadersVisible = false;
            this.dispcategory.RowHeadersWidth = 51;
            this.dispcategory.RowTemplate.Height = 24;
            this.dispcategory.Size = new System.Drawing.Size(623, 192);
            this.dispcategory.TabIndex = 15;
            this.dispcategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dispcategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dispcategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dispcategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dispcategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dispcategory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dispcategory.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dispcategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dispcategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dispcategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispcategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dispcategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dispcategory.ThemeStyle.HeaderStyle.Height = 30;
            this.dispcategory.ThemeStyle.ReadOnly = false;
            this.dispcategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dispcategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dispcategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispcategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dispcategory.ThemeStyle.RowsStyle.Height = 24;
            this.dispcategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dispcategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dispcategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dispcategory_CellContentClick_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.txtcategory);
            this.guna2Panel1.Controls.Add(this.title);
            this.guna2Panel1.Controls.Add(this.btndelete);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.btnadd);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.Location = new System.Drawing.Point(478, 98);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(726, 461);
            this.guna2Panel1.TabIndex = 19;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1666, 800);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dispcategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Category_Load);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dispcategory)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dispcategory;
        private System.Windows.Forms.Button btndelete;
        private Guna.UI2.WinForms.Guna2TextBox txtcategory;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
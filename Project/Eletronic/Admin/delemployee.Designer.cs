
namespace Eletronic.Admin
{
    partial class delemployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtemployeeid = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtemployeeid);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(325, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 477);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.BorderColor = System.Drawing.Color.Black;
            this.txtemployeeid.BorderRadius = 10;
            this.txtemployeeid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemployeeid.DefaultText = "";
            this.txtemployeeid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtemployeeid.ForeColor = System.Drawing.Color.Black;
            this.txtemployeeid.Location = new System.Drawing.Point(85, 207);
            this.txtemployeeid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtemployeeid.PlaceholderText = "Enter Employee Id";
            this.txtemployeeid.SelectedText = "";
            this.txtemployeeid.Size = new System.Drawing.Size(574, 44);
            this.txtemployeeid.TabIndex = 17;
            this.txtemployeeid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemployeeid_KeyPress);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(189)))));
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(384, 312);
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
            this.btndelete.Location = new System.Drawing.Point(143, 312);
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
            this.title.Location = new System.Drawing.Point(26, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(659, 71);
            this.title.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id of Employee";
            // 
            // delemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1381, 725);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delemployee";
            this.Text = "delemployee";
            this.Load += new System.EventHandler(this.delemployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtemployeeid;
    }
}
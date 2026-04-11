
namespace Unit_3
{
    partial class products
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
            this.btnproduct1 = new System.Windows.Forms.Button();
            this.btnproduct2 = new System.Windows.Forms.Button();
            this.btnproduct3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnproduct1
            // 
            this.btnproduct1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnproduct1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnproduct1.ForeColor = System.Drawing.Color.White;
            this.btnproduct1.Location = new System.Drawing.Point(86, 120);
            this.btnproduct1.Name = "btnproduct1";
            this.btnproduct1.Size = new System.Drawing.Size(224, 56);
            this.btnproduct1.TabIndex = 0;
            this.btnproduct1.Text = "Laptop";
            this.btnproduct1.UseVisualStyleBackColor = false;
            this.btnproduct1.Click += new System.EventHandler(this.btnproduct1_Click);
            // 
            // btnproduct2
            // 
            this.btnproduct2.BackColor = System.Drawing.SystemColors.Info;
            this.btnproduct2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct2.Location = new System.Drawing.Point(342, 120);
            this.btnproduct2.Name = "btnproduct2";
            this.btnproduct2.Size = new System.Drawing.Size(224, 56);
            this.btnproduct2.TabIndex = 1;
            this.btnproduct2.Text = "Mobile";
            this.btnproduct2.UseVisualStyleBackColor = false;
            this.btnproduct2.Click += new System.EventHandler(this.btnproduct2_Click);
            // 
            // btnproduct3
            // 
            this.btnproduct3.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnproduct3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct3.ForeColor = System.Drawing.Color.White;
            this.btnproduct3.Location = new System.Drawing.Point(587, 120);
            this.btnproduct3.Name = "btnproduct3";
            this.btnproduct3.Size = new System.Drawing.Size(224, 56);
            this.btnproduct3.TabIndex = 2;
            this.btnproduct3.Text = "Headphone";
            this.btnproduct3.UseVisualStyleBackColor = false;
            this.btnproduct3.Click += new System.EventHandler(this.btnproduct3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Location = new System.Drawing.Point(60, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 482);
            this.panel1.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(331, 160);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(122, 44);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "label1";
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 572);
            this.Controls.Add(this.btnproduct3);
            this.Controls.Add(this.btnproduct2);
            this.Controls.Add(this.btnproduct1);
            this.Controls.Add(this.panel1);
            this.Name = "products";
            this.Text = "products";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnproduct1;
        private System.Windows.Forms.Button btnproduct2;
        private System.Windows.Forms.Button btnproduct3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfo;
    }
}
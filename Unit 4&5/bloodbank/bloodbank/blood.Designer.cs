namespace bloodbank
{
    partial class blood
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBloodID;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.TextBox txtBloodID;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBloodID = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.txtBloodID = new System.Windows.Forms.TextBox();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(220, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Blood Group Management";
            // 
            // lblBloodID
            // 
            this.lblBloodID.Location = new System.Drawing.Point(100, 100);
            this.lblBloodID.Name = "lblBloodID";
            this.lblBloodID.Size = new System.Drawing.Size(100, 23);
            this.lblBloodID.TabIndex = 1;
            this.lblBloodID.Text = "Blood ID";
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.Location = new System.Drawing.Point(100, 150);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(100, 23);
            this.lblBloodGroup.TabIndex = 3;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // txtBloodID
            // 
            this.txtBloodID.Location = new System.Drawing.Point(220, 100);
            this.txtBloodID.Name = "txtBloodID";
            this.txtBloodID.Size = new System.Drawing.Size(150, 22);
            this.txtBloodID.TabIndex = 2;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(220, 150);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(150, 22);
            this.txtBloodGroup.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(220, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Blood Group";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(100, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(600, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // blood
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBloodID);
            this.Controls.Add(this.txtBloodID);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "blood";
            this.Text = "Blood Group";
            this.Load += new System.EventHandler(this.blood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
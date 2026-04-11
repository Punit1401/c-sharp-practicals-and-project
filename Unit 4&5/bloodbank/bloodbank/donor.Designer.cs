namespace bloodbank
{
    partial class donor
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblBlood;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtWeight;

        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbBlood;

        private System.Windows.Forms.DateTimePicker dtpDOB;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearchBlood;
        private System.Windows.Forms.Button btnSearchGender;

        private System.Windows.Forms.ComboBox cmbSearchBlood;
        private System.Windows.Forms.ComboBox cmbSearchGender;

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

            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBlood = new System.Windows.Forms.Label();

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();

            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbBlood = new System.Windows.Forms.ComboBox();

            this.dtpDOB = new System.Windows.Forms.DateTimePicker();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearchBlood = new System.Windows.Forms.Button();
            this.btnSearchGender = new System.Windows.Forms.Button();

            this.cmbSearchBlood = new System.Windows.Forms.ComboBox();
            this.cmbSearchGender = new System.Windows.Forms.ComboBox();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // ===== TITLE =====
            this.lblTitle.Text = "Donor Registration";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(250, 10);
            this.lblTitle.AutoSize = true;

            // ===== LABELS =====
            this.lblName.Text = "Name";
            this.lblName.Location = new System.Drawing.Point(30, 60);

            this.lblAddress.Text = "Address";
            this.lblAddress.Location = new System.Drawing.Point(30, 100);

            this.lblContact.Text = "Contact";
            this.lblContact.Location = new System.Drawing.Point(30, 140);

            this.lblDOB.Text = "DOB";
            this.lblDOB.Location = new System.Drawing.Point(30, 180);

            this.lblGender.Text = "Gender";
            this.lblGender.Location = new System.Drawing.Point(300, 60);

            this.lblWeight.Text = "Weight";
            this.lblWeight.Location = new System.Drawing.Point(300, 100);

            this.lblBlood.Text = "Blood Group";
            this.lblBlood.Location = new System.Drawing.Point(300, 140);

            // ===== TEXTBOXES =====
            this.txtName.Location = new System.Drawing.Point(120, 60);
            this.txtAddress.Location = new System.Drawing.Point(120, 100);
            this.txtContact.Location = new System.Drawing.Point(120, 140);
            this.txtWeight.Location = new System.Drawing.Point(420, 100);

            // ===== COMBOBOX =====
            this.cmbGender.Location = new System.Drawing.Point(420, 60);
            this.cmbBlood.Location = new System.Drawing.Point(420, 140);

            // ===== DATE =====
            this.dtpDOB.Location = new System.Drawing.Point(120, 180);

            // ===== BUTTON ADD =====
            this.btnAdd.Text = "Add Donor";
            this.btnAdd.Location = new System.Drawing.Point(250, 220);
            this.btnAdd.Size = new System.Drawing.Size(120, 35);

            // ===== SEARCH =====
            this.cmbSearchBlood.Location = new System.Drawing.Point(30, 270);
            this.btnSearchBlood.Text = "Search by Blood";
            this.btnSearchBlood.Location = new System.Drawing.Point(180, 270);

            this.cmbSearchGender.Location = new System.Drawing.Point(30, 310);
            this.btnSearchGender.Text = "Search by Gender";
            this.btnSearchGender.Location = new System.Drawing.Point(180, 310);

            // ===== GRID =====
            this.dataGridView1.Location = new System.Drawing.Point(30, 350);
            this.dataGridView1.Size = new System.Drawing.Size(700, 150);

            // ===== FORM =====
            this.ClientSize = new System.Drawing.Size(800, 520);

            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblBlood);

            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtWeight);

            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbBlood);
            this.Controls.Add(this.dtpDOB);

            this.Controls.Add(this.btnAdd);

            this.Controls.Add(this.cmbSearchBlood);
            this.Controls.Add(this.btnSearchBlood);
            this.Controls.Add(this.cmbSearchGender);
            this.Controls.Add(this.btnSearchGender);

            this.Controls.Add(this.dataGridView1);

            this.Name = "donor";
            this.Text = "Donor";

            this.Load += new System.EventHandler(this.donor_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
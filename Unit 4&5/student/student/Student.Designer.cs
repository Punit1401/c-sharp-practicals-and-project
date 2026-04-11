namespace student
{
    partial class Student
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAddStudent;

        private System.Windows.Forms.ComboBox cmbSearchCourse;
        private System.Windows.Forms.Button btnSearchByCourse;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Button btnSearchByYear;

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
            this.lblStudent = new System.Windows.Forms.Label();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.cmbSearchCourse = new System.Windows.Forms.ComboBox();
            this.btnSearchByCourse = new System.Windows.Forms.Button();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.btnSearchByYear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.Location = new System.Drawing.Point(30, 100);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(100, 23);
            this.lblStudent.TabIndex = 4;
            this.lblStudent.Text = "Student Details";
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(150, 130);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(150, 22);
            this.txtStudName.TabIndex = 6;
            this.txtStudName.TextChanged += new System.EventHandler(this.txtStudName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(320, 130);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // cmbCourse
            // 
            this.cmbCourse.Location = new System.Drawing.Point(490, 130);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(150, 24);
            this.cmbCourse.TabIndex = 8;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(660, 130);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 9;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(780, 130);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(120, 30);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click_1);
            // 
            // cmbSearchCourse
            // 
            this.cmbSearchCourse.Location = new System.Drawing.Point(30, 200);
            this.cmbSearchCourse.Name = "cmbSearchCourse";
            this.cmbSearchCourse.Size = new System.Drawing.Size(150, 24);
            this.cmbSearchCourse.TabIndex = 11;
            // 
            // btnSearchByCourse
            // 
            this.btnSearchByCourse.Location = new System.Drawing.Point(200, 200);
            this.btnSearchByCourse.Name = "btnSearchByCourse";
            this.btnSearchByCourse.Size = new System.Drawing.Size(150, 30);
            this.btnSearchByCourse.TabIndex = 12;
            this.btnSearchByCourse.Text = "Search by Course";
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Location = new System.Drawing.Point(380, 200);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(100, 22);
            this.txtSearchYear.TabIndex = 13;
            // 
            // btnSearchByYear
            // 
            this.btnSearchByYear.Location = new System.Drawing.Point(500, 200);
            this.btnSearchByYear.Name = "btnSearchByYear";
            this.btnSearchByYear.Size = new System.Drawing.Size(150, 30);
            this.btnSearchByYear.TabIndex = 14;
            this.btnSearchByYear.Text = "Search by Year";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(30, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(900, 250);
            this.dataGridView1.TabIndex = 15;
            // 
            // Student
            // 
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.cmbSearchCourse);
            this.Controls.Add(this.btnSearchByCourse);
            this.Controls.Add(this.txtSearchYear);
            this.Controls.Add(this.btnSearchByYear);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Student";
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
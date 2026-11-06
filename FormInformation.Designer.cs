namespace dsa.QUEUE.Hospital
{
    partial class FormInformation
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblPatientNo = new Label();
            lblName = new Label();
            lblAge = new Label();
            lblDiagnosis = new Label();
            txtPatientNo = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtDiagnosis = new TextBox();
            btnRegister = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 25);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Information - Register Patient";
            // 
            // lblPatientNo
            // 
            lblPatientNo.Location = new Point(20, 60);
            lblPatientNo.Name = "lblPatientNo";
            lblPatientNo.Size = new Size(100, 23);
            lblPatientNo.TabIndex = 9;
            lblPatientNo.Text = "Patient No:";
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 90);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 8;
            lblName.Text = "Name:";
            // 
            // lblAge
            // 
            lblAge.Location = new Point(20, 120);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 7;
            lblAge.Text = "Age:";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.Location = new Point(20, 150);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(100, 23);
            lblDiagnosis.TabIndex = 6;
            lblDiagnosis.Text = "Diagnosis:";
            // 
            // txtPatientNo
            // 
            txtPatientNo.Location = new Point(130, 60);
            txtPatientNo.Name = "txtPatientNo";
            txtPatientNo.Size = new Size(200, 27);
            txtPatientNo.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(130, 120);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(80, 27);
            txtAge.TabIndex = 3;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(130, 150);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(260, 60);
            txtDiagnosis.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(130, 230);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 30);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(240, 230);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FormInformation
            // 
            ClientSize = new Size(420, 290);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(txtDiagnosis);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtPatientNo);
            Controls.Add(lblDiagnosis);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(lblPatientNo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information - Register";
            Load += FormInformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatientNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtPatientNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClose;
    }
}

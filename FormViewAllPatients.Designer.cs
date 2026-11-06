namespace dsa.QUEUE.Hospital
{
    partial class FormViewAllPatients
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
            lstPatients = new ListBox();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // lstPatients
            // 
            lstPatients.Font = new Font("Segoe UI", 9F);
            lstPatients.FormattingEnabled = true;
            lstPatients.Location = new Point(20, 20);
            lstPatients.Name = "lstPatients";
            lstPatients.Size = new Size(695, 304);
            lstPatients.TabIndex = 0;
            lstPatients.SelectedIndexChanged += lstPatients_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(20, 335);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormViewAllPatients
            // 
            ClientSize = new Size(742, 430);
            Controls.Add(btnRefresh);
            Controls.Add(lstPatients);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormViewAllPatients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Patients";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.Button btnRefresh;
    }
}

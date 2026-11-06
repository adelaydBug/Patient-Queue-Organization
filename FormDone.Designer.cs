namespace dsa.QUEUE.Hospital
{
    partial class FormDone
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
            panelHeader = new Panel();
            lblTitle = new Label();
            lstDone = new ListBox();
            btnRefresh = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(12, 55, 105);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(832, 50);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Done / Discharged Patients";
            // 
            // lstDone
            // 
            lstDone.Font = new Font("Segoe UI", 10F);
            lstDone.FormattingEnabled = true;
            lstDone.Location = new Point(20, 70);
            lstDone.Name = "lstDone";
            lstDone.Size = new Size(780, 349);
            lstDone.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(650, 439);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(170, 35);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh List";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormDone
            // 
            ClientSize = new Size(832, 486);
            Controls.Add(btnRefresh);
            Controls.Add(lstDone);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormDone";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Done / Discharged Patients";
            Load += FormDone_Load;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.Button btnRefresh;
    }
}

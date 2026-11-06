namespace dsa.QUEUE.Hospital
{
    partial class FormXRay
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
            lstXRay = new ListBox();
            btnProcess = new Button();
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
            panelHeader.Size = new Size(600, 50);
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
            lblTitle.Text = "X-Ray Department Queue";
            // 
            // lstXRay
            // 
            lstXRay.Font = new Font("Segoe UI", 10F);
            lstXRay.FormattingEnabled = true;
            lstXRay.Location = new Point(20, 70);
            lstXRay.Name = "lstXRay";
            lstXRay.Size = new Size(360, 303);
            lstXRay.TabIndex = 1;
            // 
            // btnProcess
            // 
            btnProcess.Font = new Font("Segoe UI", 9F);
            btnProcess.Location = new Point(400, 90);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(170, 35);
            btnProcess.TabIndex = 2;
            btnProcess.Text = "Process (Send to Done)";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(400, 345);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(170, 35);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh Queue";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormXRay
            // 
            ClientSize = new Size(600, 400);
            Controls.Add(btnRefresh);
            Controls.Add(btnProcess);
            Controls.Add(lstXRay);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormXRay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "X-Ray Department";
            Load += FormXRay_Load;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstXRay;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnRefresh;
    }
}

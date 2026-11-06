namespace dsa.QUEUE.Hospital
{
    partial class FormER
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
            lstER = new ListBox();
            btnToICU = new Button();
            btnToDone = new Button();
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
            lblTitle.Text = "Emergency Room Queue";
            // 
            // lstER
            // 
            lstER.Font = new Font("Segoe UI", 10F);
            lstER.FormattingEnabled = true;
            lstER.Location = new Point(20, 70);
            lstER.Name = "lstER";
            lstER.Size = new Size(360, 303);
            lstER.TabIndex = 1;
            // 
            // btnToICU
            // 
            btnToICU.Location = new Point(400, 90);
            btnToICU.Name = "btnToICU";
            btnToICU.Size = new Size(170, 35);
            btnToICU.TabIndex = 2;
            btnToICU.Text = "Send to ICU";
            btnToICU.UseVisualStyleBackColor = true;
            btnToICU.Click += btnToICU_Click;
            // 
            // btnToDone
            // 
            btnToDone.Location = new Point(400, 140);
            btnToDone.Name = "btnToDone";
            btnToDone.Size = new Size(170, 35);
            btnToDone.TabIndex = 1;
            btnToDone.Text = "Discharge (Done)";
            btnToDone.UseVisualStyleBackColor = true;
            btnToDone.Click += btnToDone_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(400, 345);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(170, 35);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh Queue";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormER
            // 
            ClientSize = new Size(600, 400);
            Controls.Add(btnRefresh);
            Controls.Add(btnToDone);
            Controls.Add(btnToICU);
            Controls.Add(lstER);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormER";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emergency Room";
            Load += FormER_Load;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstER;
        private System.Windows.Forms.Button btnToICU;
        private System.Windows.Forms.Button btnToDone;
        private System.Windows.Forms.Button btnRefresh;
    }
}

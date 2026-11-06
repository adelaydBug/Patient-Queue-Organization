namespace dsa.QUEUE.Hospital
{
    partial class FormICU
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
            lstICU = new ListBox();
            btnToSurgery = new Button();
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
            lblTitle.Text = "ICU Queue";
            // 
            // lstICU
            // 
            lstICU.Font = new Font("Segoe UI", 10F);
            lstICU.FormattingEnabled = true;
            lstICU.Location = new Point(20, 70);
            lstICU.Name = "lstICU";
            lstICU.Size = new Size(360, 303);
            lstICU.TabIndex = 1;
            // 
            // btnToSurgery
            // 
            btnToSurgery.Font = new Font("Segoe UI", 9F);
            btnToSurgery.Location = new Point(400, 90);
            btnToSurgery.Name = "btnToSurgery";
            btnToSurgery.Size = new Size(170, 35);
            btnToSurgery.TabIndex = 2;
            btnToSurgery.Text = "Send to Surgery";
            btnToSurgery.UseVisualStyleBackColor = true;
            btnToSurgery.Click += btnToSurgery_Click;   // 🔹 FIXED
            // 
            // btnToDone
            // 
            btnToDone.Font = new Font("Segoe UI", 9F);
            btnToDone.Location = new Point(400, 140);
            btnToDone.Name = "btnToDone";
            btnToDone.Size = new Size(170, 35);
            btnToDone.TabIndex = 3;
            btnToDone.Text = "Discharge (Done)";
            btnToDone.UseVisualStyleBackColor = true;
            btnToDone.Click += btnToDone_Click;         // 🔹 FIXED
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(400, 345);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(170, 35);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh Queue";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormICU
            // 
            ClientSize = new Size(600, 400);
            Controls.Add(btnRefresh);
            Controls.Add(btnToDone);
            Controls.Add(btnToSurgery);
            Controls.Add(lstICU);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormICU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ICU";
            Load += FormICU_Load;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private ListBox lstICU;
        private Button btnToSurgery;
        private Button btnToDone;
        private Button btnRefresh;
    }
}

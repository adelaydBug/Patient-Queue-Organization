using System.Drawing;
using System.Windows.Forms;

namespace dsa.QUEUE.Hospital
{
    partial class FormSurgery
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblTitle;
        private ListBox lstSurgery;
        private Button btnToICU;
        private Button btnToDone;
        private Button btnSendToER;
        private Button btnToPediatrics;
        private Button btnToDerma;
        private Button btnRefresh;

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
            lstSurgery = new ListBox();
            btnToICU = new Button();
            btnToDone = new Button();
            btnSendToER = new Button();
            btnToPediatrics = new Button();
            btnToDerma = new Button();
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
            panelHeader.Size = new Size(650, 50);
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
            lblTitle.Text = "Surgery Queue";
            // 
            // lstSurgery
            // 
            lstSurgery.Font = new Font("Segoe UI", 9F);
            lstSurgery.FormattingEnabled = true;
            lstSurgery.Location = new Point(20, 70);
            lstSurgery.Name = "lstSurgery";
            lstSurgery.Size = new Size(350, 304);
            lstSurgery.TabIndex = 1;
            lstSurgery.SelectedIndexChanged += lstSurgery_SelectedIndexChanged;
            // 
            // btnToICU
            // 
            btnToICU.Font = new Font("Segoe UI", 9F);
            btnToICU.Location = new Point(390, 70);
            btnToICU.Name = "btnToICU";
            btnToICU.Size = new Size(230, 35);
            btnToICU.TabIndex = 2;
            btnToICU.Text = "Send to ICU";
            btnToICU.UseVisualStyleBackColor = true;
            btnToICU.Click += btnToICU_Click;
            // 
            // btnSendToER
            // 
            btnSendToER.Font = new Font("Segoe UI", 9F);
            btnSendToER.Location = new Point(390, 115);
            btnSendToER.Name = "btnSendToER";
            btnSendToER.Size = new Size(230, 35);
            btnSendToER.TabIndex = 3;
            btnSendToER.Text = "Send to Emergency Room";
            btnSendToER.UseVisualStyleBackColor = true;
            btnSendToER.Click += btnSendToER_Click;
            // 
            // btnToPediatrics
            // 
            btnToPediatrics.Font = new Font("Segoe UI", 9F);
            btnToPediatrics.Location = new Point(390, 160);
            btnToPediatrics.Name = "btnToPediatrics";
            btnToPediatrics.Size = new Size(230, 35);
            btnToPediatrics.TabIndex = 4;
            btnToPediatrics.Text = "Send to Pediatrics";
            btnToPediatrics.UseVisualStyleBackColor = true;
            btnToPediatrics.Click += btnToPediatrics_Click;
            // 
            // btnToDerma
            // 
            btnToDerma.Font = new Font("Segoe UI", 9F);
            btnToDerma.Location = new Point(390, 205);
            btnToDerma.Name = "btnToDerma";
            btnToDerma.Size = new Size(230, 35);
            btnToDerma.TabIndex = 5;
            btnToDerma.Text = "Send to Derma";
            btnToDerma.UseVisualStyleBackColor = true;
            btnToDerma.Click += btnToDerma_Click;
            // 
            // btnToDone
            // 
            btnToDone.Font = new Font("Segoe UI", 9F);
            btnToDone.Location = new Point(390, 250);
            btnToDone.Name = "btnToDone";
            btnToDone.Size = new Size(230, 35);
            btnToDone.TabIndex = 6;
            btnToDone.Text = "Mark as Completed";
            btnToDone.UseVisualStyleBackColor = true;
            btnToDone.Click += btnToDone_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(390, 310);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(230, 40);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh Queue";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormSurgery
            // 
            ClientSize = new Size(650, 400);
            Controls.Add(btnRefresh);
            Controls.Add(btnToDone);
            Controls.Add(btnToDerma);
            Controls.Add(btnToPediatrics);
            Controls.Add(btnSendToER);
            Controls.Add(btnToICU);
            Controls.Add(lstSurgery);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormSurgery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Surgery Department";
            Load += (sender, e) => RefreshQueue();
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}

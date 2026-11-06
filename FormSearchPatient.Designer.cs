namespace dsa.QUEUE.Hospital
{
    partial class FormSearchPatient
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
            lblSearchBy = new Label();
            txtKeyword = new TextBox();
            btnSearch = new Button();
            lstResults = new ListBox();
            SuspendLayout();
            // 
            // lblSearchBy
            // 
            lblSearchBy.Location = new Point(20, 20);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(200, 23);
            lblSearchBy.TabIndex = 6;
            lblSearchBy.Text = "Search by Patient No or Name:";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(20, 50);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(260, 27);
            txtKeyword.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(290, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 27);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lstResults
            // 
            lstResults.Font = new Font("Segoe UI", 9F);
            lstResults.FormattingEnabled = true;
            lstResults.Location = new Point(20, 90);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(350, 204);
            lstResults.TabIndex = 3;
            lstResults.SelectedIndexChanged += lstResults_SelectedIndexChanged;
            // 
            // FormSearchPatient
            // 
            ClientSize = new Size(400, 320);
            Controls.Add(lstResults);
            Controls.Add(btnSearch);
            Controls.Add(txtKeyword);
            Controls.Add(lblSearchBy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormSearchPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstResults;
    }
}

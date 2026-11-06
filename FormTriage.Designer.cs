namespace dsa.QUEUE.Hospital
{
    partial class FormTriage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstTriage = new System.Windows.Forms.ListBox();
            this.btnToER = new System.Windows.Forms.Button();
            this.btnToPediatrics = new System.Windows.Forms.Button();
            this.btnToDerma = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTriage
            // 
            this.lstTriage.FormattingEnabled = true;
            this.lstTriage.ItemHeight = 20;
            this.lstTriage.Location = new System.Drawing.Point(20, 20);
            this.lstTriage.Name = "lstTriage";
            this.lstTriage.Size = new System.Drawing.Size(420, 364);
            this.lstTriage.TabIndex = 0;
            // 
            // btnToER
            // 
            this.btnToER.Location = new System.Drawing.Point(460, 30);
            this.btnToER.Name = "btnToER";
            this.btnToER.Size = new System.Drawing.Size(180, 40);
            this.btnToER.TabIndex = 1;
            this.btnToER.Text = "Send to ER";
            this.btnToER.UseVisualStyleBackColor = true;
            this.btnToER.Click += new System.EventHandler(this.btnToER_Click);
            // 
            // btnToPediatrics
            // 
            this.btnToPediatrics.Location = new System.Drawing.Point(460, 90);
            this.btnToPediatrics.Name = "btnToPediatrics";
            this.btnToPediatrics.Size = new System.Drawing.Size(180, 40);
            this.btnToPediatrics.TabIndex = 2;
            this.btnToPediatrics.Text = "Send to Pediatrics";
            this.btnToPediatrics.UseVisualStyleBackColor = true;
            this.btnToPediatrics.Click += new System.EventHandler(this.btnToPediatrics_Click);
            // 
            // btnToDerma
            // 
            this.btnToDerma.Location = new System.Drawing.Point(460, 150);
            this.btnToDerma.Name = "btnToDerma";
            this.btnToDerma.Size = new System.Drawing.Size(180, 40);
            this.btnToDerma.TabIndex = 3;
            this.btnToDerma.Text = "Send to Derma";
            this.btnToDerma.UseVisualStyleBackColor = true;
            this.btnToDerma.Click += new System.EventHandler(this.btnToDerma_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(460, 330);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(180, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormTriage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 410);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnToDerma);
            this.Controls.Add(this.btnToPediatrics);
            this.Controls.Add(this.btnToER);
            this.Controls.Add(this.lstTriage);
            this.Name = "FormTriage";
            this.Text = "Triage Department";
            this.Load += new System.EventHandler(this.FormTriage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTriage;
        private System.Windows.Forms.Button btnToER;
        private System.Windows.Forms.Button btnToPediatrics;
        private System.Windows.Forms.Button btnToDerma;
        private System.Windows.Forms.Button btnRefresh;
    }
}

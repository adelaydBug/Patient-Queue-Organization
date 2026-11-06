using System;
using System.Windows.Forms;

namespace dsa.QUEUE.Hospital
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            pbLogo.Image = (Image)Properties.Resources.LogoHospital;
            pbLogo.BringToFront();

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            new FormInformation().Show();
        }

        private void btnTriage_Click(object sender, EventArgs e)
        {
            new FormTriage().Show();
        }

        private void btnER_Click(object sender, EventArgs e)
        {
            new FormER().Show();
        }

        private void btnICU_Click(object sender, EventArgs e)
        {
            new FormICU().Show();
        }

        private void btnSurgery_Click(object sender, EventArgs e)
        {
            new FormSurgery().Show();
        }

        private void btnXRay_Click(object sender, EventArgs e)
        {
            new FormXRay().Show();
        }

        private void btnLaboratory_Click(object sender, EventArgs e)
        {
            new FormLaboratory().Show();
        }

        private void btnDerma_Click(object sender, EventArgs e)
        {
            new FormDerma().Show();
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            new FormPharmacy().Show();
        }

        private void btnPediatrics_Click(object sender, EventArgs e)
        {
            new FormPediatrics().Show();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            new FormDone().Show();
        }

        // ✅ Dashboard panel click handlers
        private void panelInfo_Click(object sender, EventArgs e)
        {
            btnInformation.PerformClick();
        }

        private void panelER_Click(object sender, EventArgs e)
        {
            btnER.PerformClick();
        }

        private void panelDiag_Click(object sender, EventArgs e)
        {
            btnXRay.PerformClick(); // or open a diagnostic dashboard if you build one
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            new FormInformation().Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new FormSearchPatient().Show();
        }

        private void btnViewAllPatients_Click(object sender, EventArgs e)
        {
            new FormViewAllPatients().Show();
        }

        private void lblDiag_Click(object sender, EventArgs e)
        {
            var xrayForm = new FormXRay();
            xrayForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var infoForm = new FormInformation();
            infoForm.Show();
        }

        private void lblER_Click(object sender, EventArgs e)
        {
            var erForm = new FormER();
            erForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var searchForm = new FormSearchPatient();
            searchForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

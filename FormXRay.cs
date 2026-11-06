using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace dsa.QUEUE.Hospital
{
    public partial class FormXRay : Form
    {
        public FormXRay()
        {
            InitializeComponent();
            RefreshList();
        }

        // ✅ Load X-Ray queue into listbox
        private void RefreshList()
        {
            lstXRay.Items.Clear();

            foreach (var p in HospitalQueues.GetQueue("X-Ray"))
            {
                lstXRay.Items.Add(
                    $"{p.Timestamp} | #{p.PatientNo} | {p.Name} | Age:{p.Age} | {p.Diagnosis} | {p.Status}"
                );
            }
        }

        // ✅ Process patient → move to DONE + update DB
        private void btnProcess_Click(object sender, EventArgs e)
        {
            var xrayQueue = HospitalQueues.GetQueue("X-Ray");

            if (xrayQueue.Count == 0)
            {
                MessageBox.Show("No patients in X-Ray queue.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ✅ Remove from X-Ray queue
            var p = xrayQueue.Dequeue();

            // ✅ Update patient object
            p.Department = "Done";
            p.Status = "Completed";

            // ✅ Add to Done queue
            HospitalQueues.GetQueue("Done").Enqueue(p);

            // ✅ Update database
            string sql = @"
                UPDATE Patients
                SET Department = @dept, Status = @status
                WHERE PatientNumber = @pno;
            ";

            Database.Execute(
                sql,
                new SqliteParameter("@dept", p.Department),
                new SqliteParameter("@status", p.Status),
                new SqliteParameter("@pno", p.PatientNo)
            );

            RefreshList();

            MessageBox.Show("Patient processed and marked as Completed.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void FormXRay_Load(object sender, EventArgs e)
        {
        }
    }
}

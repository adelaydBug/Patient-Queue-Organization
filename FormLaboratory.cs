using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace dsa.QUEUE.Hospital
{
    public partial class FormLaboratory : Form
    {
        public FormLaboratory()
        {
            InitializeComponent();
            RefreshList();
        }

        // ✅ Load Laboratory queue into listbox
        private void RefreshList()
        {
            lstLaboratory.Items.Clear();

            foreach (var p in HospitalQueues.GetQueue("Laboratory"))
            {
                lstLaboratory.Items.Add(
                    $"{p.Timestamp} | #{p.PatientNo} | {p.Name} | Age:{p.Age} | {p.Diagnosis} | {p.Status}"
                );
            }
        }

        // ✅ Process patient → move to DONE + update DB
        private void btnProcess_Click(object sender, EventArgs e)
        {
            var labQueue = HospitalQueues.GetQueue("Laboratory");

            if (labQueue.Count == 0)
            {
                MessageBox.Show("No patients in Laboratory queue.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ✅ Remove from Laboratory queue
            var p = labQueue.Dequeue();

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

        private void FormLaboratory_Load(object sender, EventArgs e)
        {
        }

        private void btnProcess_Click_1(object sender, EventArgs e)
        {

        }
    }
}

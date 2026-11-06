using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace dsa.QUEUE.Hospital
{
    public partial class FormSurgery : Form
    {
        public FormSurgery()
        {
            InitializeComponent();
            RefreshQueue();
        }

        // ===========================
        //  REFRESH SURGERY QUEUE LIST
        // ===========================
        private void RefreshQueue()
        {
            lstSurgery.Items.Clear();

            var queue = HospitalQueues.GetQueue("Surgery");
            if (queue == null) return;

            foreach (var p in queue)
            {
                lstSurgery.Items.Add(
                    $"{p.Timestamp} | #{p.PatientNo} | {p.Name} | Age:{p.Age} | {p.Diagnosis} | {p.Status}"
                );
            }
        }

        // ===========================================
        //  UNIVERSAL MOVE METHOD (DB + MEMORY UPDATE)
        // ===========================================
        private void MoveFromSurgeryTo(string targetDepartment)
        {
            var surgeryQueue = HospitalQueues.GetQueue("Surgery");

            if (surgeryQueue == null || surgeryQueue.Count == 0)
            {
                MessageBox.Show("No patients in Surgery queue.");
                return;
            }

            // Remove first person in Surgery queue
            var p = surgeryQueue.Dequeue();

            // Update patient object values
            p.Department = targetDepartment;
            p.Status = targetDepartment == "Done"
                ? "Completed"
                : $"In Queue - {targetDepartment}";

            // Add to target queue
            HospitalQueues.GetQueue(targetDepartment)?.Enqueue(p);

            // ==================
            //  UPDATE DATABASE
            // ==================
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

            // Refresh UI list
            RefreshQueue();
        }

        // ============
        //  BUTTONS
        // ============

        private void btnToICU_Click(object sender, EventArgs e)
        {
            MoveFromSurgeryTo("ICU");
        }

        private void btnToDone_Click(object sender, EventArgs e)
        {
            MoveFromSurgeryTo("Done");
            MessageBox.Show("Patient marked as Completed.");
        }

        private void btnSendToER_Click(object sender, EventArgs e)
        {
            MoveFromSurgeryTo("Emergency Room");
            MessageBox.Show("Patient sent to Emergency Room.");
        }

        private void btnToPediatrics_Click(object sender, EventArgs e)
        {
            MoveFromSurgeryTo("Pediatrics");
        }

        private void btnToDerma_Click(object sender, EventArgs e)
        {
            MoveFromSurgeryTo("Derma");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshQueue();
        }

        private void lstSurgery_SelectedIndexChanged(object sender, EventArgs e)
        {
            // intentionally empty
        }
    }
}

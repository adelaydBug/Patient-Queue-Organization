using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace dsa.QUEUE.Hospital
{
    public partial class FormICU : Form
    {
        public FormICU()
        {
            InitializeComponent();
            RefreshList();
        }

        // ==========================
        //     LOAD ICU QUEUE
        // ==========================
        private void RefreshList()
        {
            lstICU.Items.Clear();

            foreach (var p in HospitalQueues.GetQueue("ICU"))
            {
                lstICU.Items.Add(
                    $"{p.Timestamp} | #{p.PatientNo} | {p.Name} | Age:{p.Age} | {p.Diagnosis} | {p.Status}"
                );
            }
        }

        // ==========================
        //   MOVE ICU → ANOTHER AREA
        // ==========================
        private void MoveFromICUTo(string targetDepartment)
        {
            var icuQueue = HospitalQueues.GetQueue("ICU");

            if (icuQueue.Count == 0)
            {
                MessageBox.Show("No patients in ICU queue.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Remove from ICU
            var p = icuQueue.Dequeue();

            // Update patient
            p.Department = targetDepartment;
            p.Status = targetDepartment == "Done"
                ? "Completed"
                : $"In Queue - {targetDepartment}";

            // Add to new queue
            HospitalQueues.GetQueue(targetDepartment).Enqueue(p);

            // Update database
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
        }

        // ==========================
        //       BUTTON EVENTS
        // ==========================

        // ICU → Surgery
        private void btnToSurgery_Click(object sender, EventArgs e)
        {
            MoveFromICUTo("Surgery");
        }

        // ICU → Done / Completed
        private void btnToDone_Click(object sender, EventArgs e)
        {
            MoveFromICUTo("Done");

            MessageBox.Show("Patient marked as Completed.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void lstICU_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormICU_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}

using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace dsa.QUEUE.Hospital
{
    public partial class FormTriage : Form
    {
        public FormTriage()
        {
            InitializeComponent();
        }

        private void FormTriage_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        // =====================================================
        //  Load TRIAGE patients from DATABASE into the ListBox
        // =====================================================
        private void RefreshList()
        {
            lstTriage.Items.Clear();

            string query = @"
                SELECT Id, PatientNumber, Name, Age, Diagnosis
                FROM Patients
                WHERE Department = 'Triage' AND Status = 'Waiting'
                ORDER BY Timestamp;
            ";

            using var reader = Database.Query(query);

            while (reader.Read())
            {
                lstTriage.Items.Add(new PatientItem
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    PatientNo = Convert.ToInt32(reader["PatientNumber"]),
                    Name = reader["Name"].ToString() ?? "",
                    Age = Convert.ToInt32(reader["Age"]),
                    Diagnosis = reader["Diagnosis"].ToString() ?? "",
                    Display = $"#{reader["PatientNumber"]} | {reader["Name"]} | Age:{reader["Age"]} | {reader["Diagnosis"]}"
                });
            }
        }

        // =====================================
        // Helper class stored inside the ListBox
        // =====================================
        private class PatientItem
        {
            public int Id { get; set; }
            public int PatientNo { get; set; }
            public string Name { get; set; } = "";
            public int Age { get; set; }
            public string Diagnosis { get; set; } = "";
            public string? Display { get; set; }
            public override string ToString() => Display ?? "";
        }

        // =========================
        // Get selected patient safely
        // =========================
        private PatientItem? GetSelectedPatient()
        {
            if (lstTriage.SelectedItem is not PatientItem item)
            {
                MessageBox.Show("Please select a patient from the list.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return item;
        }

        // ====================================================
        // Move patient from TRIAGE → another department + DB + QUEUE
        // ====================================================
        private void MovePatient(string newDepartment)
        {
            var item = GetSelectedPatient();
            if (item == null) return;

            // ✅ Build patient object directly from selected item
            var p = new Patient
            {
                Id = item.Id,
                PatientNo = item.PatientNo,
                Name = item.Name,
                Age = item.Age,
                Diagnosis = item.Diagnosis,
                Department = newDepartment,
                Status = "Waiting",
                Timestamp = DateTime.Now
            };

            // ✅ Add to the correct in-memory queue
            HospitalQueues.GetQueue(newDepartment).Enqueue(p);

            // ✅ Update database
            string query = @"
                UPDATE Patients
                SET Department = @Dep,
                    Status = 'Waiting'
                WHERE Id = @Id;
            ";

            Database.Execute(
                query,
                new SqliteParameter("@Dep", newDepartment),
                new SqliteParameter("@Id", item.Id)
            );

            RefreshList();
            MessageBox.Show($"Patient sent to {newDepartment}.",
    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // ===========================
        //        BUTTON EVENTS
        // ===========================

        // Triage → ER
        private void btnToER_Click(object sender, EventArgs e)
        {
            MovePatient("Emergency Room");
        }

        // Triage → Pediatrics
        private void btnToPediatrics_Click(object sender, EventArgs e)
        {
            MovePatient("Pediatrics");
        }

        // Triage → Derma
        private void btnToDerma_Click(object sender, EventArgs e)
        {
            MovePatient("Derma");
        }

        // Manual refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}

using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace dsa.QUEUE.Hospital
{
    public partial class FormER : Form
    {
        public FormER()
        {
            InitializeComponent();

            lstER.DisplayMember = "DisplayText";
            lstER.ValueMember = "Id";
        }

        private void FormER_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        // ✅ Load Emergency Room patients (NOW WITH AGE)
        private void RefreshList()
        {
            lstER.Items.Clear();

            string query = @"
                SELECT Id, PatientNumber, Name, Age, Diagnosis
                FROM Patients
                WHERE Department = 'Emergency Room'
                AND Status = 'Waiting'
                ORDER BY Timestamp;
            ";

            using var reader = Database.Query(query);

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                int patNo = Convert.ToInt32(reader["PatientNumber"]);
                string name = reader["Name"]?.ToString() ?? "";
                int age = Convert.ToInt32(reader["Age"]);
                string diag = reader["Diagnosis"]?.ToString() ?? "";

                lstER.Items.Add(new PatientItem
                {
                    Id = id,
                    PatientNo = patNo,
                    Name = name,
                    Age = age,
                    Diagnosis = diag,
                    DisplayText = $"#{patNo} | {name} | Age:{age} | {diag}"
                });
            }
        }

        // ✅ Object stored in ListBox
        private class PatientItem
        {
            public int Id { get; set; }
            public int PatientNo { get; set; }
            public string Name { get; set; } = "";
            public int Age { get; set; }
            public string Diagnosis { get; set; } = "";
            public string? DisplayText { get; set; }
            public override string ToString() => DisplayText ?? "";
        }

        // ✅ Safe selection getter
        private PatientItem? GetSelectedPatient()
        {
            if (lstER.SelectedItem is not PatientItem item)
            {
                MessageBox.Show("Please select a patient first.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return item;
        }

        // ✅ Move to another department (DB only)
        private void MoveTo(string newDepartment, string newStatus)
        {
            var item = GetSelectedPatient();
            if (item == null) return;

            string query = @"
                UPDATE Patients
                SET Department = @Dep, Status = @Status
                WHERE Id = @Id;
            ";

            Database.Execute(query,
                new SqliteParameter("@Dep", newDepartment),
                new SqliteParameter("@Status", newStatus),
                new SqliteParameter("@Id", item.Id)
            );

            RefreshList();
        }

        // ✅ ER → ICU (FULL PATIENT INFO + QUEUE)
        private void btnToICU_Click(object sender, EventArgs e)
        {
            var item = GetSelectedPatient();
            if (item == null) return;

            // Build complete patient object
            var p = new Patient
            {
                Id = item.Id,
                PatientNo = item.PatientNo,
                Name = item.Name,
                Age = item.Age,
                Diagnosis = item.Diagnosis,
                Department = "ICU",
                Status = "Waiting",
                Timestamp = DateTime.Now
            };

            // Add to ICU queue
            HospitalQueues.GetQueue("ICU").Enqueue(p);

            // Update database
            string query = @"
                UPDATE Patients
                SET Department = @Dep, Status = @Status
                WHERE Id = @Id;
            ";

            Database.Execute(query,
                new SqliteParameter("@Dep", p.Department),
                new SqliteParameter("@Status", p.Status),
                new SqliteParameter("@Id", p.Id)
            );

            RefreshList();

            MessageBox.Show("Patient sent to ICU.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ✅ ER → Done
        private void btnToDone_Click(object sender, EventArgs e)
        {
            MoveTo("Done", "Completed");

            MessageBox.Show("Patient marked as Completed.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}

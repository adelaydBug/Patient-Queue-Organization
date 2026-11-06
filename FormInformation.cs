using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace dsa.QUEUE.Hospital
{
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        private void FormInformation_Load(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // ✅ Basic validation
            if (string.IsNullOrWhiteSpace(txtPatientNo.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnosis.Text))
            {
                MessageBox.Show("Please fill in Patient No, Name, Age, and Diagnosis.",
                    "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPatientNo.Text.Trim(), out int patientNo))
            {
                MessageBox.Show("Patient No must be a valid number.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text.Trim(), out int age))
            {
                MessageBox.Show("Age must be a valid number.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Get diagnosis and auto-route to department
            string diagnosis = txtDiagnosis.Text!.Trim();
            string department = DepartmentRouter.GetDepartment(diagnosis)!;
            var now = DateTime.Now;

            // ✅ Create patient object
            Patient p = new Patient()
            {
                PatientNo = patientNo,
                Name = txtName.Text!.Trim(),
                Age = age,
                Diagnosis = diagnosis,
                Notes = "",
                Timestamp = now,
                Department = department,
                Status = "Waiting"
            };

            // ✅ Save to database
            string sql = @"
                INSERT INTO Patients 
                    (PatientNumber, Name, Age, Diagnosis, Department, Status, Timestamp) 
                VALUES 
                    (@pno, @name, @age, @diagnosis, @dept, @status, @timestamp);
            ";

            Database.Execute(
                sql,
                new SqliteParameter("@pno", p.PatientNo),
                new SqliteParameter("@name", p.Name),
                new SqliteParameter("@age", p.Age),
                new SqliteParameter("@diagnosis", p.Diagnosis),
                new SqliteParameter("@dept", p.Department),
                new SqliteParameter("@status", p.Status),
                new SqliteParameter("@timestamp", p.Timestamp)
            );

            // ✅ Add to correct in-memory queue
            HospitalQueues.GetQueue(department).Enqueue(p);

            // ✅ Confirmation
            MessageBox.Show(
                $"Patient registered and routed to {p.Department}.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // ✅ Clear fields
            txtPatientNo.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtDiagnosis.Clear();
            txtPatientNo.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

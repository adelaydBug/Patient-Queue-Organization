using System;
using System.Windows.Forms;

namespace dsa.QUEUE.Hospital
{
    public partial class FormViewAllPatients : Form
    {
        public FormViewAllPatients()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            lstPatients.Items.Clear();

            string query = @"
                SELECT PatientNumber, Name, Age, Diagnosis, Department, Status, Timestamp
                FROM Patients
                ORDER BY Timestamp DESC;
            ";

            using (var reader = Database.Query(query))
            {
                while (reader.Read())
                {
                    string patNo = reader["PatientNumber"]?.ToString() ?? "";
                    string name = reader["Name"]?.ToString() ?? "";
                    string age = reader["Age"]?.ToString() ?? "";
                    string dep = reader["Department"]?.ToString() ?? "";
                    string status = reader["Status"]?.ToString() ?? "";
                    string time = reader["Timestamp"]?.ToString() ?? "";

                    lstPatients.Items.Add($"{time} | {patNo} | {name} | Age:{age} | {dep} | {status}");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           //Database.Execute("DELETE FROM Patients");

            LoadPatients();
        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

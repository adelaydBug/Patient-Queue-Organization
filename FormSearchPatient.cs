using System;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace dsa.QUEUE.Hospital
{
    public partial class FormSearchPatient : Form
    {
        public FormSearchPatient()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            string keyword = txtKeyword.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Enter a patient number or name.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = @"
                SELECT PatientNumber, Name, Age, Diagnosis, Department, Status, Timestamp
                FROM Patients
                WHERE PatientNumber LIKE @kw OR Name LIKE @kw
                ORDER BY Timestamp DESC;
            ";

            using (var reader = Database.Query(query,
                new SqliteParameter("@kw", "%" + keyword + "%")))
            {
                while (reader.Read())
                {
                    string patNo = reader["PatientNumber"]?.ToString() ?? "";
                    string name = reader["Name"]?.ToString() ?? "";
                    string dep = reader["Department"]?.ToString() ?? "";
                    string status = reader["Status"]?.ToString() ?? "";
                    string time = reader["Timestamp"]?.ToString() ?? "";

                    lstResults.Items.Add($"{time} | {patNo} | {name} | {dep} | {status}");
                }
            }
        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

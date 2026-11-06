using System;
using System.Windows.Forms;

namespace dsa.QUEUE.Hospital
{
    public partial class FormDone : Form
    {
        public FormDone()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            lstDone.Items.Clear();

            // ✅ FIXED: Status should be 'Completed', not 'Done'
            string query = @"
                SELECT PatientNumber, Name, Diagnosis, Department, Timestamp
                FROM Patients
                WHERE Status = 'Completed'
                ORDER BY Timestamp DESC;
            ";

            using (var reader = Database.Query(query))
            {
                while (reader.Read())
                {
                    string patNo = reader["PatientNumber"]?.ToString() ?? "";
                    string name = reader["Name"]?.ToString() ?? "";
                    string diag = reader["Diagnosis"]?.ToString() ?? "";
                    string dep = reader["Department"]?.ToString() ?? "";
                    string time = reader["Timestamp"]?.ToString() ?? "";

                    lstDone.Items.Add($"{time} | #{patNo} | {name} | {dep} | {diag}");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void FormDone_Load(object sender, EventArgs e)
        {
        }
    }
}

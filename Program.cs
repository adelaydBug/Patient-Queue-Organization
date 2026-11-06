using System;
using System.Data;
using System.Windows.Forms;

namespace dsa.QUEUE.Hospital
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ? Initialize database connection + ensure tables exist
            Database.Initialize();

            // ? Load queues from database BEFORE starting the app
            HospitalQueues.LoadFromDatabase();

            // ? Start main window
            Application.Run(new FormMain());
        }
    }
}

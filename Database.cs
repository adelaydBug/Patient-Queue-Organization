using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace dsa.QUEUE.Hospital
{
    public static class Database
    {
        // ✔ Required so other classes can open connections
        public static string ConnectionString = "Data Source=hospital.db";

        public static void Initialize()
        {
            if (!File.Exists("hospital.db"))
            {
                File.Create("hospital.db").Dispose();
            }


            using var con = new SqliteConnection(ConnectionString);
            con.Open();

            string sql = @"
                CREATE TABLE IF NOT EXISTS Patients (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    PatientNumber INTEGER,
                    Name TEXT,
                    Age INTEGER,
                    Diagnosis TEXT,
                    Department TEXT,
                    Status TEXT,
                    Timestamp TEXT
                );
            ";

            using var cmd = new SqliteCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        // ✔ Execute INSERT/UPDATE/DELETE
        public static void Execute(string sql, params SqliteParameter[] parameters)
        {
            using var con = new SqliteConnection(ConnectionString);
            con.Open();

            using var cmd = new SqliteCommand(sql, con);
            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
        }

        // ✔ Return a SqliteDataReader (used by HospitalQueues)
        public static SqliteDataReader Query(string sql, params SqliteParameter[] parameters)
        {
            var con = new SqliteConnection(ConnectionString);
            con.Open();

            var cmd = new SqliteCommand(sql, con);
            cmd.Parameters.AddRange(parameters);

            // Reader must NOT close connection automatically
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
    }
}

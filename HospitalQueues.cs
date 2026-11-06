using dsa.QUEUE.Hospital;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

public static class HospitalQueues
{
    // ==============================================================
    //  ALL QUEUES (includes DONE to fix KeyNotFoundException)
    // ==============================================================
    public static Dictionary<string, Queue<Patient>> Queues = new()
    {
        { "Triage", new Queue<Patient>() },
        { "Emergency Room", new Queue<Patient>() },
        { "ICU", new Queue<Patient>() },
        { "Surgery", new Queue<Patient>() },
        { "X-Ray", new Queue<Patient>() },
        { "Laboratory", new Queue<Patient>() },
        { "Derma", new Queue<Patient>() },
        { "Pediatrics", new Queue<Patient>() },
        { "Pharmacy", new Queue<Patient>() },
        { "Done", new Queue<Patient>() } // ✅ REQUIRED
    };

    // ==============================================================
    //  SAFE ACCESS — prevents future crashes
    // ==============================================================
    public static Queue<Patient> GetQueue(string dept)
    {
        if (!Queues.ContainsKey(dept))
        {
            Queues[dept] = new Queue<Patient>();
        }

        return Queues[dept];
    }

    // ==============================================================
    //  FIND PATIENT BY DATABASE ID (used in Triage)
    // ==============================================================
    public static Patient? FindById(int id)
    {
        foreach (var queue in Queues.Values)
        {
            foreach (var p in queue)
            {
                if (p.Id == id)
                    return p;
            }
        }

        return null;
    }

    // ==============================================================
    //  LOAD PATIENTS FROM DATABASE
    // ==============================================================
    public static void LoadFromDatabase()
    {
        foreach (var key in Queues.Keys)
            Queues[key].Clear();

        using var con = new SqliteConnection(Database.ConnectionString);
        con.Open();

        string sql = "SELECT * FROM Patients WHERE Status LIKE 'In Queue%';";

        using var cmd = new SqliteCommand(sql, con);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            string? tsString =
                reader.IsDBNull(reader.GetOrdinal("Timestamp"))
                ? null
                : reader.GetString(reader.GetOrdinal("Timestamp"));

            DateTime ts;
            if (!DateTime.TryParse(tsString, out ts))
            {
                ts = DateTime.Now;
            }

            Patient p = new Patient
            {
                Id = Convert.ToInt32(reader["Id"]), // ✅ Make sure this is included in your Patient class
                Timestamp = ts,
                PatientNo = Convert.ToInt32(reader["PatientNumber"]),
                Name = reader["Name"]?.ToString() ?? "",
                Age = Convert.ToInt32(reader["Age"]),
                Diagnosis = reader["Diagnosis"]?.ToString() ?? "",
                Department = reader["Department"]?.ToString() ?? "",
                Status = reader["Status"]?.ToString() ?? ""
            };

            if (!string.IsNullOrWhiteSpace(p.Department))
            {
                GetQueue(p.Department).Enqueue(p);
            }
        }
    }
}

using dsa.QUEUE.Hospital;
using System;
using System.Collections.Generic;

public static class QueueManager
{
    public static List<Patient> AllPatients = new List<Patient>();
    public static List<Patient> Triage = new List<Patient>();
    public static List<Patient> Emergency = new List<Patient>();
    public static List<Patient> Surgery = new List<Patient>();
    public static List<Patient> XRay = new List<Patient>();
    public static List<Patient> Laboratory = new List<Patient>();

    public static void AddPatient(Patient p)
    {
        AllPatients.Add(p);
        AutoAssign(p);
    }

    public static void AutoAssign(Patient p)
    {
        // Use the NEW classifier
        string department = DiagnosisClassifier.Classify(p.Diagnosis);
        p.Department = department;

        // Add to respective queue
        switch (department)
        {
            case "ER":
                Emergency.Add(p);
                break;

            case "Surgery":
                Surgery.Add(p);
                break;

            case "X-Ray":
                XRay.Add(p);
                break;

            case "Laboratory":
                Laboratory.Add(p);
                break;

            default:
                Triage.Add(p);
                break;
        }
    }
}

using System;
using System.Collections.Generic;

namespace dsa.QUEUE.Hospital
{
    public static class DepartmentRouter
    {
        private static readonly Dictionary<string, string> DiagnosisMap = new()
        {
            { "Fracture", "X-Ray" },
            { "Bleeding", "Emergency Room" },
            { "Tumor", "X-Ray" },
            { "Spine", "X-Ray" },
            { "Broken Bone", "X-Ray" },
            { "Head Injury", "Emergency Room" },
            { "Chest Pain", "Emergency Room" },
            { "Heart Attack", "ICU" },
            { "Skin Rash", "Derma" },
            { "Allergic Reaction", "Derma" },
            { "High Fever", "Pediatrics" },
            { "Lab Test", "Laboratory" },
            { "UTI", "Laboratory" },
            { "Blood Test", "Laboratory" },
            { "Accident", "Surgery" },
            { "Surgery Needed", "Surgery" },
            { "Appendicitis", "Surgery" },
            { "Medication Only", "Pharmacy" },
            { "Drug", "Pharmacy" },
            { "Prescription Refill", "Pharmacy" },
            { "General Checkup", "Triage" }   // CHANGE THIS (was Information)
        };

        public static string GetDepartment(string diagnosis)
        {
            if (string.IsNullOrWhiteSpace(diagnosis))
                return "Triage";

            string trimmed = diagnosis.Trim();

            if (DiagnosisMap.TryGetValue(trimmed, out string? department))
                return department;

            string lower = trimmed.ToLower();

            // 🚑 Severe conditions bypass TRIAGE
            if (lower.Contains("fracture") || lower.Contains("broken") || lower.Contains("bone"))
                return "X-Ray";

            if (lower.Contains("injury") || lower.Contains("trauma"))
                return "Emergency Room";

            if (lower.Contains("chest pain") || lower.Contains("breath"))
                return "Emergency Room";

            if (lower.Contains("heart attack") || lower.Contains("cardiac"))
                return "ICU";

            if (lower.Contains("appendicitis") || lower.Contains("surgery"))
                return "Surgery";

            // 🧴 Skin & allergies → Derma
            if (lower.Contains("rash") || lower.Contains("allergy") || lower.Contains("skin"))
                return "Derma";

            // 👶 Cough / fever / flu → Pediatrics
            if (lower.Contains("fever") || lower.Contains("cough") || lower.Contains("flu"))
                return "Pediatrics";

            // 🔬 Lab work
            if (lower.Contains("lab") || lower.Contains("test") || lower.Contains("blood"))
                return "Laboratory";

            // 💊 Pharmacy
            if (lower.Contains("medicine") || lower.Contains("medication") || lower.Contains("prescription"))
                return "Pharmacy";

            // 🟦 Default: TRIAGE
            return "Triage";
        }
    }
}

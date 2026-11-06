using System;
using System.Collections.Generic;
using System.Linq;

namespace dsa.QUEUE.Hospital
{
    public static class DiagnosisClassifier
    {
        // Mapping of departments → list of keywords
        private static readonly Dictionary<string, string[]> DepartmentKeywords =
            new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)
        {
            { "ER", new[]
                { "heart", "attack", "stroke", "bleed", "bleeding", "injury",
                  "accident", "trauma", "unconscious", "severe", "gunshot", "stab" }
            },

            { "ICU", new[]
                { "critical", "coma", "life-threatening", "ventilator", "unstable" }
            },

            { "Surgery", new[]
                { "surgery", "operation", "appendix", "appendicitis", "incision" }
            },

            { "X-Ray", new[]
                { "x-ray", "fracture", "bone", "sprain", "dislocation" }
            },

            { "Laboratory", new[]
                { "lab", "blood", "urine", "cbc", "test", "analysis" }
            },

            { "Derma", new[]
                { "skin", "rash", "derma", "itch", "acne", "allergy" }
            },

            { "Pediatrics", new[]
                { "child", "kid", "baby", "pediatric", "infant" }
            },

            { "Pharmacy", new[]
                { "medicine", "prescription", "drug", "medication" }
            }
        };

        // Main classification function
        public static string Classify(string diagnosis)
        {
            if (string.IsNullOrWhiteSpace(diagnosis))
                return "General";

            diagnosis = diagnosis.ToLower();

            foreach (var dept in DepartmentKeywords)
            {
                if (dept.Value.Any(keyword => diagnosis.Contains(keyword)))
                    return dept.Key;
            }

            return "General"; // default fallback
        }
    }
}

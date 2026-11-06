namespace dsa.QUEUE.Hospital
{
    public class Patient
    {
        public DateTime Timestamp { get; set; }
        public int PatientNo { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string Diagnosis { get; set; } = "";
        public string Department { get; set; } = "";
        public string Status { get; set; } = "";
        public string Notes { get; set; } = "";
        // Database ID
        public Patient() { }
        public int Id { get; set; } 
    }
}

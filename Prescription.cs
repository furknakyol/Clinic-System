public class Prescription
{
    public int PrescriptionID { get; set; }    
    public int DoctorID { get; set; }          
    public int PatientID { get; set; }         
    public DateTime DateIssued { get; set; }
    public string Medication { get; set; } = string.Empty;
    public string Dosage { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;

   
    public Doctor? Doctor { get; set; }
    public Patient? Patient { get; set; }
}

public class PatientContact
{
    public int ContactID { get; set; }      
    public int PatientID { get; set; }      
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Patient? Patient { get; set; } 
}

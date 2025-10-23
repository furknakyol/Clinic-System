public class DoctorContact
{
    public int ContactID { get; set; }      
    public int DoctorID { get; set; }       
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
   
    public Doctor? Doctor { get; set; }
}

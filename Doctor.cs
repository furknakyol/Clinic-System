public class Doctor
{
    public int DoctorID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;        
    public string Password { get; set; } = string.Empty;
    public string Specilization { get; set; } = string.Empty;

    public ICollection<DoctorContact> DoctorContacts { get; set; } = new List<DoctorContact>();
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}



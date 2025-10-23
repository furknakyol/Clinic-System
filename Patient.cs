public class Patient
{
    public int PatientID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;       
    public string Password { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }

    public string Gender { get; set; } = string.Empty;

    public ICollection<PatientContact> PatientContacts { get; set; } = new List<PatientContact>();
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

}



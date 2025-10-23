public class Appointment
{
    public int AppointmentID { get; set; }
    public int PatientID { get; set; }
    public int DoctorID { get; set; }

    public DateTime ApptDate { get; set; }
    public TimeSpan ApptTime { get; set; }
    public string Status { get; set; } = string.Empty;



    public Patient? Patient { get; set; }
    public Doctor? Doctor { get; set; }
    public Treatment? Treatment { get; set; }
}

public class Treatment
{
    public int TreatmentID{ get; set; }         
    public int AppointmentID { get; set; }       
    public string TreatmentType { get; set; } = string.Empty;
    public decimal Cost { get; set; }
    public DateTime TreatmentDate { get; set; }
    

    public Bill? Bill { get; set; }
    public Appointment? Appointment { get; set; }
}

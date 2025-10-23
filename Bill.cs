public class Bill
{
    public int BillID { get; set; }           
    public int TreatmentID { get; set; }      
    public decimal Amount { get; set; }
    public DateTime DateIssued { get; set; }
    

    
    public Treatment? Treatment { get; set; }
}

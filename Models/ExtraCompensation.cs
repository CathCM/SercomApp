namespace SercomApp.Models;

public class ExtraCompensation
{
    public int Id { get; set; }
    public int SalaryId { get; set; }
    public decimal Compensation { get; set; }
    public decimal GrossAmount { get; set; }
    public decimal NetAmount { get; set; }
    public decimal CompanyCost { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    
    public Salary Salary { get; set; }
}

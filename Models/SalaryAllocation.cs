namespace SercomApp.Models;

public class SalaryAllocation
{
    public int Id { get; set; }
    public int SalaryId { get; set; }
    public int BusinessLineId { get; set; }
    public decimal Percentage { get; set; }
    
    public Salary Salary { get; set; }
    public BusinessLine BusinessLine { get; set; }
    public ICollection<TicketEntry> TicketEntries { get; set; }
}

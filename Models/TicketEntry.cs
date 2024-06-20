namespace SercomApp.Models;

public class TicketEntry
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Hours { get; set; }
    public int EmployeeId { get; set; }
    public int TicketId { get; set; }
    public int SalaryAllocationId { get; set; }
    
    public Employee Employee { get; set; }
    public Ticket Ticket { get; set; }
    public SalaryAllocation SalaryAllocation { get; set; }
}

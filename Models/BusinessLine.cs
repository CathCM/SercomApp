namespace SercomApp.Models;

public class BusinessLine
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal TotalAmount { get; set; }
    
    public ICollection<Ticket> Tickets { get; set; }
    public ICollection<CompanyContract> CompanyContracts { get; set; }
    public ICollection<SalaryAllocation> SalaryAllocations { get; set; }
}

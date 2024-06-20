namespace SercomApp.Models;

public class CompanyContract
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal Amount { get; set; }
    public bool IsActive { get; set; }
    public string ServicePeriod { get; set; } // Agregado
    public int CompanyId { get; set; }
    public int BusinessLineId { get; set; }

    public Company Company { get; set; }
    public BusinessLine BusinessLine { get; set; }
}


namespace SercomApp.Models;

public class JobRole
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal? MinSalary { get; set; }
    public decimal? MaxSalary { get; set; }
    
    public ICollection<EmployeeContract> EmployeeContracts { get; set; }
}

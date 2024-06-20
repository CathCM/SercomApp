namespace SercomApp.Models;

public class Salary
{
    public int Id { get; set; }
    public decimal GrossAnnualSalary { get; set; }
    public decimal NetAnnualSalary { get; set; }
    public decimal CompanyCost { get; set; }
    public DateTime Date { get; set; }
    public int EmployeeContractId { get; set; }
    
    public EmployeeContract EmployeeContract { get; set; }
    public ICollection<ExtraCompensation> ExtraCompensations { get; set; }
    public ICollection<SalaryAllocation> SalaryAllocations { get; set; }
}

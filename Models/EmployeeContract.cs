namespace SercomApp.Models;

public class EmployeeContract
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsActive { get; set; }
    public int EmployeeId { get; set; }
    public int JobRoleId { get; set; }
    
    public Employee Employee { get; set; }
    public JobRole JobRole { get; set; }
    public ICollection<Salary> Salaries { get; set; }
}

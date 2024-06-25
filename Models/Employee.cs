namespace SercomApp.Models;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CompanyEmail { get; set; }
    public string PersonalEmail { get; set; }
    public string Phone { get; set; }
    public DateTime BirthDate { get; set; }
    public int UserId { get; set; }
    public int WoffuId { get; set; }
    public int FreshId { get; set; }
    public int ScheduleId { get; set; }
    public int DepartmentId { get; set; }

    public User User { get; set; }
    public Schedule Schedule { get; set; }
    public Department Department { get; set; }
    public ICollection<EmployeeContract> EmployeeContracts { get; set; }
    public ICollection<DailySchedule> DailySchedules { get; set; }
    public ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
    public ICollection<TicketEntry> TicketEntries { get; set; }
}
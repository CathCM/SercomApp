namespace SercomApp.Models;

public class Schedule
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal WorkingHours { get; set; }
    
    public ICollection<Employee> Employees { get; set; }
    public ICollection<DailySchedule> DailySchedules { get; set; }
}

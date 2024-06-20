namespace SercomApp.Models;

public class DailySchedule
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal WorkingHours { get; set; }
    public decimal AbsenceHours { get; set; }
    public bool Vacation { get; set; }
    public bool Absence { get; set; }
    public int EmployeeId { get; set; }
    public int ScheduleId { get; set; }
    
    public Employee Employee { get; set; }
    public Schedule Schedule { get; set; }
}

namespace SercomApp.Models;

public class EmployeeAddress
{
    public int EmployeeId { get; set; }
    public int AddressId { get; set; }
    
    public Employee Employee { get; set; }
    public Address Address { get; set; }
}

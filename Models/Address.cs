namespace SercomApp.Models;

public class Address
{
    public int Id { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string Floor { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Country { get; set; }
    public int CompanyId { get; set; }
    
    public Company Company { get; set; }
    public ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
}

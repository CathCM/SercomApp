namespace SercomApp.Models;

public class Company
{
    public int Id { get; set; }
    public string Nif { get; set; }
    public string Name { get; set; }
    public List<string> Emails { get; set; }
    
    public ICollection<Address> Addresses { get; set; }
    public ICollection<Ticket> Tickets { get; set; }
    public ICollection<CompanyContract> CompanyContracts { get; set; }
    public ICollection<PRTGProbe> PRTGProbes { get; set; }
}

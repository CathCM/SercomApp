namespace SercomApp.Models;

public class PRTGProbe
{
    public int Id { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string Data { get; set; }
    public int CompanyId { get; set; }

    public Company Company { get; set; }
}
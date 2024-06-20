namespace SercomApp.Models;

public class Ticket
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ExecutedDate { get; set; }
    public int BusinessLineId { get; set; }
    public int CompanyId { get; set; }
    
    public BusinessLine BusinessLine { get; set; }
    public Company Company { get; set; }
    public ICollection<TicketEntry> TicketEntries { get; set; }
}

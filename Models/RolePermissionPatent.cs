namespace SercomApp.Models;

public class RolePermissionPatent
{
    public int RoleId { get; set; }
    public int ResourceId { get; set; }
    public string PermissionName { get; set; }
    
    public Role Role { get; set; }
    public Resource Resource { get; set; }
    public Permission Permission { get; set; }
}

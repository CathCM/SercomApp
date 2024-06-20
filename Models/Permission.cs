namespace SercomApp.Models;

public class Permission
{
    public string Name { get; set; }
    
    public ICollection<RolePermissionPatent> RolePermissionPatents { get; set; }
}
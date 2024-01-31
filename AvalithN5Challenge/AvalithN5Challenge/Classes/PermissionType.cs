
namespace AvalithN5Challenge.Classes
{
    public class PermissionType()
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Permission> Permissions { get; set; }
    }
}

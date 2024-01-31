namespace AvalithN5Challenge.Classes
{
    public class Permission
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int PermissionTypeId { get; set; }
        public PermissionType? PermissionType { get; set; }

    }
}

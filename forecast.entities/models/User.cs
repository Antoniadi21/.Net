namespace forecast.entities
{
    class User : BaseEntity
    {
        public string email { get; set; }
        public Guid idCity { get; set; }
        public string passwordHash { get; set; }
        public bool isPrivileged { get; set; }
    }
}
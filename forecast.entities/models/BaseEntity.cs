namespace forecast.entities
 {
    class BaseEntity
     {
        public Guid id { get; set; }
        public DateTime creationTime { get; set; }
        public DateTime modificationTime { get; set; }

        public bool IsNew() 
        {
            return id == Guid.Empty;
        }

        public BaseEntity()
        {
            id = Guid.NewGuid();
            creationTime = DateTime.UtcNow;
            modificationTime = DateTime.UtcNow;
        }
    }
}
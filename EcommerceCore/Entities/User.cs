namespace EcommerceCore.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; } // Optional phone number, ? indicates it can be null
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid UserGuid { get; set; } = Guid.NewGuid(); // Unique identifier for the user, useful for external references, APIs, etc.

    }
}

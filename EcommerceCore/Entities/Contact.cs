namespace EcommerceCore.Entities
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now; // Default to current date and time
        public bool IsRead { get; set; }
    }
}

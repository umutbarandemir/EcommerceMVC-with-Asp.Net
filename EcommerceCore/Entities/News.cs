namespace EcommerceCore.Entities
{
    public class News : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Content { get; set; }
        public string? Image { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now; // Default to current date and time
        public bool IsActive { get; set; }
    }
}

namespace EcommerceCore.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public string? ProductCode { get; set; }
        public bool IsActive { get; set; }
        public int Stock { get; set; }
        public bool IsHome { get; set; }
        public int BrandId { get; set; }
        public Brand? Brand { get; set; } // Navigation property to Brand
        public int CategoryId { get; set; }
        public Category? Category { get; set; } // Navigation property to Category
        public int OrderNo { get; set; } // Order number for sorting
        public DateTime CreateDate { get; set; } = DateTime.Now; // Default to current date and time
    }
}

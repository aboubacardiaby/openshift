namespace Material.Web.Models
{
    public class MaterialEntity
    {
        // Summary:
        // Represents a material entity with properties such as Id, Name, Description, Price, Quantity, CreatedDate, and UpdatedDate.
        // Properties:
        // Id: Unique identifier for the material.
        // Name: Name of the material.
        // Description: Description of the material.
        // Price: Price of the material.
        // Quantity: Available quantity of the material.
        // CreatedDate: Date when the material was created.
        // UpdatedDate: Date when the material was last updated.

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; } // update date
    }
}
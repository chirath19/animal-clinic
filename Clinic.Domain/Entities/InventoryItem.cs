// Clinic.Domain/Entities/InventoryItem.cs

namespace Clinic.Domain.Entities;

public class InventoryItem : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = "Pharmacy"; // e.g., Pharmacy, Food, Toys, Equipment

    // This new property adds the specific form for pharmacy items
    public string? Form { get; set; } // e.g., Tablet, Capsule, Liquid, Injection, Ointment

    public int QuantityInStock { get; set; }
    public decimal UnitPrice { get; set; }
    public int ReorderLevel { get; set; } // Alert when stock drops to this level

    // Foreign Key to the Supplier
    public int? SupplierId { get; set; }
    public Supplier? Supplier { get; set; }
}
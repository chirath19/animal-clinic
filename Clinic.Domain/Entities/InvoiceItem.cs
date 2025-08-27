// Clinic.Domain/Entities/InvoiceItem.cs

namespace Clinic.Domain.Entities;

public class InvoiceItem : AuditableEntity
{
    public string Description { get; set; } = string.Empty; // e.g., "Annual Vaccination", "Apoquel 16mg"
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice => Quantity * UnitPrice;

    // Foreign Key to the Invoice
    public int InvoiceId { get; set; }
    public Invoice Invoice { get; set; } = null!;

    // Optional: Link to a specific product sold from inventory
    public int? InventoryItemId { get; set; }
    public InventoryItem? InventoryItem { get; set; }
}
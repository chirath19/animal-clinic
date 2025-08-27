// Clinic.Domain/Entities/Supplier.cs

namespace Clinic.Domain.Entities;

public class Supplier : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string ContactPerson { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();
}
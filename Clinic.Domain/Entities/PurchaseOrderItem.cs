// Clinic.Domain/Entities/PurchaseOrderItem.cs

namespace Clinic.Domain.Entities;

public class PurchaseOrderItem : AuditableEntity
{
    public int QuantityOrdered { get; set; }
    public decimal CostPerItem { get; set; }

    // Foreign Key to the PurchaseOrder
    public int PurchaseOrderId { get; set; }
    public PurchaseOrder PurchaseOrder { get; set; } = null!;

    // Foreign Key to the InventoryItem
    public int InventoryItemId { get; set; }
    public InventoryItem InventoryItem { get; set; } = null!;
}
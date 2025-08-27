// Clinic.Domain/Entities/PurchaseOrder.cs

namespace Clinic.Domain.Entities;

public class PurchaseOrder : AuditableEntity
{
    public DateTime OrderDate { get; set; }
    public DateTime? ExpectedDeliveryDate { get; set; }
    public DateTime? ActualDeliveryDate { get; set; }
    public string Status { get; set; } = "Ordered";
    public decimal TotalCost { get; set; }

    // Add these two properties
    public decimal PaidAmount { get; set; }
    public decimal BalanceDue => TotalCost - PaidAmount;

    // Foreign Key to the Supplier
    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; } = null!;

    public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();
}
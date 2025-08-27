namespace Clinic.Web.ViewModels;

public class InventoryItemViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? Form { get; set; } // Add this property
    public int QuantityInStock { get; set; }
    public decimal UnitPrice { get; set; }
    public int ReorderLevel { get; set; }
    public int? SupplierId { get; set; }
}
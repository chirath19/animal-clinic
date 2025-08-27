namespace Clinic.Web.ViewModels;

public class AddInvoiceItemViewModel
{
    public int? InventoryItemId { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Quantity { get; set; } = 1;
    public decimal UnitPrice { get; set; }
}
namespace Clinic.Web.ViewModels;

public class PrescriptionViewModel
{
    public int? InventoryItemId { get; set; }
    public string MedicationName { get; set; } = string.Empty;
    public string Dosage { get; set; } = string.Empty;
    public int Quantity { get; set; } = 1;
    public string Instructions { get; set; } = string.Empty;
}
using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class EditPrescriptionViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Medication name is required.")]
    public string MedicationName { get; set; } = string.Empty;

    public int? InventoryItemId { get; set; }

    [Required] public string Dosage { get; set; } = string.Empty;

    public int Quantity { get; set; } = 1;

    public string Instructions { get; set; } = string.Empty;

    public string? Form { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class EditMedicationAdminViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please select the surgical service.")]
    public int? ServiceId { get; set; }

    [Required(ErrorMessage = "Medication name is required.")]
    public string MedicationName { get; set; } = string.Empty;

    public int? InventoryItemId { get; set; }

    [Required] public string DosageAdministered { get; set; } = string.Empty;
}
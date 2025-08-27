using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class AddVaccinationViewModel
{
    [Required(ErrorMessage = "Please select the surgical service.")]
    public int? ServiceId { get; set; }

    [Required(ErrorMessage = "Vaccine name is required.")]
    public string VaccineName { get; set; } = string.Empty;

    public int? InventoryItemId { get; set; }

    public string BatchNumber { get; set; } = string.Empty;

    public DateTime DateAdministered { get; set; } = DateTime.Today;

    public DateTime NextDueDate { get; set; } = DateTime.Today.AddYears(1);
}
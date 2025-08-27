using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class EditVaccinationViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please select the surgical service.")]
    public int? ServiceId { get; set; }

    [Required(ErrorMessage = "Vaccine name is required.")]
    public string VaccineName { get; set; } = string.Empty;

    public int? InventoryItemId { get; set; }

    public string BatchNumber { get; set; } = string.Empty;

    public DateTime DateAdministered { get; set; }

    public DateTime NextDueDate { get; set; }
}
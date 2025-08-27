using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class AddMedicalRecordViewModel
{
    [Required(ErrorMessage = "An assessment or diagnosis is required.")]
    public string Assessment { get; set; } = string.Empty;

    public string Subjective { get; set; } = string.Empty;
    public string Objective { get; set; } = string.Empty;
    public string Plan { get; set; } = string.Empty;

    // Checkboxes for the initial creation
    public bool RequiresPrescription { get; set; }
    public bool RequiresVaccination { get; set; }
    public bool RequiresMedicationAdmin { get; set; }
    public bool RequiresSurgery { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class EditMedicalRecordViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "An assessment or diagnosis is required.")]
    public string Assessment { get; set; } = string.Empty;

    public string Subjective { get; set; } = string.Empty;
    public string Objective { get; set; } = string.Empty;
    public string Plan { get; set; } = string.Empty;

    // We include these to show them in the UI, even if they aren't editable
    public bool RequiresPrescription { get; set; }
    public bool RequiresVaccination { get; set; }
    public bool RequiresMedicationAdmin { get; set; }
    public bool RequiresSurgery { get; set; }
}
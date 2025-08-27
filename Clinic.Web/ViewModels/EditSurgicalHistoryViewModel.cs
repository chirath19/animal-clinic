using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class EditSurgicalHistoryViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please select the surgical service.")]
    public int? ServiceId { get; set; }

    [Required] public string ProcedureName { get; set; } = string.Empty;

    public DateTime SurgeryDate { get; set; }

    public string Notes { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a surgeon.")]
    public int? StaffId { get; set; }
}
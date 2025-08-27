// Clinic.Web/ViewModels/CreateAppointmentViewModel.cs

using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class CreateAppointmentViewModel
{
    [Required(ErrorMessage = "Please select a client.")]
    public int? ClientId { get; set; }

    [Required(ErrorMessage = "Please select a pet.")]
    public int? AnimalId { get; set; }

    [Required(ErrorMessage = "Please select a staff member.")]
    public int? StaffId { get; set; }

    [Required] public DateTime AppointmentDateTime { get; set; } = DateTime.Now;

    [Required] public string Reason { get; set; } = string.Empty;
}
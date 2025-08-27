// Clinic.Web/ViewModels/EditStaffViewModel.cs

using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class EditStaffViewModel
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;

    [Required] public string FirstName { get; set; } = string.Empty;

    [Required] public string LastName { get; set; } = string.Empty;

    [Required] public string Role { get; set; } = string.Empty;
}
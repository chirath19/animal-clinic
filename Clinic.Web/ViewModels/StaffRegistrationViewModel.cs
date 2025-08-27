using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class StaffRegistrationViewModel
{
    [Required] public string FirstName { get; set; } = string.Empty;

    [Required] public string LastName { get; set; } = string.Empty;

    [Required] [EmailAddress] public string Email { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = "Staff123!"; // Default password

    [Required] public string Role { get; set; } = "Veterinarian"; // Default role
}
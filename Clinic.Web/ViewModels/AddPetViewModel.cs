// Clinic.Web/ViewModels/AddPetViewModel.cs

using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class AddPetViewModel
{
    [Required] public string Name { get; set; } = string.Empty;

    [Required] public string Species { get; set; } = string.Empty;

    [Required] public string Breed { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; } = DateTime.Today;
}
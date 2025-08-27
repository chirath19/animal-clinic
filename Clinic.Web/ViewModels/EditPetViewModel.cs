// Clinic.Web/ViewModels/EditPetViewModel.cs

using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class EditPetViewModel
{
    public int Id { get; set; }

    [Required] public string Name { get; set; } = string.Empty;

    [Required] public string Species { get; set; } = string.Empty;

    [Required] public string Breed { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; } = DateTime.Today;
}
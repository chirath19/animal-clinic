using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class ServiceCategoryViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Category name is required.")]
    public string Name { get; set; } = string.Empty;
}
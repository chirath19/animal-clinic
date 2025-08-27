using System.ComponentModel.DataAnnotations;

namespace Clinic.Web.ViewModels;

public class ServiceViewModel
{
    public int Id { get; set; }

    [Required] public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    [Required]
    [Range(0, (double)decimal.MaxValue)]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Please select a category.")]
    public int? ServiceCategoryId { get; set; }
}
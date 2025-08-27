using System.ComponentModel.DataAnnotations;

namespace Clinic.Domain.Entities;

public class Service : AuditableEntity
{
    [Required] public string Name { get; set; } = string.Empty; // e.g., "Canine Spay - Medium Dog (20-40kg)"

    public string? Description { get; set; }

    [Required]
    [Range(0, (double)decimal.MaxValue)]
    public decimal Price { get; set; }

    // This creates the link to the new category table
    public int ServiceCategoryId { get; set; }
    public ServiceCategory ServiceCategory { get; set; } = null!;
}
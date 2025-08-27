using System.ComponentModel.DataAnnotations;

namespace Clinic.Domain.Entities;

public class ServiceCategory : AuditableEntity
{
    [Required] public string Name { get; set; } = string.Empty;

    // A category can contain many services
    public ICollection<Service> Services { get; set; } = new List<Service>();
}
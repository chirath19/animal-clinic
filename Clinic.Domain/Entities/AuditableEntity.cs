// Clinic.Domain/Entities/AuditableEntity.cs

namespace Clinic.Domain.Entities;

public abstract class AuditableEntity
{
    public virtual int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}
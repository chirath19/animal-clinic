// Clinic.Domain/Entities/SurgicalHistory.cs

namespace Clinic.Domain.Entities;

public class SurgicalHistory : AuditableEntity
{
    public string ProcedureName { get; set; } = string.Empty; // e.g., "Spay", "ACL Repair"
    public DateTime SurgeryDate { get; set; }
    public string Notes { get; set; } = string.Empty; // Outcome, complications, etc.

    // Foreign Key to the Animal
    public int AnimalId { get; set; }
    public Animal Animal { get; set; } = null!;

    public int StaffId { get; set; }
    public Staff Staff { get; set; } = null!;

    // This new link connects the surgery to a specific visit/medical record
    public int MedicalRecordId { get; set; }
    public MedicalRecord MedicalRecord { get; set; } = null!;

    public int ServiceId { get; set; }
    public Service Service { get; set; } = null!;
}
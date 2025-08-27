// Clinic.Domain/Entities/MedicationAdministration.cs

namespace Clinic.Domain.Entities;

public class MedicationAdministration : AuditableEntity
{
    // This new property will store the drug name
    public string MedicationName { get; set; } = string.Empty;

    public DateTime DateTimeAdministered { get; set; }
    public string DosageAdministered { get; set; } = string.Empty;

    // The link to InventoryItem is now OPTIONAL
    public int? InventoryItemId { get; set; }
    public InventoryItem? InventoryItem { get; set; }

    // Foreign Key to the administering Staff member
    public int StaffId { get; set; }
    public Staff Staff { get; set; } = null!;

    // Foreign key to the Medical Record for this visit
    public int MedicalRecordId { get; set; }
    public MedicalRecord MedicalRecord { get; set; } = null!;

    public int ServiceId { get; set; }
    public Service Service { get; set; } = null!;
}
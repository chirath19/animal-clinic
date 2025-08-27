// Clinic.Domain/Entities/Prescription.cs

namespace Clinic.Domain.Entities;

public class Prescription : AuditableEntity
{
    // This new property will store the drug name, e.g., "Amoxicillin 250mg"
    public string MedicationName { get; set; } = string.Empty;

    public DateTime DatePrescribed { get; set; }
    public string Dosage { get; set; } = string.Empty; // e.g., "1 tablet twice daily"
    public int Quantity { get; set; }
    public string Instructions { get; set; } = string.Empty;

    public string? Form { get; set; }

    // Foreign Key to the Animal
    public int AnimalId { get; set; }
    public Animal Animal { get; set; } = null!;

    public int? MedicalRecordId { get; set; }
    public MedicalRecord? MedicalRecord { get; set; }

    // The link to InventoryItem is now OPTIONAL
    public int? InventoryItemId { get; set; }
    public InventoryItem? InventoryItem { get; set; }

    // Foreign Key to the prescribing Staff member
    public int StaffId { get; set; }
    public Staff Staff { get; set; } = null!;
}
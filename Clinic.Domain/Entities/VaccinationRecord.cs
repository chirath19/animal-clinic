// Clinic.Domain/Entities/VaccinationRecord.cs

namespace Clinic.Domain.Entities;

public class VaccinationRecord : AuditableEntity
{
    public string VaccineName { get; set; } = string.Empty; // e.g., "Rabies", "DHPP"
    public DateTime DateAdministered { get; set; }
    public DateTime NextDueDate { get; set; }
    public string BatchNumber { get; set; } = string.Empty;

    // Foreign Key to the Animal
    public int AnimalId { get; set; }
    public Animal Animal { get; set; } = null!;

    // Foreign Key to the administering Staff member
    public int StaffId { get; set; }

    public Staff Staff { get; set; } = null!;

    // Add this optional link to the inventory
    public int? InventoryItemId { get; set; }
    public InventoryItem? InventoryItem { get; set; }

    public int ServiceId { get; set; }
    public Service Service { get; set; } = null!;
}
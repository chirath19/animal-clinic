// Clinic.Domain/Entities/Animal.cs
namespace Clinic.Domain.Entities;

public class Animal : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Species { get; set; } = string.Empty; // e.g., "Dog", "Cat"
    public string Breed { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public double Weight { get; set; } // For dosage calculations
    public string Color { get; set; } = string.Empty;
    public string IdentifyingMarks { get; set; } = string.Empty;

    // Critical Information for quick access
    public string? Allergies { get; set; } // Comma-separated list or structured data
    public string? ChronicConditions { get; set; } // Comma-separated list

    // This creates the relationship to the Client
    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;

    // Add collections for related data
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    public ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    public ICollection<VaccinationRecord> VaccinationRecords { get; set; } = new List<VaccinationRecord>();
    public ICollection<SurgicalHistory> SurgicalHistories { get; set; } = new List<SurgicalHistory>();
}
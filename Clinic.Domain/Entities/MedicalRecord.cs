// Clinic.Domain/Entities/MedicalRecord.cs
using System.ComponentModel.DataAnnotations;

namespace Clinic.Domain.Entities;

public class MedicalRecord : AuditableEntity
{
    public DateTime RecordDate { get; set; }
    public string Subjective { get; set; } = string.Empty;
    public string Objective { get; set; } = string.Empty;

    [Required(ErrorMessage = "An assessment or diagnosis is required.")]
    public string Assessment { get; set; } = string.Empty;

    public string Plan { get; set; } = string.Empty;

    public string Status { get; set; } = "Draft";
    public bool RequiresPrescription { get; set; }
    public bool RequiresVaccination { get; set; }
    public bool RequiresMedicationAdmin { get; set; }
    public bool RequiresSurgery { get; set; }

    // Foreign Keys and Navigation Properties
    public int AnimalId { get; set; }
    public Animal Animal { get; set; } = null!;
    public int StaffId { get; set; }
    public Staff Staff { get; set; } = null!;
    public int? AppointmentId { get; set; }
    public Appointment? Appointment { get; set; }
    public ICollection<MedicationAdministration> Administrations { get; set; } = new List<MedicationAdministration>();
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    public ICollection<SurgicalHistory> SurgicalHistories { get; set; } = new List<SurgicalHistory>();
}
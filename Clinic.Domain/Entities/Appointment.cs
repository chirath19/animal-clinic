namespace Clinic.Domain.Entities;

public class Appointment : AuditableEntity
{
    public DateTime AppointmentDateTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Status { get; set; } = "Scheduled";

    // This new property links the appointment to a specific service
    public int ServiceId { get; set; }
    public Service Service { get; set; } = null!;

    // Foreign Key to the Animal
    public int AnimalId { get; set; }
    public Animal Animal { get; set; } = null!;

    // Foreign Key to the Client
    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;

    // Foreign Key to the Staff member (Vet/Tech)
    public int StaffId { get; set; }
    public Staff Staff { get; set; } = null!;

    // An appointment can result in one medical record
    public MedicalRecord? MedicalRecord { get; set; }
    public string? Reason { get; set; }

    // An appointment can generate one or more invoices
    public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
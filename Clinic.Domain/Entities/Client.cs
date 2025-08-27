namespace Clinic.Domain.Entities;

public class Client : AuditableEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;

    // Link to the Identity User ID (the domain does not know the full user object)
    public string? ApplicationUserId { get; set; }

    public ICollection<Animal> Animals { get; set; } = new List<Animal>();
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
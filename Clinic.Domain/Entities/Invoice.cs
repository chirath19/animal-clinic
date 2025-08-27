namespace Clinic.Domain.Entities;

public class Invoice : AuditableEntity
{
    public DateTime InvoiceDate { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal PaidAmount { get; set; }
    public string Status { get; set; } = "Unpaid";

    public decimal BalanceDue => TotalAmount - PaidAmount;

    // Foreign Key to the Client
    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;

    // The link back to an appointment is OPTIONAL
    public int? AppointmentId { get; set; }
    public Appointment? Appointment { get; set; }

    public ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
}
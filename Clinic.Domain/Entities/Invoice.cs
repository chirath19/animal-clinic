using System.ComponentModel.DataAnnotations;
using Clinic.Domain.Entities;

public class Invoice : AuditableEntity
{
    [Required]
    public DateTime InvoiceDate { get; set; }

    [Required]
    public decimal TotalAmount { get; set; }

    public decimal PaidAmount { get; set; }

    [Required]
    public string Status { get; set; } = "Unpaid"; // Tracks payment: Unpaid, Partially Paid, Paid

    [Required]
    public string InvoiceType { get; set; } = string.Empty; // Tracks purpose: Consultation, Visit, SingleBill

    public decimal BalanceDue => TotalAmount - PaidAmount;

    // Foreign Keys
    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;
    public int? AppointmentId { get; set; }
    public Appointment? Appointment { get; set; }

    // Navigation Property
    public ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
}
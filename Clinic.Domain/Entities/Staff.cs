// Clinic.Domain/Entities/Staff.cs

namespace Clinic.Domain.Entities;

public class Staff : AuditableEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string FullName => $"{FirstName} {LastName}";
    public string Role { get; set; } = string.Empty; // e.g., "Veterinarian", "Technician", "Receptionist"
    public string? ApplicationUserId { get; set; } // Link to the ASP.NET Core Identity user
}
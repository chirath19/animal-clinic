using Clinic.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Clinic.Common;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    // Navigation properties to domain entities
    public virtual Staff? Staff { get; set; }
    public virtual Client? Client { get; set; }
}
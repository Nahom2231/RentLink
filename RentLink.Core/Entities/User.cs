namespace RentLink.Core.Entities;

using Microsoft.AspNetCore.Identity;
using RentLink.Core.Enums;

public class User : IdentityUser<Guid>
{
    public string FullName { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public string? NationalIdNumber { get; set; }
    public bool IsVerified { get; set; } = false;
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public ICollection<Property> Properties { get; set; } = new List<Property>();
    public ICollection<LeaseAgreement> RenterLeases { get; set; } = new List<LeaseAgreement>();
}

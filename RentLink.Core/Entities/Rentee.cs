namespace RentLink.Core.Entities;

public class Rentee
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public string? CurrentAddress { get; set; }
    public string? EmergencyContactName { get; set; }
    public string? EmergencyContactPhone { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public ICollection<LeaseAgreement> LeaseAgreements { get; set; } = new List<LeaseAgreement>();
}

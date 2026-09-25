namespace RentLink.Core.Entities;

public class Renter
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public string? EmployerName { get; set; }
    public decimal MonthlyIncome { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public ICollection<LeaseAgreement> LeaseAgreements { get; set; } = new List<LeaseAgreement>();
}

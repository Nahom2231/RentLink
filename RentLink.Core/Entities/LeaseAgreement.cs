namespace RentLink.Core.Entities;

using RentLink.Core.Enums;

public class LeaseAgreement
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PropertyId { get; set; }
    public Property Property { get; set; } = null!;
    public Guid LandLordId { get; set; }
    public User Landlord { get; set; } = null!;
    public Guid RenterId { get; set; }
    public User Renter { get; set; } = null!;

    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public decimal AgreedMonthlyRent { get; set; }
    public decimal AgreedSecurityDeposit { get; set; }
    public LeaseStatus Status { get; set; } = LeaseStatus.PendingLandlordSignature;
    public string? LandlordSignatureData { get; set; }
    public DateTime? LandlordSignedAtUtc { get; set; }
    public string? RenterSignatureData { get; set; }
    public DateTime? RenterSignedAtUtc { get; set; }
    public string ContractTermsJson { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public ICollection<PaymentRecord> Payments { get; set; } = new List<PaymentRecord>();
    public ICollection<ConditionInspection> Inspections { get; set; } = new List<ConditionInspection>();
    public ICollection<MaintenanceTicket> MaintenanceTickets { get; set; } = new List<MaintenanceTicket>();
}

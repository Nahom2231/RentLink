namespace RentLink.Core.Entities;

using RentLink.Core.Enums;

public class PaymentRecord
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid LeaseAgreementId { get; set; }
    public LeaseAgreement LeaseAgreement { get; set; } = null!;

    public decimal Amount { get; set; }
    public string Currency { get; set; } = "ETB";
    public string PaymentReference { get; set; } = string.Empty;
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
    public DateOnly RentPeriodMonth { get; set; }
    public DateTime PaidAtUtc { get; set; } = DateTime.UtcNow;

    public decimal EstimatedRentalTax { get; set; }
    public bool IsReportedToTaxAuthority { get; set; } = false;
}

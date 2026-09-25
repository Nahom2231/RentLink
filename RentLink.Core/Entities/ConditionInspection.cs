namespace RentLink.Core.Entities;

using RentLink.Core.Enums;

public class ConditionInspection
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid LeaseAgreementId { get; set; }
    public LeaseAgreement LeaseAgreement { get; set; } = null!;

    public InspectionType Type { get; set; }
    public DateTime InspectionDateUtc { get; set; } = DateTime.UtcNow;
    public string ChecklistItemsJson { get; set; } = "[]";
    public bool ApprovedByLandlord { get; set; } = false;
    public bool ApprovedByRenter { get; set; } = false;
    public string? Notes { get; set; }
}

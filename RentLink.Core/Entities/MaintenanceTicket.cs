namespace RentLink.Core.Entities;

using RentLink.Core.Enums;

public class MaintenanceTicket
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid LeaseAgreementId { get; set; }
    public LeaseAgreement LeaseAgreement { get; set; } = null!;

    public Guid CreatedById { get; set; }
    public User CreatedBy { get; set; } = null!;

    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> AttachmentUrls { get; set; } = new();
    public TicketStatus Status { get; set; } = TicketStatus.Open;

    public bool IsEscalated { get; set; } = false;
    public string? EscalationReason { get; set; }
    public DateTime? EscalatedAtUtc { get; set; }
    public string? RegulatorResolutionNotes { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
}

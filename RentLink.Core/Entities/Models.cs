namespace RentLink.Core.Entities;

using RentLink.Core.Enums;

public class User
{
    public Guid Id {get; set;} = Guid.NewGuid();
    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; }=string.Empty;

    public string PhoneNumber { get; set; }= string.Empty;

    public string PasswordHash {get; set;} =string.Empty;

    public UserRole Role { get; set;} 

    public string? NationalIdNumber { get; set; }

    public bool IsVerified { get; set;} =false;

    public DateTime CreatedAtUtc { get; set;} = DateTime.UtcNow;

    public ICollection<Property> Properties { get; set; } = new List<Property>();
    
    public ICollection<LeaseAgreement> RenterLeases { get; set; } =new List<LeaseAgreement>();
}

public class Property
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid LandlordId { get; set; }

    public User Landlord { get; set; }= null!;

    public string Title { get; set; } =string.Empty;

    public string Description { get; set;} = string.Empty;

    public string City { get; set;}= "AddisAbaba";

    public string Subcity { get; set;}= string.Empty;

    public string Kebele { get; set;}= string.Empty;

    public string? HouseNumber { get; set;}

    public decimal MonthlyRent { get; set;}

    public decimal SecurityDeposit { get; set;}

    public int Bedrooms {get; set;}

    public int Bathrooms { get; set;}

    public PropertyStatus Status { get; set; }= PropertyStatus.Available;

    public List<string> ImageUrls { get; set; } = new();

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public ICollection<LeaseAgreement> Leases { get; set; } = new List<LeaseAgreement>();

}

public class LeaseAgreement
{
    public Guid Id { get; set; }= Guid.NewGuid();

    public Guid PropertyId { get; set; }
     
    public Guid LandLordId { get; set;}
    
    public User Landlord { get; set; } = null!;

    public Guid RenterId {get; set; }

    public User Renter { get; set; } = null!;


public DateOnly StartDate { get; set; }

public DateOnly EndDate { get; set; }

public decimal AgreedMonthlyRent { get; set;}

public decimal AgreedSecurityDeposit { get; set;}

public LeaseStatus Status {get; set;} = LeaseStatus.PendingLandlordSignature;

public string? LandlordSignatureData { get; set;}

public DateTime? LandlordSignedAtUtc { get; set; }

public string? RenterSignatureData { get; set; }
    public DateTime? RenterSignedAtUtc { get; set; }
    public string ContractTermsJson { get; set; } = string.Empty;

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public ICollection<PaymentRecord> Payments { get; set; } = new List<PaymentRecord>();
    public ICollection<ConditionInspection> Inspections { get; set; } = new List<ConditionInspection>();
    public ICollection<MaintenanceTicket> MaintenanceTickets { get; set; } = new List<MaintenanceTicket>();
}

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



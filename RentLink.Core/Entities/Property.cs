namespace RentLink.Core.Entities;

using RentLink.Core.Enums;

public class Property
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid LandlordId { get; set; }
    public User Landlord { get; set; } = null!;

    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string City { get; set; } = "AddisAbaba";
    public string Subcity { get; set; } = string.Empty;
    public string Kebele { get; set; } = string.Empty;
    public string? HouseNumber { get; set; }

    public decimal MonthlyRent { get; set; }
    public decimal SecurityDeposit { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public PropertyStatus Status { get; set; } = PropertyStatus.Available;
    public List<string> ImageUrls { get; set; } = new();
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public ICollection<LeaseAgreement> Leases { get; set; } = new List<LeaseAgreement>();
}

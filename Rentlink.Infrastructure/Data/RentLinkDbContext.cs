namespace RentLink.Infrastructure.Data;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentLink.Core.Entities;
using RentLink.Infrastructure.Data.Configurations;

public class RentLinkDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    public RentLinkDbContext(DbContextOptions<RentLinkDbContext> options)
        : base(options)
    {
    }

    public DbSet<Property> Properties => Set<Property>();
    public DbSet<LeaseAgreement> LeaseAgreements => Set<LeaseAgreement>();
    public DbSet<ConditionInspection> ConditionInspections => Set<ConditionInspection>();
    public DbSet<PaymentRecord> PaymentRecords => Set<PaymentRecord>();
    public DbSet<MaintenanceTicket> MaintenanceTickets => Set<MaintenanceTicket>();
    public DbSet<Renter> Renters => Set<Renter>();
    public DbSet<Rentee> RentersList => Set<Rentee>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new PropertyConfiguration());
        builder.ApplyConfiguration(new LeaseAgreementConfiguration());
        builder.ApplyConfiguration(new ConditionInspectionConfiguration());
        builder.ApplyConfiguration(new PaymentRecordConfiguration());
        builder.ApplyConfiguration(new MaintenanceTicketConfiguration());
        builder.ApplyConfiguration(new RenterConfiguration());
        builder.ApplyConfiguration(new RenteeConfiguration());
    }
}

namespace RentLink.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentLink.Core.Entities;

public class LeaseAgreementConfiguration : IEntityTypeConfiguration<LeaseAgreement>
{
    public void Configure(EntityTypeBuilder<LeaseAgreement> builder)
    {
        builder.ToTable("LeaseAgreements");

        builder.HasKey(l => l.Id);

        builder.Property(l => l.AgreedMonthlyRent)
            .HasColumnType("decimal(18,2)");

        builder.Property(l => l.AgreedSecurityDeposit)
            .HasColumnType("decimal(18,2)");

        builder.Property(l => l.ContractTermsJson)
            .HasColumnType("jsonb");

        builder.HasOne(l => l.Property)
            .WithMany(p => p.Leases)
            .HasForeignKey(l => l.PropertyId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(l => l.Landlord)
            .WithMany()
            .HasForeignKey(l => l.LandLordId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(l => l.Renter)
            .WithMany()
            .HasForeignKey(l => l.RenterId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(l => l.Payments)
            .WithOne(p => p.LeaseAgreement)
            .HasForeignKey(p => p.LeaseAgreementId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(l => l.Inspections)
            .WithOne(i => i.LeaseAgreement)
            .HasForeignKey(i => i.LeaseAgreementId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(l => l.MaintenanceTickets)
            .WithOne(m => m.LeaseAgreement)
            .HasForeignKey(m => m.LeaseAgreementId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

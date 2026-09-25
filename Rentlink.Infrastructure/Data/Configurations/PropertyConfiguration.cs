namespace RentLink.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentLink.Core.Entities;

public class PropertyConfiguration : IEntityTypeConfiguration<Property>
{
    public void Configure(EntityTypeBuilder<Property> builder)
    {
        builder.ToTable("Properties");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.Description)
            .IsRequired();

        builder.Property(p => p.City)
            .HasMaxLength(100)
            .HasDefaultValue("AddisAbaba");

        builder.Property(p => p.Subcity)
            .HasMaxLength(100);

        builder.Property(p => p.Kebele)
            .HasMaxLength(100);

        builder.Property(p => p.MonthlyRent)
            .HasColumnType("decimal(18,2)");

        builder.Property(p => p.SecurityDeposit)
            .HasColumnType("decimal(18,2)");

        builder.HasMany(p => p.Leases)
            .WithOne(l => l.Property)
            .HasForeignKey(l => l.PropertyId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

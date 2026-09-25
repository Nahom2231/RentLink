namespace RentLink.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentLink.Core.Entities;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.Property(u => u.FullName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(u => u.Role)
            .IsRequired();

        builder.Property(u => u.NationalIdNumber)
            .HasMaxLength(50);

        builder.Property(u => u.PhoneNumber)
            .HasMaxLength(30);

        builder.Property(u => u.CreatedAtUtc)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.HasMany(u => u.Properties)
            .WithOne(p => p.Landlord)
            .HasForeignKey(p => p.LandlordId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.RenterLeases)
            .WithOne(l => l.Renter)
            .HasForeignKey(l => l.RenterId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

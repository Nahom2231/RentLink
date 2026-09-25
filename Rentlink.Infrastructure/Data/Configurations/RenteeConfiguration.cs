namespace RentLink.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentLink.Core.Entities;

public class RenteeConfiguration : IEntityTypeConfiguration<Rentee>
{
    public void Configure(EntityTypeBuilder<Rentee> builder)
    {
        builder.ToTable("RentersList");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.CurrentAddress)
            .HasMaxLength(500);

        builder.Property(r => r.EmergencyContactName)
            .HasMaxLength(200);

        builder.Property(r => r.EmergencyContactPhone)
            .HasMaxLength(30);

        builder.HasOne(r => r.User)
            .WithMany()
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

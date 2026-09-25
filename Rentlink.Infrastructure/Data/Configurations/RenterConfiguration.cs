namespace RentLink.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentLink.Core.Entities;

public class RenterConfiguration : IEntityTypeConfiguration<Renter>
{
    public void Configure(EntityTypeBuilder<Renter> builder)
    {
        builder.ToTable("Renters");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.EmployerName)
            .HasMaxLength(200);

        builder.Property(r => r.MonthlyIncome)
            .HasColumnType("decimal(18,2)");

        builder.HasOne(r => r.User)
            .WithMany()
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

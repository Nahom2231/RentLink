namespace RentLink.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentLink.Core.Entities;

public class ConditionInspectionConfiguration : IEntityTypeConfiguration<ConditionInspection>
{
    public void Configure(EntityTypeBuilder<ConditionInspection> builder)
    {
        builder.ToTable("ConditionInspections");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.ChecklistItemsJson)
            .HasColumnType("jsonb");

        builder.Property(c => c.Notes)
            .HasMaxLength(2000);
    }
}

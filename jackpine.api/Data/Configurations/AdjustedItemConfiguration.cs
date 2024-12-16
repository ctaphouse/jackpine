using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AdjustedItemConfiguration : IEntityTypeConfiguration<AdjustedItem>
{
    public void Configure(EntityTypeBuilder<AdjustedItem> builder)
    {
        builder.ToTable("AdjustedItem"); // Map to table

        builder.HasKey(ai => ai.Id);

        builder.Property(ai => ai.Measurement)
            .HasMaxLength(50);

        builder.Property(ai => ai.GramEquivalent).IsRequired(false);

        builder.HasOne(ai => ai.Item)
            .WithMany(i => i.AdjustedItems)
            .HasForeignKey(ai => ai.ItemId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

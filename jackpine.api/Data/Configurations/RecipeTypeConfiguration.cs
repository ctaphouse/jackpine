using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RecipeItemConfiguration : IEntityTypeConfiguration<RecipeItem>
{
    public void Configure(EntityTypeBuilder<RecipeItem> builder)
    {
        builder.ToTable("RecipeItem"); // Map to table

        builder.HasKey(ri => ri.Id);

        builder.Property(ri => ri.Measurement)
            .HasMaxLength(50);

        builder.Property(ri => ri.GramEquivalent).IsRequired(false);

        builder.HasOne(ri => ri.Recipe)
            .WithMany(r => r.RecipeItems)
            .HasForeignKey(ri => ri.RecipeId);

        builder.HasOne(ri => ri.Item)
            .WithMany(i => i.RecipeItems)
            .HasForeignKey(ri => ri.ItemId);
    }
}

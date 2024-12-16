using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.ToTable("Item"); // Map to table

        builder.HasKey(i => i.Id);

        builder.Property(i => i.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(i => i.Calories).IsRequired(false);
        builder.Property(i => i.Protein).IsRequired(false);
        builder.Property(i => i.Carbohydrates).IsRequired(false);
        builder.Property(i => i.Fiber).IsRequired(false);
        builder.Property(i => i.Sugars).IsRequired(false);
        builder.Property(i => i.Fat).IsRequired(false);

        builder.HasMany(i => i.AdjustedItems)
            .WithOne(ai => ai.Item)
            .HasForeignKey(ai => ai.ItemId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(i => i.RecipeItems)
            .WithOne(ri => ri.Item)
            .HasForeignKey(ri => ri.ItemId);
    }
}

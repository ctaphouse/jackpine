using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
{
    public void Configure(EntityTypeBuilder<Recipe> builder)
    {
        builder.ToTable("Recipe"); // Map to table

        builder.HasKey(r => r.Id);

        builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(r => r.Servings).IsRequired(false);

        builder.HasMany(r => r.RecipeItems)
            .WithOne(ri => ri.Recipe)
            .HasForeignKey(ri => ri.RecipeId);

        builder.HasMany(r => r.AdjustedRecipes)
            .WithOne(ar => ar.Recipe)
            .HasForeignKey(ar => ar.RecipeId);
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AdjustedRecipeConfiguration : IEntityTypeConfiguration<AdjustedRecipe>
{
    public void Configure(EntityTypeBuilder<AdjustedRecipe> builder)
    {
        builder.ToTable("AdjustedRecipe"); // Map to table

        builder.HasKey(ar => ar.Id);

        builder.Property(ar => ar.Measurement)
            .HasMaxLength(50);

        builder.Property(ar => ar.Servings).IsRequired(false);

        builder.HasOne(ar => ar.Recipe)
            .WithMany(r => r.AdjustedRecipes)
            .HasForeignKey(ar => ar.RecipeId);
    }
}

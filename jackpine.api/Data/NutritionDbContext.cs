using Microsoft.EntityFrameworkCore;

public class NutritionDbContext : DbContext
{
    public DbSet<ItemType> ItemTypes { get; set; } = null!;
    public DbSet<Item> Items { get; set; } = null!;
    public DbSet<AdjustedItem> AdjustedItems { get; set; } = null!;
    public DbSet<Recipe> Recipes { get; set; } = null!;
    public DbSet<RecipeItem> RecipeItems { get; set; } = null!;
    public DbSet<AdjustedRecipe> AdjustedRecipes { get; set; } = null!;

    public NutritionDbContext(DbContextOptions<NutritionDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ItemTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ItemConfiguration());
        modelBuilder.ApplyConfiguration(new AdjustedItemConfiguration());
        modelBuilder.ApplyConfiguration(new RecipeConfiguration());
        modelBuilder.ApplyConfiguration(new RecipeItemConfiguration());
        modelBuilder.ApplyConfiguration(new AdjustedRecipeConfiguration());
    }
}

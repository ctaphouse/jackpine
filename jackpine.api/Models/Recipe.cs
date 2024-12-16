public class Recipe
{
    public int Id { get; set; } // Primary Key
    public string Name { get; set; } = null!; // Required
    public int? Servings { get; set; }

    public ICollection<RecipeItem> RecipeItems { get; set; } = new List<RecipeItem>();
    public ICollection<AdjustedRecipe> AdjustedRecipes { get; set; } = new List<AdjustedRecipe>();
}

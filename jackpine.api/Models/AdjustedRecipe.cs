public class AdjustedRecipe
{
    public int Id { get; set; } // Primary Key
    public int RecipeId { get; set; } // Foreign Key
    public string? Measurement { get; set; } // Optional
    public int? Servings { get; set; }

    public Recipe Recipe { get; set; } = null!;
}

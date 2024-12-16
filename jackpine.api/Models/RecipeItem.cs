public class RecipeItem
{
    public int Id { get; set; } // Primary Key
    public int RecipeId { get; set; } // Foreign Key
    public int ItemId { get; set; } // Foreign Key
    public string? Measurement { get; set; } // Optional
    public double? GramEquivalent { get; set; } // Optional

    public Recipe Recipe { get; set; } = null!;
    public Item Item { get; set; } = null!;
}

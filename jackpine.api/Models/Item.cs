public class Item
{
    public int Id { get; set; } // Primary Key
    public string Name { get; set; } = null!; // Required
    public int? Calories { get; set; }
    public double? Protein { get; set; }
    public double? Carbohydrates { get; set; }
    public double? Fiber { get; set; }
    public double? Sugars { get; set; }
    public double? Fat { get; set; }

    public int ItemTypeId { get; set; } // Foreign Key
    public ItemType ItemType { get; set; } = null!; // Navigation property

    public ICollection<AdjustedItem> AdjustedItems { get; set; } = new List<AdjustedItem>();
    public ICollection<RecipeItem> RecipeItems { get; set; } = new List<RecipeItem>();
}

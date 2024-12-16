public class AdjustedItem
{
    public int Id { get; set; } // Primary Key
    public int ItemId { get; set; } // Foreign Key
    public string? Measurement { get; set; } // Optional
    public double? GramEquivalent { get; set; } // Optional

    public Item Item { get; set; } = null!; // Navigation property
}

public class ItemType
{
    public int Id { get; set; } // Primary Key
    public string Name { get; set; } = null!; // Required

    // Navigation property for related Items
    public ICollection<Item> Items { get; set; } = new List<Item>();
}

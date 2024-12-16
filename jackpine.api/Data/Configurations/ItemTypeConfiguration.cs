using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ItemTypeConfiguration : IEntityTypeConfiguration<ItemType>
{
    public void Configure(EntityTypeBuilder<ItemType> builder)
    {
        builder.ToTable("ItemType"); // Map to table

        builder.HasKey(it => it.Id);

        builder.Property(it => it.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasMany(it => it.Items)
            .WithOne(i => i.ItemType)
            .HasForeignKey(i => i.ItemTypeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

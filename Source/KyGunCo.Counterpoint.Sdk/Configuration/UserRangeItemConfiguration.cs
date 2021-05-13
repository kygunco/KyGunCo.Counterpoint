// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_RANGE_ITEMS
    public class UserRangeItemConfiguration : IEntityTypeConfiguration<UserRangeItem>
    {
        public void Configure(EntityTypeBuilder<UserRangeItem> builder)
        {
            builder.ToTable("USER_RANGE_ITEMS", "dbo");
            builder.HasKey(x => x.ItemNo).HasName("PK_USER_RANGE_ITEMS").IsClustered();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
        }
    }

}
// </auto-generated>
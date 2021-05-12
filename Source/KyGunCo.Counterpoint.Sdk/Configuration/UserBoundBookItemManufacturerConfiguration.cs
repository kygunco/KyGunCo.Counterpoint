// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_BOUND_BOOK_ITEM_MANUFACTURER
    public class UserBoundBookItemManufacturerConfiguration : IEntityTypeConfiguration<UserBoundBookItemManufacturer>
    {
        public void Configure(EntityTypeBuilder<UserBoundBookItemManufacturer> builder)
        {
            builder.ToTable("USER_BOUND_BOOK_ITEM_MANUFACTURER", "dbo");
            builder.HasKey(x => x.UserManufacturer).HasName("PK_USER_BOUND_BOOK_ITEM_MANUFACTURER").IsClustered();

            builder.Property(x => x.UserManufacturer).HasColumnName(@"USER_MANUFACTURER").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();
        }
    }

}
// </auto-generated>

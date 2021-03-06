// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_RENTAL_AMMO
    public class UserRentalAmmoConfiguration : IEntityTypeConfiguration<UserRentalAmmo>
    {
        public void Configure(EntityTypeBuilder<UserRentalAmmo> builder)
        {
            builder.ToTable("USER_RENTAL_AMMO", "dbo");
            builder.HasKey(x => new { x.ItemNo, x.Rounds });

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.Rounds).HasColumnName(@"ROUNDS").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>

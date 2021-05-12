// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_VI_KIT_INV
    public class UserViKitInvConfiguration : IEntityTypeConfiguration<UserViKitInv>
    {
        public void Configure(EntityTypeBuilder<UserViKitInv> builder)
        {
            builder.ToView("USER_VI_KIT_INV", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.QtyAvail).HasColumnName(@"QTY_AVAIL").HasColumnType("decimal(36,0)").IsRequired(false);
            builder.Property(x => x.QtyOnHnd).HasColumnName(@"QTY_ON_HND").HasColumnType("decimal(35,0)").IsRequired(false);
            builder.Property(x => x.QtyOnPo).HasColumnName(@"QTY_ON_PO").HasColumnType("decimal(35,0)").IsRequired(false);
            builder.Property(x => x.HasFirearm).HasColumnName(@"HAS_FIREARM").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
        }
    }

}
// </auto-generated>

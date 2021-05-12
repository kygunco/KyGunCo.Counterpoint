// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_INV_CELL_DIFF
    public class ViInvCellDiffConfiguration : IEntityTypeConfiguration<ViInvCellDiff>
    {
        public void Configure(EntityTypeBuilder<ViInvCellDiff> builder)
        {
            builder.ToView("VI_INV_CELL_DIFF", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.WhatsWrong).HasColumnName(@"WHATS_WRONG").HasColumnType("varchar(21)").IsRequired().IsUnicode(false).HasMaxLength(21);
            builder.Property(x => x.InvQtyOnHnd).HasColumnName(@"INV_QTY_ON_HND").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.CalcQtyOnHnd).HasColumnName(@"CALC_QTY_ON_HND").HasColumnType("decimal(38,4)").IsRequired(false);
            builder.Property(x => x.InvMinQty).HasColumnName(@"INV_MIN_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.CalcMinQty).HasColumnName(@"CALC_MIN_QTY").HasColumnType("decimal(38,4)").IsRequired(false);
            builder.Property(x => x.InvMaxQty).HasColumnName(@"INV_MAX_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.CalcMaxQty).HasColumnName(@"CALC_MAX_QTY").HasColumnType("decimal(38,4)").IsRequired(false);
        }
    }

}
// </auto-generated>

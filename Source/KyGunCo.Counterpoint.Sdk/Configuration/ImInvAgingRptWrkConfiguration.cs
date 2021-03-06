// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_INV_AGING_RPT_WRK
    public class ImInvAgingRptWrkConfiguration : IEntityTypeConfiguration<ImInvAgingRptWrk>
    {
        public void Configure(EntityTypeBuilder<ImInvAgingRptWrk> builder)
        {
            builder.ToTable("IM_INV_AGING_RPT_WRK", "dbo");
            builder.HasKey(x => new { x.SessId, x.GrpId, x.ItemNo, x.LocId }).HasName("PK_IM_INV_AGING_RPT_WRK").IsClustered();

            builder.Property(x => x.SessId).HasColumnName(@"SESS_ID").HasColumnType("varchar(40)").IsRequired().IsUnicode(false).HasMaxLength(40).ValueGeneratedNever();
            builder.Property(x => x.GrpId).HasColumnName(@"GRP_ID").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50).ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.CostOnHnd).HasColumnName(@"COST_ON_HND").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.NegCostOnHnd).HasColumnName(@"NEG_COST_ON_HND").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.QtyOnHnd).HasColumnName(@"QTY_ON_HND").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.NegQtyOnHnd).HasColumnName(@"NEG_QTY_ON_HND").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CostAged1).HasColumnName(@"COST_AGED_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.QtyAged1).HasColumnName(@"QTY_AGED_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CostAged2).HasColumnName(@"COST_AGED_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.QtyAged2).HasColumnName(@"QTY_AGED_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CostAged3).HasColumnName(@"COST_AGED_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.QtyAged3).HasColumnName(@"QTY_AGED_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CostAged4).HasColumnName(@"COST_AGED_4").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.QtyAged4).HasColumnName(@"QTY_AGED_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CostAged5).HasColumnName(@"COST_AGED_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.QtyAged5).HasColumnName(@"QTY_AGED_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyDecs).HasColumnName(@"QTY_DECS").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>

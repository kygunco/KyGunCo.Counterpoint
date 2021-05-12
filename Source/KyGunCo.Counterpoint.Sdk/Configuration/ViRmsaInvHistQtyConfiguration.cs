// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_RMSA_INV_HIST_QTY
    public class ViRmsaInvHistQtyConfiguration : IEntityTypeConfiguration<ViRmsaInvHistQty>
    {
        public void Configure(EntityTypeBuilder<ViRmsaInvHistQty> builder)
        {
            builder.ToView("VI_RMSA_INV_HIST_QTY", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.Type).HasColumnName(@"TYPE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.FullType).HasColumnName(@"FULL_TYPE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Qty).HasColumnName(@"QTY").HasColumnType("decimal(38,14)").IsRequired(false);
            builder.Property(x => x.TrxDat).HasColumnName(@"TRX_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ExtCost).HasColumnName(@"EXT_COST").HasColumnType("decimal(21,8)").IsRequired(false);
            builder.Property(x => x.ExtRet).HasColumnName(@"EXT_RET").HasColumnType("decimal(35,8)").IsRequired(false);
            builder.Property(x => x.TotCostCorr).HasColumnName(@"TOT_COST_CORR").HasColumnType("decimal(21,8)").IsRequired(false);
            builder.Property(x => x.ExtPrc).HasColumnName(@"EXT_PRC").HasColumnType("decimal(21,8)").IsRequired(false);
            builder.Property(x => x.DocNo).HasColumnName(@"DOC_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.CategCod).HasColumnName(@"CATEG_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SubcatCod).HasColumnName(@"SUBCAT_COD").HasColumnType("varchar(21)").IsRequired(false).IsUnicode(false).HasMaxLength(21);
            builder.Property(x => x.ItemVendNo).HasColumnName(@"ITEM_VEND_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OthrLoc).HasColumnName(@"OTHR_LOC").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UnitRetl).HasColumnName(@"UNIT_RETL").HasColumnType("decimal(38,11)").IsRequired(false);
            builder.Property(x => x.UnitRegPrc).HasColumnName(@"UNIT_REG_PRC").HasColumnType("decimal(38,11)").IsRequired(false);
            builder.Property(x => x.UnitCalcPrc).HasColumnName(@"UNIT_CALC_PRC").HasColumnType("decimal(38,11)").IsRequired(false);
            builder.Property(x => x.UnitPrc).HasColumnName(@"UNIT_PRC").HasColumnType("decimal(38,11)").IsRequired(false);
            builder.Property(x => x.UnitPrc1).HasColumnName(@"UNIT_PRC_1").HasColumnType("decimal(38,11)").IsRequired(false);
            builder.Property(x => x.FuturePo).HasColumnName(@"FUTURE_PO").HasColumnType("decimal(31,8)").IsRequired(false);
        }
    }

}
// </auto-generated>

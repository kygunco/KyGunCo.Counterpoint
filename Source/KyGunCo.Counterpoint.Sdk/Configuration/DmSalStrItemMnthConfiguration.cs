// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // DM_SAL_STR_ITEM_MNTH
    public class DmSalStrItemMnthConfiguration : IEntityTypeConfiguration<DmSalStrItemMnth>
    {
        public void Configure(EntityTypeBuilder<DmSalStrItemMnth> builder)
        {
            builder.ToTable("DM_SAL_STR_ITEM_MNTH", "dbo");
            builder.HasKey(x => new { x.MnthId, x.StrId, x.LocId, x.ItemNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr, x.VendNo, x.CategCod, x.SubcatCod }).HasName("PK_DM_SAL_STR_ITEM_MNTH").IsClustered();

            builder.Property(x => x.MnthId).HasColumnName(@"MNTH_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.VendNo).HasColumnName(@"VEND_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.CategCod).HasColumnName(@"CATEG_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.SubcatCod).HasColumnName(@"SUBCAT_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.PartTktCnt).HasColumnName(@"PART_TKT_CNT").HasColumnType("int").IsRequired();
            builder.Property(x => x.SlsQty).HasColumnName(@"SLS_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.SlsExtPrc).HasColumnName(@"SLS_EXT_PRC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.SlsLinCnt).HasColumnName(@"SLS_LIN_CNT").HasColumnType("int").IsRequired();
            builder.Property(x => x.RtnQty).HasColumnName(@"RTN_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtnExtPrc).HasColumnName(@"RTN_EXT_PRC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtnLinCnt).HasColumnName(@"RTN_LIN_CNT").HasColumnType("int").IsRequired();
            builder.Property(x => x.TotExtCost).HasColumnName(@"TOT_EXT_COST").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotExtCalcPrc).HasColumnName(@"TOT_EXT_CALC_PRC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotExtRetlVal).HasColumnName(@"TOT_EXT_RETL_VAL").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotExtRegPrc).HasColumnName(@"TOT_EXT_REG_PRC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotExtPrc1).HasColumnName(@"TOT_EXT_PRC_1").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.DmStrHist).WithMany(b => b.DmSalStrItemMnths).HasForeignKey(c => c.StrId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_DM_SAL_STR_ITEM_MNTH_DM_STR_HIST");

            builder.HasIndex(x => new { x.StrId, x.MnthId, x.LocId, x.ItemNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr, x.VendNo, x.CategCod, x.SubcatCod }).HasDatabaseName("DM_SAL_STR_ITEM_MNTH_X1");
        }
    }

}
// </auto-generated>

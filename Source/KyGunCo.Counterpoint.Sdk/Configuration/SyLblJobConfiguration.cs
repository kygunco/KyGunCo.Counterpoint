// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_LBL_JOB
    public class SyLblJobConfiguration : IEntityTypeConfiguration<SyLblJob>
    {
        public void Configure(EntityTypeBuilder<SyLblJob> builder)
        {
            builder.ToTable("SY_LBL_JOB", "dbo");
            builder.HasKey(x => x.LblJob).HasName("PK_SY_LBL_JOB").IsClustered();

            builder.Property(x => x.LblJob).HasColumnName(@"LBL_JOB").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ValItemLbls).HasColumnName(@"VAL_ITEM_LBLS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ValRecvTags).HasColumnName(@"VAL_RECV_TAGS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ValXferTags).HasColumnName(@"VAL_XFER_TAGS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ValUsrDef).HasColumnName(@"VAL_USR_DEF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LblFil).HasColumnName(@"LBL_FIL").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.PrtrNam).HasColumnName(@"PRTR_NAM").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.QryFil).HasColumnName(@"QRY_FIL").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.CalcPrcs).HasColumnName(@"CALC_PRCS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MsgBefore).HasColumnName(@"MSG_BEFORE").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.BtnLblYes).HasColumnName(@"BTN_LBL_YES").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BtnLblNo).HasColumnName(@"BTN_LBL_NO").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.MsgAfter).HasColumnName(@"MSG_AFTER").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.LstPrtDt).HasColumnName(@"LST_PRT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstPrtUsrId).HasColumnName(@"LST_PRT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstPrtCount).HasColumnName(@"LST_PRT_COUNT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.DfltQty).HasColumnName(@"DFLT_QTY").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.QtyCol).HasColumnName(@"QTY_COL").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.UseFilt).HasColumnName(@"USE_FILT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrderByCols).HasColumnName(@"ORDER_BY_COLS").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.ValQassemTags).HasColumnName(@"VAL_QASSEM_TAGS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ValPriceSheetTags).HasColumnName(@"VAL_PRICE_SHEET_TAGS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ValOmLbls).HasColumnName(@"VAL_OM_LBLS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);

            builder.HasIndex(x => new { x.DescrUpr, x.LblJob }).HasDatabaseName("SY_LBL_JOB_X1");
        }
    }

}
// </auto-generated>
// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_GFC
    public class SyGfcConfiguration : IEntityTypeConfiguration<SyGfc>
    {
        public void Configure(EntityTypeBuilder<SyGfc> builder)
        {
            builder.ToTable("SY_GFC", "dbo");
            builder.HasKey(x => x.GfcNo).HasName("PK_SY_GFC").IsClustered();

            builder.Property(x => x.GfcNo).HasColumnName(@"GFC_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.OrigDat).HasColumnName(@"ORIG_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.OrigStrId).HasColumnName(@"ORIG_STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrigStaId).HasColumnName(@"ORIG_STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrigDocNo).HasColumnName(@"ORIG_DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OrigCustNo).HasColumnName(@"ORIG_CUST_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.GfcCod).HasColumnName(@"GFC_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ExpDat).HasColumnName(@"EXP_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.NoExpDat).HasColumnName(@"NO_EXP_DAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrigAmt).HasColumnName(@"ORIG_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.CurrAmt).HasColumnName(@"CURR_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.CreateMeth).HasColumnName(@"CREATE_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LiabAcctNo).HasColumnName(@"LIAB_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RdmAcctNo).HasColumnName(@"RDM_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RdmMeth).HasColumnName(@"RDM_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ForfAcctNo).HasColumnName(@"FORF_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.IsVoid).HasColumnName(@"IS_VOID").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstActivDat).HasColumnName(@"LST_ACTIV_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ErrRef).HasColumnName(@"ERR_REF").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.OrigDocId).HasColumnName(@"ORIG_DOC_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.OrigBusDat).HasColumnName(@"ORIG_BUS_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("SY_GFC_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("SY_GFC_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.GfcNo }).HasDatabaseName("SY_GFC_X1");
            builder.HasIndex(x => new { x.OrigCustNo, x.GfcNo }).HasDatabaseName("SY_GFC_X2");
            builder.HasIndex(x => new { x.ExpDat, x.GfcNo }).HasDatabaseName("SY_GFC_X3");
        }
    }

}
// </auto-generated>

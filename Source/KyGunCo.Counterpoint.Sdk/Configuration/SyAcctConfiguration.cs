// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_ACCT
    public class SyAcctConfiguration : IEntityTypeConfiguration<SyAcct>
    {
        public void Configure(EntityTypeBuilder<SyAcct> builder)
        {
            builder.ToTable("SY_ACCT", "dbo");
            builder.HasKey(x => x.AcctNo).HasName("PK_SY_ACCT").IsClustered();

            builder.Property(x => x.AcctNo).HasColumnName(@"ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.GlAcctNo).HasColumnName(@"GL_ACCT_NO").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ValPosting).HasColumnName(@"VAL_POSTING").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ValMain).HasColumnName(@"VAL_MAIN").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ValPftCtr).HasColumnName(@"VAL_PFT_CTR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("SY_ACCT_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("SY_ACCT_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.AcctNo }).HasDatabaseName("SY_ACCT_X1");
            builder.HasIndex(x => new { x.GlAcctNo, x.AcctNo }).HasDatabaseName("SY_ACCT_X2");
        }
    }

}
// </auto-generated>

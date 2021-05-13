// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_COMMIS_COD
    public class SyCommisCodConfiguration : IEntityTypeConfiguration<SyCommisCod>
    {
        public void Configure(EntityTypeBuilder<SyCommisCod> builder)
        {
            builder.ToTable("SY_COMMIS_COD", "dbo");
            builder.HasKey(x => x.CommisCod).HasName("PK_SY_COMMIS_COD").IsClustered();

            builder.Property(x => x.CommisCod).HasColumnName(@"COMMIS_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CommisPct).HasColumnName(@"COMMIS_PCT").HasColumnType("decimal(9,3)").IsRequired();
            builder.Property(x => x.CommisMeth).HasColumnName(@"COMMIS_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CalcOnMisc1).HasColumnName(@"CALC_ON_MISC_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CalcOnMisc2).HasColumnName(@"CALC_ON_MISC_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CalcOnMisc3).HasColumnName(@"CALC_ON_MISC_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CalcOnMisc4).HasColumnName(@"CALC_ON_MISC_4").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CalcOnMisc5).HasColumnName(@"CALC_ON_MISC_5").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CalcOnGfcAmt).HasColumnName(@"CALC_ON_GFC_AMT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.CalcOnSvcAmt).HasColumnName(@"CALC_ON_SVC_AMT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("SY_COMMIS_COD_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("SY_COMMIS_COD_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.CommisCod }).HasDatabaseName("SY_COMMIS_COD_X1");
        }
    }

}
// </auto-generated>
// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_TOUCH_SCRN_COD
    public class PsTouchScrnCodConfiguration : IEntityTypeConfiguration<PsTouchScrnCod>
    {
        public void Configure(EntityTypeBuilder<PsTouchScrnCod> builder)
        {
            builder.ToTable("PS_TOUCH_SCRN_COD", "dbo");
            builder.HasKey(x => x.TouchScrnCod).HasName("PK_PS_TOUCH_SCRN_COD").IsClustered();

            builder.Property(x => x.TouchScrnCod).HasColumnName(@"TOUCH_SCRN_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.ScrnConfig).HasColumnName(@"SCRN_CONFIG").HasColumnType("text(2147483647)").IsRequired().IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("PS_TOUCH_SCRN_COD_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("PS_TOUCH_SCRN_COD_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.TouchScrnCod }).HasDatabaseName("PS_TOUCH_SCRN_COD_X1");
        }
    }

}
// </auto-generated>
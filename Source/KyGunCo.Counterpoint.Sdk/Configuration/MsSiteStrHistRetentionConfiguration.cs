// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // MS_SITE_STR_HIST_RETENTION
    public class MsSiteStrHistRetentionConfiguration : IEntityTypeConfiguration<MsSiteStrHistRetention>
    {
        public void Configure(EntityTypeBuilder<MsSiteStrHistRetention> builder)
        {
            builder.ToTable("MS_SITE_STR_HIST_RETENTION", "dbo");
            builder.HasKey(x => new { x.SiteId, x.StrId }).HasName("PK_MS_SITE_STR_HIST_RETENTION").IsClustered();

            builder.Property(x => x.SiteId).HasColumnName(@"SITE_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.DataType).HasColumnName(@"DATA_TYPE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TimePrdCod).HasColumnName(@"TIME_PRD_COD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RetainTimePrds).HasColumnName(@"RETAIN_TIME_PRDS").HasColumnType("int").IsRequired();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
        }
    }

}
// </auto-generated>
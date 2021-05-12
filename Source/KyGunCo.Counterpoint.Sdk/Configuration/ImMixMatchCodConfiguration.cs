// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_MIX_MATCH_COD
    public class ImMixMatchCodConfiguration : IEntityTypeConfiguration<ImMixMatchCod>
    {
        public void Configure(EntityTypeBuilder<ImMixMatchCod> builder)
        {
            builder.ToTable("IM_MIX_MATCH_COD", "dbo");
            builder.HasKey(x => x.MixMatchCod).HasName("PK_IM_MIX_MATCH_COD").IsClustered();

            builder.Property(x => x.MixMatchCod).HasColumnName(@"MIX_MATCH_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PrcBasedOn).HasColumnName(@"PRC_BASED_ON").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("IM_MIX_MATCH_COD_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("IM_MIX_MATCH_COD_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.MixMatchCod }).HasDatabaseName("IM_MIX_MATCH_COD_X1");
        }
    }

}
// </auto-generated>

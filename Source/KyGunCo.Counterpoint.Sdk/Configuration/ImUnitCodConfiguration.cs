// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_UNIT_COD
    public class ImUnitCodConfiguration : IEntityTypeConfiguration<ImUnitCod>
    {
        public void Configure(EntityTypeBuilder<ImUnitCod> builder)
        {
            builder.ToTable("IM_UNIT_COD", "dbo");
            builder.HasKey(x => x.Unit).HasName("PK_IM_UNIT_COD").IsClustered();

            builder.Property(x => x.Unit).HasColumnName(@"UNIT").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DfltNumer).HasColumnName(@"DFLT_NUMER").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.DfltDenom).HasColumnName(@"DFLT_DENOM").HasColumnType("decimal(11,0)").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("IM_UNIT_COD_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("IM_UNIT_COD_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.Unit }).HasDatabaseName("IM_UNIT_COD_X1");
        }
    }

}
// </auto-generated>

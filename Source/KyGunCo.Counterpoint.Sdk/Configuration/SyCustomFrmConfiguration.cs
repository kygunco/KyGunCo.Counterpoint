// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_CUSTOM_FRM
    public class SyCustomFrmConfiguration : IEntityTypeConfiguration<SyCustomFrm>
    {
        public void Configure(EntityTypeBuilder<SyCustomFrm> builder)
        {
            builder.ToTable("SY_CUSTOM_FRM", "dbo");
            builder.HasKey(x => x.FrmId).HasName("PK_SY_CUSTOM_FRM").IsClustered();

            builder.Property(x => x.FrmId).HasColumnName(@"FRM_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.FrmNam).HasColumnName(@"FRM_NAM").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DbTblNam).HasColumnName(@"DB_TBL_NAM").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.FrmDef).HasColumnName(@"FRM_DEF").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("SY_CUSTOM_FRM_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("SY_CUSTOM_FRM_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.FrmNam, x.FrmId }).HasDatabaseName("SY_CUSTOM_FRM_X1");
        }
    }

}
// </auto-generated>
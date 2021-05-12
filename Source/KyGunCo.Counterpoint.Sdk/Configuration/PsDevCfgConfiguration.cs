// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_DEV_CFG
    public class PsDevCfgConfiguration : IEntityTypeConfiguration<PsDevCfg>
    {
        public void Configure(EntityTypeBuilder<PsDevCfg> builder)
        {
            builder.ToTable("PS_DEV_CFG", "dbo");
            builder.HasKey(x => x.DevCfgId).HasName("PK_PS_DEV_CFG").IsClustered();

            builder.Property(x => x.DevCfgId).HasColumnName(@"DEV_CFG_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.AssemNam).HasColumnName(@"ASSEM_NAM").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.ClassNam).HasColumnName(@"CLASS_NAM").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.WorkstationId).HasColumnName(@"WORKSTATION_ID").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.Disabled).HasColumnName(@"DISABLED").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.FstMaintDt).HasColumnName(@"FST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.FstMaintUsrId).HasColumnName(@"FST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("PS_DEV_CFG_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("PS_DEV_CFG_X_RS_UTC_DT");
        }
    }

}
// </auto-generated>

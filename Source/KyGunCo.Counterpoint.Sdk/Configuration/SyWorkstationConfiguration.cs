// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_WORKSTATION
    public class SyWorkstationConfiguration : IEntityTypeConfiguration<SyWorkstation>
    {
        public void Configure(EntityTypeBuilder<SyWorkstation> builder)
        {
            builder.ToTable("SY_WORKSTATION", "dbo");
            builder.HasKey(x => x.WorkstationId).HasName("PK_SY_WORKSTATION").IsClustered();

            builder.Property(x => x.WorkstationId).HasColumnName(@"WORKSTATION_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.MachineNam).HasColumnName(@"MACHINE_NAM").HasColumnType("varchar(128)").IsRequired().IsUnicode(false).HasMaxLength(128);
            builder.Property(x => x.CpServNam).HasColumnName(@"CP_SERV_NAM").HasColumnType("varchar(128)").IsRequired().IsUnicode(false).HasMaxLength(128);
            builder.Property(x => x.WrkgrpId).HasColumnName(@"WRKGRP_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AllowOtherWrkgrps).HasColumnName(@"ALLOW_OTHER_WRKGRPS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TouchMode).HasColumnName(@"TOUCH_MODE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SkipLoginDlg).HasColumnName(@"SKIP_LOGIN_DLG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EnableTktEntryEventLog).HasColumnName(@"ENABLE_TKT_ENTRY_EVENT_LOG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EnablePosDeviceLog).HasColumnName(@"ENABLE_POS_DEVICE_LOG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DrwId).HasColumnName(@"DRW_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AllowDrwChng).HasColumnName(@"ALLOW_DRW_CHNG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AllowStaChng).HasColumnName(@"ALLOW_STA_CHNG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.FstMaintDt).HasColumnName(@"FST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.FstMaintUsrId).HasColumnName(@"FST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.Udid).HasColumnName(@"UDID").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);

            builder.HasIndex(x => x.RsStat).HasDatabaseName("SY_WORKSTATION_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("SY_WORKSTATION_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.CpServNam, x.MachineNam, x.WorkstationId }).HasDatabaseName("SY_WORKSTATION_X1");
        }
    }

}
// </auto-generated>

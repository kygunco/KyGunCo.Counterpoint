// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PHYS_CNT_EVENTS
    public class ViPhysCntEventConfiguration : IEntityTypeConfiguration<ViPhysCntEvent>
    {
        public void Configure(EntityTypeBuilder<ViPhysCntEvent> builder)
        {
            builder.ToView("VI_PHYS_CNT_EVENTS", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PkgId).HasColumnName(@"PKG_ID").HasColumnType("varchar(2)").IsRequired().IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.EventTyp).HasColumnName(@"EVENT_TYP").HasColumnType("varchar(3)").IsRequired().IsUnicode(false).HasMaxLength(3);
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.EventDat).HasColumnName(@"EVENT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EventTim).HasColumnName(@"EVENT_TIM").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.SysErr).HasColumnName(@"SYS_ERR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SysErrRef).HasColumnName(@"SYS_ERR_REF").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.TrxCnt).HasColumnName(@"TRX_CNT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.PostCnt).HasColumnName(@"POST_CNT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.BrErrCnt).HasColumnName(@"BR_ERR_CNT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DbErrCnt).HasColumnName(@"DB_ERR_CNT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DrwId).HasColumnName(@"DRW_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PostDat).HasColumnName(@"POST_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.AddlParams).HasColumnName(@"ADDL_PARAMS").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.WrkgrpId).HasColumnName(@"WRKGRP_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.WkstnNam).HasColumnName(@"WKSTN_NAM").HasColumnType("varchar(128)").IsRequired(false).IsUnicode(false).HasMaxLength(128);
            builder.Property(x => x.ServNam).HasColumnName(@"SERV_NAM").HasColumnType("varchar(128)").IsRequired(false).IsUnicode(false).HasMaxLength(128);
            builder.Property(x => x.DbNam).HasColumnName(@"DB_NAM").HasColumnType("varchar(128)").IsRequired(false).IsUnicode(false).HasMaxLength(128);
            builder.Property(x => x.SwVerIni).HasColumnName(@"SW_VER_INI").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.SwVerExe).HasColumnName(@"SW_VER_EXE").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.SwVerBuildDt).HasColumnName(@"SW_VER_BUILD_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.FstPostDat).HasColumnName(@"FST_POST_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstPostDat).HasColumnName(@"LST_POST_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EventDt).HasColumnName(@"EVENT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.DrwSessionId).HasColumnName(@"DRW_SESSION_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.OrigSiteId).HasColumnName(@"ORIG_SITE_ID").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>
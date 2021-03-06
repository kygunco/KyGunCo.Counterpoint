// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_FRM_GRP
    public class PsFrmGrpConfiguration : IEntityTypeConfiguration<PsFrmGrp>
    {
        public void Configure(EntityTypeBuilder<PsFrmGrp> builder)
        {
            builder.ToTable("PS_FRM_GRP", "dbo");
            builder.HasKey(x => x.FrmGrpId).HasName("PK_PS_FRM_GRP").IsClustered();

            builder.Property(x => x.FrmGrpId).HasColumnName(@"FRM_GRP_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.AutoPrt).HasColumnName(@"AUTO_PRT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UpdtTimesPrtd).HasColumnName(@"UPDT_TIMES_PRTD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.HdrFilt).HasColumnName(@"HDR_FILT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.HdrFiltTmplt).HasColumnName(@"HDR_FILT_TMPLT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.BtnImgFil).HasColumnName(@"BTN_IMG_FIL").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.BtnLbl).HasColumnName(@"BTN_LBL").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BtnShortcut).HasColumnName(@"BTN_SHORTCUT").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.HdrFiltText).HasColumnName(@"HDR_FILT_TEXT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("PS_FRM_GRP_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("PS_FRM_GRP_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.FrmGrpId }).HasDatabaseName("PS_FRM_GRP_X1");
        }
    }

}
// </auto-generated>

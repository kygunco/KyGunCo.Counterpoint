// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_TARE_COD
    public class ImTareCodConfiguration : IEntityTypeConfiguration<ImTareCod>
    {
        public void Configure(EntityTypeBuilder<ImTareCod> builder)
        {
            builder.ToTable("IM_TARE_COD", "dbo");
            builder.HasKey(x => x.TareCod).HasName("PK_IM_TARE_COD").IsClustered();

            builder.Property(x => x.TareCod).HasColumnName(@"TARE_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.BtnLbl1).HasColumnName(@"BTN_LBL_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BtnImageFil1).HasColumnName(@"BTN_IMAGE_FIL_1").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.TareWeight1).HasColumnName(@"TARE_WEIGHT_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.BtnLbl2).HasColumnName(@"BTN_LBL_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BtnImageFil2).HasColumnName(@"BTN_IMAGE_FIL_2").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.TareWeight2).HasColumnName(@"TARE_WEIGHT_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.BtnLbl3).HasColumnName(@"BTN_LBL_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BtnImageFil3).HasColumnName(@"BTN_IMAGE_FIL_3").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.TareWeight3).HasColumnName(@"TARE_WEIGHT_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.BtnLbl4).HasColumnName(@"BTN_LBL_4").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BtnImageFil4).HasColumnName(@"BTN_IMAGE_FIL_4").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.TareWeight4).HasColumnName(@"TARE_WEIGHT_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.BtnLbl5).HasColumnName(@"BTN_LBL_5").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BtnImageFil5).HasColumnName(@"BTN_IMAGE_FIL_5").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.TareWeight5).HasColumnName(@"TARE_WEIGHT_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.BtnLbl6).HasColumnName(@"BTN_LBL_6").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BtnImageFil6).HasColumnName(@"BTN_IMAGE_FIL_6").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.TareWeight6).HasColumnName(@"TARE_WEIGHT_6").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.AllowWeightEntry1).HasColumnName(@"ALLOW_WEIGHT_ENTRY_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowWeightEntry2).HasColumnName(@"ALLOW_WEIGHT_ENTRY_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowWeightEntry3).HasColumnName(@"ALLOW_WEIGHT_ENTRY_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowWeightEntry4).HasColumnName(@"ALLOW_WEIGHT_ENTRY_4").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowWeightEntry5).HasColumnName(@"ALLOW_WEIGHT_ENTRY_5").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowWeightEntry6).HasColumnName(@"ALLOW_WEIGHT_ENTRY_6").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("IM_TARE_COD_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("IM_TARE_COD_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.TareCod }).HasDatabaseName("IM_TARE_COD_X1");
        }
    }

}
// </auto-generated>
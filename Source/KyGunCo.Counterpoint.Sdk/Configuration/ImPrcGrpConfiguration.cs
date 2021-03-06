// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_PRC_GRP
    public class ImPrcGrpConfiguration : IEntityTypeConfiguration<ImPrcGrp>
    {
        public void Configure(EntityTypeBuilder<ImPrcGrp> builder)
        {
            builder.ToTable("IM_PRC_GRP", "dbo");
            builder.HasKey(x => new { x.GrpTyp, x.GrpCod }).HasName("PK_IM_PRC_GRP").IsClustered();

            builder.Property(x => x.GrpTyp).HasColumnName(@"GRP_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedNever();
            builder.Property(x => x.GrpCod).HasColumnName(@"GRP_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.GrpSeqNo).HasColumnName(@"GRP_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CustFilt).HasColumnName(@"CUST_FILT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.BegDat).HasColumnName(@"BEG_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.NoBegDat).HasColumnName(@"NO_BEG_DAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.BegDt).HasColumnName(@"BEG_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.BegTimFlg).HasColumnName(@"BEG_TIM_FLG").HasColumnType("varchar(2)").IsRequired().IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.EndDat).HasColumnName(@"END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.NoEndDat).HasColumnName(@"NO_END_DAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EndDt).HasColumnName(@"END_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EndTimFlg).HasColumnName(@"END_TIM_FLG").HasColumnType("varchar(2)").IsRequired().IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.CustFiltTmplt).HasColumnName(@"CUST_FILT_TMPLT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.Enabled).HasColumnName(@"ENABLED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CustFiltText).HasColumnName(@"CUST_FILT_TEXT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.MixMatchCod).HasColumnName(@"MIX_MATCH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("IM_PRC_GRP_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("IM_PRC_GRP_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.GrpTyp, x.GrpSeqNo }).HasDatabaseName("IM_PRC_GRP_X1");
            builder.HasIndex(x => new { x.DescrUpr, x.GrpTyp, x.GrpCod }).HasDatabaseName("IM_PRC_GRP_X2");
            builder.HasIndex(x => new { x.CustNo, x.GrpTyp, x.GrpCod }).HasDatabaseName("IM_PRC_GRP_X3");
        }
    }

}
// </auto-generated>

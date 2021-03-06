// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_CATEG_COD
    public class ImCategCodConfiguration : IEntityTypeConfiguration<ImCategCod>
    {
        public void Configure(EntityTypeBuilder<ImCategCod> builder)
        {
            builder.ToTable("IM_CATEG_COD", "dbo");
            builder.HasKey(x => x.CategCod).HasName("PK_IM_CATEG_COD").IsClustered();

            builder.Property(x => x.CategCod).HasColumnName(@"CATEG_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PftCtr).HasColumnName(@"PFT_CTR").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.MinPftPct).HasColumnName(@"MIN_PFT_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.TrgtPftPct).HasColumnName(@"TRGT_PFT_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.PsLinCustFldFrmId).HasColumnName(@"PS_LIN_CUST_FLD_FRM_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.MinPftPctPrc2).HasColumnName(@"MIN_PFT_PCT_PRC_2").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.MinPftPctPrc3).HasColumnName(@"MIN_PFT_PCT_PRC_3").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.MinPftPctPrc4).HasColumnName(@"MIN_PFT_PCT_PRC_4").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.MinPftPctPrc5).HasColumnName(@"MIN_PFT_PCT_PRC_5").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.MinPftPctPrc6).HasColumnName(@"MIN_PFT_PCT_PRC_6").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.MinPftPctPrc1).HasColumnName(@"MIN_PFT_PCT_PRC_1").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.MinPftPctRegPrc).HasColumnName(@"MIN_PFT_PCT_REG_PRC").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.UserRequireIsFirearm).HasColumnName(@"USER_REQUIRE_IS_FIREARM").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);

            builder.HasIndex(x => x.RsStat).HasDatabaseName("IM_CATEG_COD_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("IM_CATEG_COD_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.CategCod }).HasDatabaseName("IM_CATEG_COD_X1");
        }
    }

}
// </auto-generated>

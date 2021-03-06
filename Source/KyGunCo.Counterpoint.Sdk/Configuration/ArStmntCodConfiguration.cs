// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AR_STMNT_COD
    public class ArStmntCodConfiguration : IEntityTypeConfiguration<ArStmntCod>
    {
        public void Configure(EntityTypeBuilder<ArStmntCod> builder)
        {
            builder.ToTable("AR_STMNT_COD", "dbo");
            builder.HasKey(x => x.StmntCod).HasName("PK_AR_STMNT_COD").IsClustered();

            builder.Property(x => x.StmntCod).HasColumnName(@"STMNT_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("AR_STMNT_COD_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("AR_STMNT_COD_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.StmntCod }).HasDatabaseName("AR_STMNT_COD_X1");
        }
    }

}
// </auto-generated>

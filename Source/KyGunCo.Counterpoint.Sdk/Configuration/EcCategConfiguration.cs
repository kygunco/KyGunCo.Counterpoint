// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // EC_CATEG
    public class EcCategConfiguration : IEntityTypeConfiguration<EcCateg>
    {
        public void Configure(EntityTypeBuilder<EcCateg> builder)
        {
            builder.ToTable("EC_CATEG", "dbo");
            builder.HasKey(x => x.CategId).HasName("PK_EC_CATEG").IsClustered();

            builder.Property(x => x.CategId).HasColumnName(@"CATEG_ID").HasColumnType("varchar(16)").IsRequired().IsUnicode(false).HasMaxLength(16).ValueGeneratedNever();
            builder.Property(x => x.ParentId).HasColumnName(@"PARENT_ID").HasColumnType("varchar(16)").IsRequired(false).IsUnicode(false).HasMaxLength(16);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.ImgFile).HasColumnName(@"IMG_FILE").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.HtmlDescr).HasColumnName(@"HTML_DESCR").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.DispSeqNo).HasColumnName(@"DISP_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            builder.HasIndex(x => new { x.DescrUpr, x.CategId }).HasDatabaseName("EC_CATEG_X1");
            builder.HasIndex(x => new { x.ParentId, x.CategId }).HasDatabaseName("EC_CATEG_X2");
        }
    }

}
// </auto-generated>

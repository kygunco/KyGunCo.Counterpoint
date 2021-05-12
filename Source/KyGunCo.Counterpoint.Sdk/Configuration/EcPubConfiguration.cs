// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // EC_PUB
    public class EcPubConfiguration : IEntityTypeConfiguration<EcPub>
    {
        public void Configure(EntityTypeBuilder<EcPub> builder)
        {
            builder.ToTable("EC_PUB", "dbo");
            builder.HasKey(x => x.PubId).HasName("PK_EC_PUB").IsClustered();

            builder.Property(x => x.PubId).HasColumnName(@"PUB_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ItemFilt).HasColumnName(@"ITEM_FILT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.ItemPubMode).HasColumnName(@"ITEM_PUB_MODE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ItemFiltTmplt).HasColumnName(@"ITEM_FILT_TMPLT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.ItemFiltText).HasColumnName(@"ITEM_FILT_TEXT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.CustFilt).HasColumnName(@"CUST_FILT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.CustFiltTmplt).HasColumnName(@"CUST_FILT_TMPLT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.CustFiltText).HasColumnName(@"CUST_FILT_TEXT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.CustPubMode).HasColumnName(@"CUST_PUB_MODE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PubOrds).HasColumnName(@"PUB_ORDS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrdFilt).HasColumnName(@"ORD_FILT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.OrdFiltTmplt).HasColumnName(@"ORD_FILT_TMPLT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.OrdFiltText).HasColumnName(@"ORD_FILT_TEXT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.PubTktHist).HasColumnName(@"PUB_TKT_HIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TktHistFilt).HasColumnName(@"TKT_HIST_FILT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.TktHistFiltTmplt).HasColumnName(@"TKT_HIST_FILT_TMPLT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.TktHistFiltText).HasColumnName(@"TKT_HIST_FILT_TEXT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);

            builder.HasIndex(x => new { x.DescrUpr, x.PubId }).HasDatabaseName("EC_PUB_X1");
        }
    }

}
// </auto-generated>

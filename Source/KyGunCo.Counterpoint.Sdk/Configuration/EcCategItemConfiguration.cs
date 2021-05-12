// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // EC_CATEG_ITEM
    public class EcCategItemConfiguration : IEntityTypeConfiguration<EcCategItem>
    {
        public void Configure(EntityTypeBuilder<EcCategItem> builder)
        {
            builder.ToTable("EC_CATEG_ITEM", "dbo");
            builder.HasKey(x => new { x.ItemNo, x.CategId }).HasName("PK_EC_CATEG_ITEM").IsClustered();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.CategId).HasColumnName(@"CATEG_ID").HasColumnType("varchar(16)").IsRequired().IsUnicode(false).HasMaxLength(16).ValueGeneratedNever();
            builder.Property(x => x.EntrySeqNo).HasColumnName(@"ENTRY_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.EcCateg).WithMany(b => b.EcCategItems).HasForeignKey(c => c.CategId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EC_CATEG_ITEM_EC_CATEG");

            builder.HasIndex(x => new { x.ItemNo, x.EntrySeqNo }).HasDatabaseName("EC_CATEG_ITEM_X1");
            builder.HasIndex(x => new { x.CategId, x.ItemNo }).HasDatabaseName("EC_CATEG_ITEM_X2");
        }
    }

}
// </auto-generated>

// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_SUBST_ITEM
    public class ImSubstItemConfiguration : IEntityTypeConfiguration<ImSubstItem>
    {
        public void Configure(EntityTypeBuilder<ImSubstItem> builder)
        {
            builder.ToTable("IM_SUBST_ITEM", "dbo");
            builder.HasKey(x => new { x.ItemNo, x.SubstItemNo }).HasName("PK_IM_SUBST_ITEM").IsClustered();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.SubstItemNo).HasColumnName(@"SUBST_ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.ImItem).WithMany(b => b.ImSubstItems).HasForeignKey(c => c.ItemNo).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_SUBST_ITEM_IM_ITEM");

            builder.HasIndex(x => new { x.ItemNo, x.SeqNo, x.SubstItemNo }).HasDatabaseName("IM_SUBST_ITEM_X1");
            builder.HasIndex(x => new { x.SubstItemNo, x.ItemNo }).HasDatabaseName("IM_SUBST_ITEM_X2");
        }
    }

}
// </auto-generated>

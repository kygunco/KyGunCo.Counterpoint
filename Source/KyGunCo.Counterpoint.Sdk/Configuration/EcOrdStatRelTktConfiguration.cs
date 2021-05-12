// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // EC_ORD_STAT_REL_TKTS
    public class EcOrdStatRelTktConfiguration : IEntityTypeConfiguration<EcOrdStatRelTkt>
    {
        public void Configure(EntityTypeBuilder<EcOrdStatRelTkt> builder)
        {
            builder.ToTable("EC_ORD_STAT_REL_TKTS", "dbo");
            builder.HasKey(x => new { x.EcOrdNo, x.SeqNo }).HasName("PK_EC_ORD_STAT_REL_TKTS").IsClustered();

            builder.Property(x => x.EcOrdNo).HasColumnName(@"EC_ORD_NO").HasColumnType("varchar(9)").IsRequired().IsUnicode(false).HasMaxLength(9).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.RelStrId).HasColumnName(@"REL_STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RelStaId).HasColumnName(@"REL_STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RelTktNo).HasColumnName(@"REL_TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.RelPostEventNo).HasColumnName(@"REL_POST_EVENT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.RelPostBusDat).HasColumnName(@"REL_POST_BUS_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.RelDocId).HasColumnName(@"REL_DOC_ID").HasColumnType("bigint").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.EcOrdStat).WithMany(b => b.EcOrdStatRelTkts).HasForeignKey(c => c.EcOrdNo).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EC_ORD_STAT_REL_TKTS_EC_ORD_STAT");
        }
    }

}
// </auto-generated>

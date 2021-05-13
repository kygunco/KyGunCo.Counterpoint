// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_ADJ_HIST_SER_LOC
    public class PoAdjHistSerLocConfiguration : IEntityTypeConfiguration<PoAdjHistSerLoc>
    {
        public void Configure(EntityTypeBuilder<PoAdjHistSerLoc> builder)
        {
            builder.ToTable("PO_ADJ_HIST_SER_LOC", "dbo");
            builder.HasKey(x => new { x.EventNo, x.RecvrNo, x.SeqNo, x.LocId, x.SerNo }).HasName("PK_PO_ADJ_HIST_SER_LOC").IsClustered();

            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.RecvrNo).HasColumnName(@"RECVR_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();
            builder.Property(x => x.CostBefore).HasColumnName(@"COST_BEFORE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CostAfter).HasColumnName(@"COST_AFTER").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PoAdjHistLinLoc).WithMany(b => b.PoAdjHistSerLocs).HasForeignKey(c => new { c.EventNo, c.RecvrNo, c.SeqNo, c.LocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_ADJ_HIST_SER_LOC_PO_ADJ_HIST_LIN_LOC");
            builder.HasOne(a => a.PoAdjHistSer).WithMany(b => b.PoAdjHistSerLocs).HasForeignKey(c => new { c.EventNo, c.RecvrNo, c.SeqNo, c.SerNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_ADJ_HIST_SER_LOC_PO_ADJ_HIST_SER");
        }
    }

}
// </auto-generated>
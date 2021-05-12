// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_ADJ_HIST_CELL_LOC
    public class PoAdjHistCellLocConfiguration : IEntityTypeConfiguration<PoAdjHistCellLoc>
    {
        public void Configure(EntityTypeBuilder<PoAdjHistCellLoc> builder)
        {
            builder.ToTable("PO_ADJ_HIST_CELL_LOC", "dbo");
            builder.HasKey(x => new { x.EventNo, x.RecvrNo, x.SeqNo, x.LocId, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_PO_ADJ_HIST_CELL_LOC").IsClustered();

            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.RecvrNo).HasColumnName(@"RECVR_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.QtyRecvd).HasColumnName(@"QTY_RECVD").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyAdj).HasColumnName(@"QTY_ADJ").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PoAdjHistCell).WithMany(b => b.PoAdjHistCellLocs).HasForeignKey(c => new { c.EventNo, c.RecvrNo, c.SeqNo, c.Dim1Upr, c.Dim2Upr, c.Dim3Upr }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_ADJ_HIST_CELL_LOC_PO_ADJ_HIST_CELL");
            builder.HasOne(a => a.PoAdjHistLinLoc).WithMany(b => b.PoAdjHistCellLocs).HasForeignKey(c => new { c.EventNo, c.RecvrNo, c.SeqNo, c.LocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_ADJ_HIST_CELL_LOC_PO_ADJ_HIST_LIN_LOC");
        }
    }

}
// </auto-generated>

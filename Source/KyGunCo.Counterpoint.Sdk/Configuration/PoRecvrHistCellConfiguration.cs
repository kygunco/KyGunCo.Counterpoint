// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_RECVR_HIST_CELL
    public class PoRecvrHistCellConfiguration : IEntityTypeConfiguration<PoRecvrHistCell>
    {
        public void Configure(EntityTypeBuilder<PoRecvrHistCell> builder)
        {
            builder.ToTable("PO_RECVR_HIST_CELL", "dbo");
            builder.HasKey(x => new { x.RecvrNo, x.SeqNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_PO_RECVR_HIST_CELL").IsClustered();

            builder.Property(x => x.RecvrNo).HasColumnName(@"RECVR_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.QtyRecvd).HasColumnName(@"QTY_RECVD").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.NewQtyExpectd).HasColumnName(@"NEW_QTY_EXPECTD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.PrevQtyExpectd).HasColumnName(@"PREV_QTY_EXPECTD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyOnHndBefore).HasColumnName(@"QTY_ON_HND_BEFORE").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.PoRecvrHistLin).WithMany(b => b.PoRecvrHistCells).HasForeignKey(c => new { c.RecvrNo, c.SeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_RECVR_HIST_CELL_PO_RECVR_HIST_LIN");
        }
    }

}
// </auto-generated>

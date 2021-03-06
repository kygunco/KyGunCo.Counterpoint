// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_XFER_IN_CELL
    public class ImXferInCellConfiguration : IEntityTypeConfiguration<ImXferInCell>
    {
        public void Configure(EntityTypeBuilder<ImXferInCell> builder)
        {
            builder.ToTable("IM_XFER_IN_CELL", "dbo");
            builder.HasKey(x => new { x.XferNo, x.XferInLinSeqNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_IM_XFER_IN_CELL").IsClustered();

            builder.Property(x => x.XferNo).HasColumnName(@"XFER_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.XferInLinSeqNo).HasColumnName(@"XFER_IN_LIN_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.PrevQtyExpectd).HasColumnName(@"PREV_QTY_EXPECTD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyRecvd).HasColumnName(@"QTY_RECVD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.NewQtyExpectd).HasColumnName(@"NEW_QTY_EXPECTD").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.AddedDuringEnt).HasColumnName(@"ADDED_DURING_ENT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImXferInLin).WithMany(b => b.ImXferInCells).HasForeignKey(c => new { c.XferNo, c.XferInLinSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_XFER_IN_CELL_IM_XFER_IN_LIN");
        }
    }

}
// </auto-generated>

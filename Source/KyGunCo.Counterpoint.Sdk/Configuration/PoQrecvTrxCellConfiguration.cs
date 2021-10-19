// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_QRECV_TRX_CELL
    public class PoQrecvTrxCellConfiguration : IEntityTypeConfiguration<PoQrecvTrxCell>
    {
        public void Configure(EntityTypeBuilder<PoQrecvTrxCell> builder)
        {
            builder.ToTable("PO_QRECV_TRX_CELL", "dbo");
            builder.HasKey(x => new { x.BatId, x.ItemNo, x.LocId, x.TrxDat, x.SeqNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_PO_QRECV_TRX_CELL").IsClustered();

            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.TrxDat).HasColumnName(@"TRX_DAT").HasColumnType("datetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Qty).HasColumnName(@"QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.PoQrecvTrx).WithMany(b => b.PoQrecvTrxCells).HasForeignKey(c => new { c.BatId, c.ItemNo, c.LocId, c.TrxDat, c.SeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_QRECV_TRX_CELL_PO_QRECV_TRX");
        }
    }

}
// </auto-generated>

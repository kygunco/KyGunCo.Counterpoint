// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_XFER_OUT_CELL
    public class ImXferOutCellConfiguration : IEntityTypeConfiguration<ImXferOutCell>
    {
        public void Configure(EntityTypeBuilder<ImXferOutCell> builder)
        {
            builder.ToTable("IM_XFER_OUT_CELL", "dbo");
            builder.HasKey(x => new { x.XferNo, x.XferLinSeqNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_IM_XFER_OUT_CELL").IsClustered();

            builder.Property(x => x.XferNo).HasColumnName(@"XFER_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.XferLinSeqNo).HasColumnName(@"XFER_LIN_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.XferQty).HasColumnName(@"XFER_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImXferOutLin).WithMany(b => b.ImXferOutCells).HasForeignKey(c => new { c.XferNo, c.XferLinSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_XFER_OUT_CELL_IM_XFER_OUT_LIN");
        }
    }

}
// </auto-generated>

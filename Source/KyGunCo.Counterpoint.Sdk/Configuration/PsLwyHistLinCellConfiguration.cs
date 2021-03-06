// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_LWY_HIST_LIN_CELL
    public class PsLwyHistLinCellConfiguration : IEntityTypeConfiguration<PsLwyHistLinCell>
    {
        public void Configure(EntityTypeBuilder<PsLwyHistLinCell> builder)
        {
            builder.ToTable("PS_LWY_HIST_LIN_CELL", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.LinSeqNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_PS_LWY_HIST_LIN_CELL").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.QtySold).HasColumnName(@"QTY_SOLD").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrigQty).HasColumnName(@"ORIG_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyShipped).HasColumnName(@"QTY_SHIPPED").HasColumnType("decimal(15,4)").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.PsLwyHistLin).WithMany(b => b.PsLwyHistLinCells).HasForeignKey(c => new { c.BusDat, c.DocId, c.LinSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_LWY_HIST_LIN_CELL_PS_LWY_HIST_LIN");
        }
    }

}
// </auto-generated>

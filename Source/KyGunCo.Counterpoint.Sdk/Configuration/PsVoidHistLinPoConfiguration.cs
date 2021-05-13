// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_VOID_HIST_LIN_PO
    public class PsVoidHistLinPoConfiguration : IEntityTypeConfiguration<PsVoidHistLinPo>
    {
        public void Configure(EntityTypeBuilder<PsVoidHistLinPo> builder)
        {
            builder.ToTable("PS_VOID_HIST_LIN_PO", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.LinSeqNo }).HasName("PK_PS_VOID_HIST_LIN_PO").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PoPreqNo).HasColumnName(@"PO_PREQ_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PoOrdNo).HasColumnName(@"PO_ORD_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.PoLinSeqNo).HasColumnName(@"PO_LIN_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.PoRecvrNo).HasColumnName(@"PO_RECVR_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PoRecvrLinSeqNo).HasColumnName(@"PO_RECVR_LIN_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.PoTotQtyRecvd).HasColumnName(@"PO_TOT_QTY_RECVD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.PoQtyExpectd).HasColumnName(@"PO_QTY_EXPECTD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.PoRecvrCnt).HasColumnName(@"PO_RECVR_CNT").HasColumnType("int").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PsVoidHistLin).WithOne(b => b.PsVoidHistLinPo).HasForeignKey<PsVoidHistLinPo>(c => new { c.BusDat, c.DocId, c.LinSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_VOID_HIST_LIN_PO_PS_VOID_HIST_LIN");
        }
    }

}
// </auto-generated>
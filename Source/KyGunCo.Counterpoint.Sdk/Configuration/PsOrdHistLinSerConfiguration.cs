// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_ORD_HIST_LIN_SER
    public class PsOrdHistLinSerConfiguration : IEntityTypeConfiguration<PsOrdHistLinSer>
    {
        public void Configure(EntityTypeBuilder<PsOrdHistLinSer> builder)
        {
            builder.ToTable("PS_ORD_HIST_LIN_SER", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.LinSeqNo, x.SerNo }).HasName("PK_PS_ORD_HIST_LIN_SER").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();
            builder.Property(x => x.SerSeqNo).HasColumnName(@"SER_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SerCost).HasColumnName(@"SER_COST").HasColumnType("money").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PsOrdHistLin).WithMany(b => b.PsOrdHistLinSers).HasForeignKey(c => new { c.BusDat, c.DocId, c.LinSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_LIN_SER_PS_ORD_HIST_LIN");
        }
    }

}
// </auto-generated>

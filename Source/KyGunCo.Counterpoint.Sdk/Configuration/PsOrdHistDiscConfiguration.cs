// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_ORD_HIST_DISC
    public class PsOrdHistDiscConfiguration : IEntityTypeConfiguration<PsOrdHistDisc>
    {
        public void Configure(EntityTypeBuilder<PsOrdHistDisc> builder)
        {
            builder.ToTable("PS_ORD_HIST_DISC", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.DiscSeqNo }).HasName("PK_PS_ORD_HIST_DISC").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DiscSeqNo).HasColumnName(@"DISC_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DiscId).HasColumnName(@"DISC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.ApplyTo).HasColumnName(@"APPLY_TO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DiscTyp).HasColumnName(@"DISC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DiscAmt).HasColumnName(@"DISC_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.DiscPct).HasColumnName(@"DISC_PCT").HasColumnType("decimal(9,3)").IsRequired();
            builder.Property(x => x.DiscAmtShipped).HasColumnName(@"DISC_AMT_SHIPPED").HasColumnType("decimal(15,2)").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.PsOrdHist).WithMany(b => b.PsOrdHistDiscs).HasForeignKey(c => new { c.BusDat, c.DocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_DISC_PS_ORD_HIST");
            builder.HasOne(a => a.PsOrdHistLin).WithMany(b => b.PsOrdHistDiscs).HasForeignKey(c => new { c.BusDat, c.DocId, c.LinSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_DISC_PS_ORD_HIST_LIN");
        }
    }

}
// </auto-generated>
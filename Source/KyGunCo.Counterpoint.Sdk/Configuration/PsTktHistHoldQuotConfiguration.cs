// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_TKT_HIST_HOLD_QUOT
    public class PsTktHistHoldQuotConfiguration : IEntityTypeConfiguration<PsTktHistHoldQuot>
    {
        public void Configure(EntityTypeBuilder<PsTktHistHoldQuot> builder)
        {
            builder.ToTable("PS_TKT_HIST_HOLD_QUOT", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId }).HasName("PK_PS_TKT_HIST_HOLD_QUOT").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.OrigHoldStrId).HasColumnName(@"ORIG_HOLD_STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrigHoldStaId).HasColumnName(@"ORIG_HOLD_STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrigHoldNo).HasColumnName(@"ORIG_HOLD_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OrigHoldDocId).HasColumnName(@"ORIG_HOLD_DOC_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.OrigQuotStrId).HasColumnName(@"ORIG_QUOT_STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrigQuotStaId).HasColumnName(@"ORIG_QUOT_STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrigQuotNo).HasColumnName(@"ORIG_QUOT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OrigQuotDocId).HasColumnName(@"ORIG_QUOT_DOC_ID").HasColumnType("bigint").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PsTktHist).WithOne(b => b.PsTktHistHoldQuot).HasForeignKey<PsTktHistHoldQuot>(c => new { c.BusDat, c.DocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_TKT_HIST_HOLD_QUOT_PS_TKT_HIST");
        }
    }

}
// </auto-generated>

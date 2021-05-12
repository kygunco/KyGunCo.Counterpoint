// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_DOC_HDR_HOLD_QUOT
    public class PsDocHdrHoldQuotConfiguration : IEntityTypeConfiguration<PsDocHdrHoldQuot>
    {
        public void Configure(EntityTypeBuilder<PsDocHdrHoldQuot> builder)
        {
            builder.ToTable("PS_DOC_HDR_HOLD_QUOT", "dbo");
            builder.HasKey(x => x.DocId).HasName("PK_PS_DOC_HDR_HOLD_QUOT").IsClustered();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.OrigQuotStrId).HasColumnName(@"ORIG_QUOT_STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrigQuotStaId).HasColumnName(@"ORIG_QUOT_STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrigQuotNo).HasColumnName(@"ORIG_QUOT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.QuotExpDat).HasColumnName(@"QUOT_EXP_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.OrigHoldDocId).HasColumnName(@"ORIG_HOLD_DOC_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.OrigHoldStrId).HasColumnName(@"ORIG_HOLD_STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrigHoldStaId).HasColumnName(@"ORIG_HOLD_STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrigHoldNo).HasColumnName(@"ORIG_HOLD_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OrigQuotDocId).HasColumnName(@"ORIG_QUOT_DOC_ID").HasColumnType("bigint").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PsDocHdr).WithOne(b => b.PsDocHdrHoldQuot).HasForeignKey<PsDocHdrHoldQuot>(c => c.DocId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_DOC_HDR_HOLD_QUOT_PS_DOC_HDR");
        }
    }

}
// </auto-generated>

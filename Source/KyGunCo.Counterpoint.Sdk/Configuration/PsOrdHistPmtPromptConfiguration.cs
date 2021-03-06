// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_ORD_HIST_PMT_PROMPT
    public class PsOrdHistPmtPromptConfiguration : IEntityTypeConfiguration<PsOrdHistPmtPrompt>
    {
        public void Configure(EntityTypeBuilder<PsOrdHistPmtPrompt> builder)
        {
            builder.ToTable("PS_ORD_HIST_PMT_PROMPT", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.PmtSeqNo, x.PromptSeqNo }).HasName("PK_PS_ORD_HIST_PMT_PROMPT").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PmtSeqNo).HasColumnName(@"PMT_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PromptSeqNo).HasColumnName(@"PROMPT_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PromptTxt).HasColumnName(@"PROMPT_TXT").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.PromptVal).HasColumnName(@"PROMPT_VAL").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);

            // Foreign keys
            builder.HasOne(a => a.PsOrdHistPmt).WithMany(b => b.PsOrdHistPmtPrompts).HasForeignKey(c => new { c.BusDat, c.DocId, c.PmtSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_PMT_PROMPT_PS_ORD_HIST_PMT");
        }
    }

}
// </auto-generated>

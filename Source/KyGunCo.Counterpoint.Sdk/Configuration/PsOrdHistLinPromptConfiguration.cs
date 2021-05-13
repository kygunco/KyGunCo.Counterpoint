// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_ORD_HIST_LIN_PROMPT
    public class PsOrdHistLinPromptConfiguration : IEntityTypeConfiguration<PsOrdHistLinPrompt>
    {
        public void Configure(EntityTypeBuilder<PsOrdHistLinPrompt> builder)
        {
            builder.ToTable("PS_ORD_HIST_LIN_PROMPT", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.LinSeqNo, x.PromptSeqNo }).HasName("PK_PS_ORD_HIST_LIN_PROMPT").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PromptSeqNo).HasColumnName(@"PROMPT_SEQ_NO").HasColumnType("tinyint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PromptCod).HasColumnName(@"PROMPT_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PromptAlpha).HasColumnName(@"PROMPT_ALPHA").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptDat).HasColumnName(@"PROMPT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.PromptNo).HasColumnName(@"PROMPT_NO").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.PromptStr).HasColumnName(@"PROMPT_STR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);

            // Foreign keys
            builder.HasOne(a => a.PsOrdHistLin).WithMany(b => b.PsOrdHistLinPrompts).HasForeignKey(c => new { c.BusDat, c.DocId, c.LinSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_LIN_PROMPT_PS_ORD_HIST_LIN");
        }
    }

}
// </auto-generated>
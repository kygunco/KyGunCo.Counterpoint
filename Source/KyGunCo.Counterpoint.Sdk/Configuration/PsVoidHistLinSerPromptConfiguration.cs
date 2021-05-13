// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_VOID_HIST_LIN_SER_PROMPT
    public class PsVoidHistLinSerPromptConfiguration : IEntityTypeConfiguration<PsVoidHistLinSerPrompt>
    {
        public void Configure(EntityTypeBuilder<PsVoidHistLinSerPrompt> builder)
        {
            builder.ToTable("PS_VOID_HIST_LIN_SER_PROMPT", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.LinSeqNo, x.SerNo, x.PromptSeqNo }).HasName("PK_PS_VOID_HIST_LIN_SER_PROMPT").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();
            builder.Property(x => x.PromptSeqNo).HasColumnName(@"PROMPT_SEQ_NO").HasColumnType("tinyint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PromptCod).HasColumnName(@"PROMPT_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PromptAlpha).HasColumnName(@"PROMPT_ALPHA").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptDat).HasColumnName(@"PROMPT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.PromptNo).HasColumnName(@"PROMPT_NO").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.PromptStr).HasColumnName(@"PROMPT_STR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);

            // Foreign keys
            builder.HasOne(a => a.PsVoidHistLinSer).WithMany(b => b.PsVoidHistLinSerPrompts).HasForeignKey(c => new { c.BusDat, c.DocId, c.LinSeqNo, c.SerNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_VOID_HIST_LIN_SER_PROMPT_PS_VOID_HIST_LIN_SER");
        }
    }

}
// </auto-generated>
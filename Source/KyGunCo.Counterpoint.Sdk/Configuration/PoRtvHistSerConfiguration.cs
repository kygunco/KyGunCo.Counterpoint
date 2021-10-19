// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_RTV_HIST_SER
    public class PoRtvHistSerConfiguration : IEntityTypeConfiguration<PoRtvHistSer>
    {
        public void Configure(EntityTypeBuilder<PoRtvHistSer> builder)
        {
            builder.ToTable("PO_RTV_HIST_SER", "dbo");
            builder.HasKey(x => new { x.RtvNo, x.SeqNo, x.SerNo }).HasName("PK_PO_RTV_HIST_SER").IsClustered();

            builder.Property(x => x.RtvNo).HasColumnName(@"RTV_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();
            builder.Property(x => x.SerSeqNo).HasColumnName(@"SER_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.PromptCod1).HasColumnName(@"PROMPT_COD_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PromptAlpha1).HasColumnName(@"PROMPT_ALPHA_1").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptDat1).HasColumnName(@"PROMPT_DAT_1").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.PromptNo1).HasColumnName(@"PROMPT_NO_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prompt1Str).HasColumnName(@"PROMPT_1_STR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptCod2).HasColumnName(@"PROMPT_COD_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PromptAlpha2).HasColumnName(@"PROMPT_ALPHA_2").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptDat2).HasColumnName(@"PROMPT_DAT_2").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.PromptNo2).HasColumnName(@"PROMPT_NO_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prompt2Str).HasColumnName(@"PROMPT_2_STR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptCod3).HasColumnName(@"PROMPT_COD_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PromptAlpha3).HasColumnName(@"PROMPT_ALPHA_3").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptDat3).HasColumnName(@"PROMPT_DAT_3").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.PromptNo3).HasColumnName(@"PROMPT_NO_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Prompt3Str).HasColumnName(@"PROMPT_3_STR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.SerCost).HasColumnName(@"SER_COST").HasColumnType("decimal(15,4)").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PoRtvHistLin).WithMany(b => b.PoRtvHistSers).HasForeignKey(c => new { c.RtvNo, c.SeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_RTV_HIST_SER_PO_RTV_HIST_LIN");

            builder.HasIndex(x => new { x.RtvNo, x.SeqNo, x.SerSeqNo }).HasDatabaseName("PO_RTV_HIST_SER_X1");
        }
    }

}
// </auto-generated>

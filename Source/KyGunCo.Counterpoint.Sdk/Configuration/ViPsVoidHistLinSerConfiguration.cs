// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_VOID_HIST_LIN_SER
    public class ViPsVoidHistLinSerConfiguration : IEntityTypeConfiguration<ViPsVoidHistLinSer>
    {
        public void Configure(EntityTypeBuilder<ViPsVoidHistLinSer> builder)
        {
            builder.ToView("VI_PS_VOID_HIST_LIN_SER", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.SerSeqNo).HasColumnName(@"SER_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SerCost).HasColumnName(@"SER_COST").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.PromptNo1).HasColumnName(@"PROMPT_NO_1").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.PromptCod1).HasColumnName(@"PROMPT_COD_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PromptAlpha1).HasColumnName(@"PROMPT_ALPHA_1").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptDat1).HasColumnName(@"PROMPT_DAT_1").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Prompt1Str).HasColumnName(@"PROMPT_1_STR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptNo2).HasColumnName(@"PROMPT_NO_2").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.PromptCod2).HasColumnName(@"PROMPT_COD_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PromptAlpha2).HasColumnName(@"PROMPT_ALPHA_2").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptDat2).HasColumnName(@"PROMPT_DAT_2").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Prompt2Str).HasColumnName(@"PROMPT_2_STR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptNo3).HasColumnName(@"PROMPT_NO_3").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.PromptCod3).HasColumnName(@"PROMPT_COD_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PromptAlpha3).HasColumnName(@"PROMPT_ALPHA_3").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptDat3).HasColumnName(@"PROMPT_DAT_3").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Prompt3Str).HasColumnName(@"PROMPT_3_STR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.BusDatExt).HasColumnName(@"BUS_DAT_EXT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.DocIdExt).HasColumnName(@"DOC_ID_EXT").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.LinSeqNoExt).HasColumnName(@"LIN_SEQ_NO_EXT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SerNoExt).HasColumnName(@"SER_NO_EXT").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
        }
    }

}
// </auto-generated>

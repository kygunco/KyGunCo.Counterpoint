// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_SER_PROMPT
    public class ImSerPromptConfiguration : IEntityTypeConfiguration<ImSerPrompt>
    {
        public void Configure(EntityTypeBuilder<ImSerPrompt> builder)
        {
            builder.ToTable("IM_SER_PROMPT", "dbo");
            builder.HasKey(x => x.PromptCod).HasName("PK_IM_SER_PROMPT").IsClustered();

            builder.Property(x => x.PromptCod).HasColumnName(@"PROMPT_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptTxt).HasColumnName(@"PROMPT_TXT").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DataTyp).HasColumnName(@"DATA_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.NoOfDecs).HasColumnName(@"NO_OF_DECS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.EntryReq).HasColumnName(@"ENTRY_REQ").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Constrnt).HasColumnName(@"CONSTRNT").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.ConstrntErrMsg).HasColumnName(@"CONSTRNT_ERR_MSG").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.ValForPrompt1).HasColumnName(@"VAL_FOR_PROMPT_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ValForPrompt2).HasColumnName(@"VAL_FOR_PROMPT_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ValForPrompt3).HasColumnName(@"VAL_FOR_PROMPT_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseForAdj).HasColumnName(@"USE_FOR_ADJ").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseForRecv).HasColumnName(@"USE_FOR_RECV").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseForSls).HasColumnName(@"USE_FOR_SLS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseForRet).HasColumnName(@"USE_FOR_RET").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseForXfer).HasColumnName(@"USE_FOR_XFER").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.UseForRtv).HasColumnName(@"USE_FOR_RTV").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("IM_SER_PROMPT_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("IM_SER_PROMPT_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DescrUpr, x.PromptCod }).HasDatabaseName("IM_SER_PROMPT_X1");
        }
    }

}
// </auto-generated>

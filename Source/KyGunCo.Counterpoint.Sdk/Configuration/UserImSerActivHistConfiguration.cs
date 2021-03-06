// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_IM_SER_ACTIV_HIST
    public class UserImSerActivHistConfiguration : IEntityTypeConfiguration<UserImSerActivHist>
    {
        public void Configure(EntityTypeBuilder<UserImSerActivHist> builder)
        {
            builder.ToTable("USER_IM_SER_ACTIV_HIST", "dbo");
            builder.HasKey(x => new { x.ItemNo, x.SerNo, x.SeqNo, x.ActivTyp, x.Posted });

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ActivTyp).HasColumnName(@"ACTIV_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedNever();
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Dat).HasColumnName(@"DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.TrxSeqNo).HasColumnName(@"TRX_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.FromLocId).HasColumnName(@"FROM_LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RecvrNo).HasColumnName(@"RECVR_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Posted).HasColumnName(@"POSTED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedNever();
            builder.Property(x => x.DocNo).HasColumnName(@"DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Prc).HasColumnName(@"PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.SerCost).HasColumnName(@"SER_COST").HasColumnType("decimal(15,4)").IsRequired(false);
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
            builder.Property(x => x.RtvNo).HasColumnName(@"RTV_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.OrdNo).HasColumnName(@"ORD_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
        }
    }

}
// </auto-generated>

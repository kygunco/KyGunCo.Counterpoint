// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_LWY_HIST_PMT_RCPT
    public class PsLwyHistPmtRcptConfiguration : IEntityTypeConfiguration<PsLwyHistPmtRcpt>
    {
        public void Configure(EntityTypeBuilder<PsLwyHistPmtRcpt> builder)
        {
            builder.ToTable("PS_LWY_HIST_PMT_RCPT", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.PmtSeqNo }).HasName("PK_PS_LWY_HIST_PMT_RCPT").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PmtSeqNo).HasColumnName(@"PMT_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.TransTyp).HasColumnName(@"TRANS_TYP").HasColumnType("varchar(2)").IsRequired().IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.UniqueTransId).HasColumnName(@"UNIQUE_TRANS_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.TransStat).HasColumnName(@"TRANS_STAT").HasColumnType("varchar(2)").IsRequired().IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.RcptAuthCod).HasColumnName(@"RCPT_AUTH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TransApproved).HasColumnName(@"TRANS_APPROVED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ProcessorTransId).HasColumnName(@"PROCESSOR_TRANS_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RcptCardNoMsk).HasColumnName(@"RCPT_CARD_NO_MSK").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.RcptAcctTyp).HasColumnName(@"RCPT_ACCT_TYP").HasColumnType("varchar(2)").IsRequired().IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.RcptCardTyp).HasColumnName(@"RCPT_CARD_TYP").HasColumnType("varchar(2)").IsRequired().IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.RcptTransDat).HasColumnName(@"RCPT_TRANS_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RcptTransTim).HasColumnName(@"RCPT_TRANS_TIM").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProcessorRefNo).HasColumnName(@"PROCESSOR_REF_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RcptAmt).HasColumnName(@"RCPT_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.RcptLang).HasColumnName(@"RCPT_LANG").HasColumnType("varchar(2)").IsRequired().IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.ProcessorMsg).HasColumnName(@"PROCESSOR_MSG").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.ErrorMsg).HasColumnName(@"ERROR_MSG").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.RcptStrId).HasColumnName(@"RCPT_STR_ID").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.RcptTermId).HasColumnName(@"RCPT_TERM_ID").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.RcptMsg).HasColumnName(@"RCPT_MSG").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.EntryMeth).HasColumnName(@"ENTRY_METH").HasColumnType("varchar(2)").IsRequired().IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.AvsResult).HasColumnName(@"AVS_RESULT").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CvvResult).HasColumnName(@"CVV_RESULT").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CardBalRemain).HasColumnName(@"CARD_BAL_REMAIN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ProcessorClientRcpt).HasColumnName(@"PROCESSOR_CLIENT_RCPT").HasColumnType("varchar(7000)").IsRequired(false).IsUnicode(false).HasMaxLength(7000);
            builder.Property(x => x.ProcessorMerchRcpt).HasColumnName(@"PROCESSOR_MERCH_RCPT").HasColumnType("varchar(7000)").IsRequired(false).IsUnicode(false).HasMaxLength(7000);
            builder.Property(x => x.ProcessorRcpt).HasColumnName(@"PROCESSOR_RCPT").HasColumnType("varchar(7000)").IsRequired(false).IsUnicode(false).HasMaxLength(7000);
            builder.Property(x => x.CardPlan).HasColumnName(@"CARD_PLAN").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.AppId).HasColumnName(@"APP_ID").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.AppLbl).HasColumnName(@"APP_LBL").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.AppPrefNam).HasColumnName(@"APP_PREF_NAM").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Arqc).HasColumnName(@"ARQC").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Tvrarqc).HasColumnName(@"TVRARQC").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Tcacc).HasColumnName(@"TCACC").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Tvrtcacc).HasColumnName(@"TVRTCACC").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.CardholderVerifyMeth).HasColumnName(@"CARDHOLDER_VERIFY_METH").HasColumnType("varchar(2)").IsRequired(false).IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.ResponseCod).HasColumnName(@"RESPONSE_COD").HasColumnType("varchar(3)").IsRequired(false).IsUnicode(false).HasMaxLength(3);
            builder.Property(x => x.Tsi).HasColumnName(@"TSI").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);

            // Foreign keys
            builder.HasOne(a => a.PsLwyHistPmt).WithOne(b => b.PsLwyHistPmtRcpt).HasForeignKey<PsLwyHistPmtRcpt>(c => new { c.BusDat, c.DocId, c.PmtSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_LWY_HIST_PMT_RCPT_PS_LWY_HIST_PMT");
        }
    }

}
// </auto-generated>
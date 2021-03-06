// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_LWY_ORD_ACTIV
    public class ViPsLwyOrdActivConfiguration : IEntityTypeConfiguration<ViPsLwyOrdActiv>
    {
        public void Configure(EntityTypeBuilder<ViPsLwyOrdActiv> builder)
        {
            builder.ToView("VI_PS_LWY_ORD_ACTIV", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.Type).HasColumnName(@"TYPE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DrwId).HasColumnName(@"DRW_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DocTyp).HasColumnName(@"DOC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktDat).HasColumnName(@"TKT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.TktTim).HasColumnName(@"TKT_TIM").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Tot).HasColumnName(@"TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotMisc).HasColumnName(@"TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TaxAmt).HasColumnName(@"TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AmtDue).HasColumnName(@"AMT_DUE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotTnd).HasColumnName(@"TOT_TND").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotChng).HasColumnName(@"TOT_CHNG").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.NetTnd).HasColumnName(@"NET_TND").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.SubTot).HasColumnName(@"SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocCancelDepRefund).HasColumnName(@"DOC_CANCEL_DEP_REFUND").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocCancelDepForf).HasColumnName(@"DOC_CANCEL_DEP_FORF").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocDepReceived).HasColumnName(@"DOC_DEP_RECEIVED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocDepApplied).HasColumnName(@"DOC_DEP_APPLIED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocDepRefunded).HasColumnName(@"DOC_DEP_REFUNDED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocDepForfeit).HasColumnName(@"DOC_DEP_FORFEIT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocStat).HasColumnName(@"DOC_STAT").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AuditStrId).HasColumnName(@"AUDIT_STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AuditStaId).HasColumnName(@"AUDIT_STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AuditDrwId).HasColumnName(@"AUDIT_DRW_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AuditUsrId).HasColumnName(@"AUDIT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AuditCurrDt).HasColumnName(@"AUDIT_CURR_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.AuditCurrDat).HasColumnName(@"AUDIT_CURR_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.AuditCurrTim).HasColumnName(@"AUDIT_CURR_TIM").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.CurrWkstnNam).HasColumnName(@"CURR_WKSTN_NAM").HasColumnType("varchar(128)").IsRequired(false).IsUnicode(false).HasMaxLength(128);
            builder.Property(x => x.Activ).HasColumnName(@"ACTIV").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LwyLins).HasColumnName(@"LWY_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.OrdLins).HasColumnName(@"ORD_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.AuditLinkStrId).HasColumnName(@"AUDIT_LINK_STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AuditLinkStaId).HasColumnName(@"AUDIT_LINK_STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AuditLinkTktNo).HasColumnName(@"AUDIT_LINK_TKT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.AuditDocTyp).HasColumnName(@"AUDIT_DOC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LwyNetTnd).HasColumnName(@"LWY_NET_TND").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.OrdNetTnd).HasColumnName(@"ORD_NET_TND").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.LwyAmtDue).HasColumnName(@"LWY_AMT_DUE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdAmtDue).HasColumnName(@"ORD_AMT_DUE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyTaxAmt).HasColumnName(@"LWY_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTaxAmt).HasColumnName(@"ORD_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwySubTot).HasColumnName(@"LWY_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdSubTot).HasColumnName(@"ORD_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyTot).HasColumnName(@"LWY_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTot).HasColumnName(@"ORD_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyTotMisc).HasColumnName(@"LWY_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotMisc).HasColumnName(@"ORD_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
        }
    }

}
// </auto-generated>

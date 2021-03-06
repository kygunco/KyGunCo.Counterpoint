// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_DOC_AUDIT_LOG
    public class ViPsDocAuditLogConfiguration : IEntityTypeConfiguration<ViPsDocAuditLog>
    {
        public void Configure(EntityTypeBuilder<ViPsDocAuditLog> builder)
        {
            builder.ToView("VI_PS_DOC_AUDIT_LOG", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.LogSeqNo).HasColumnName(@"LOG_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Activ).HasColumnName(@"ACTIV").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LogEntry).HasColumnName(@"LOG_ENTRY").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.CurrStrId).HasColumnName(@"CURR_STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CurrStaId).HasColumnName(@"CURR_STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CurrDrwId).HasColumnName(@"CURR_DRW_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CurrUsrId).HasColumnName(@"CURR_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CurrWkstnNam).HasColumnName(@"CURR_WKSTN_NAM").HasColumnType("varchar(128)").IsRequired(false).IsUnicode(false).HasMaxLength(128);
            builder.Property(x => x.CurrServNam).HasColumnName(@"CURR_SERV_NAM").HasColumnType("varchar(128)").IsRequired(false).IsUnicode(false).HasMaxLength(128);
            builder.Property(x => x.CurrDbNam).HasColumnName(@"CURR_DB_NAM").HasColumnType("varchar(128)").IsRequired(false).IsUnicode(false).HasMaxLength(128);
            builder.Property(x => x.CurrDt).HasColumnName(@"CURR_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.CurrDat).HasColumnName(@"CURR_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.CurrTim).HasColumnName(@"CURR_TIM").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.DocTyp).HasColumnName(@"DOC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DocGuid).HasColumnName(@"DOC_GUID").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.LinkStrId).HasColumnName(@"LINK_STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LinkStaId).HasColumnName(@"LINK_STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LinkDocNo).HasColumnName(@"LINK_DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LinkTktNo).HasColumnName(@"LINK_TKT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LinkDocGuid).HasColumnName(@"LINK_DOC_GUID").HasColumnType("uniqueidentifier").IsRequired(false);
            builder.Property(x => x.SalLins).HasColumnName(@"SAL_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SalSubTot).HasColumnName(@"SAL_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotSvcAmt).HasColumnName(@"SAL_TOT_SVC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotGfcAmt).HasColumnName(@"SAL_TOT_GFC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotMisc).HasColumnName(@"SAL_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalNormTaxAmt).HasColumnName(@"SAL_NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTaxAmt).HasColumnName(@"SAL_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotExtCost).HasColumnName(@"SAL_TOT_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotEstCost).HasColumnName(@"SAL_TOT_EST_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTot).HasColumnName(@"SAL_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotTnd).HasColumnName(@"SAL_TOT_TND").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotChng).HasColumnName(@"SAL_TOT_CHNG").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalNetTnd).HasColumnName(@"SAL_NET_TND").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.SalAmtDue).HasColumnName(@"SAL_AMT_DUE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DepNetChange).HasColumnName(@"DEP_NET_CHANGE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdLins).HasColumnName(@"ORD_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.OrdSubTot).HasColumnName(@"ORD_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotMisc).HasColumnName(@"ORD_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdNormTaxAmt).HasColumnName(@"ORD_NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTaxAmt).HasColumnName(@"ORD_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotExtCost).HasColumnName(@"ORD_TOT_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotEstCost).HasColumnName(@"ORD_TOT_EST_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTot).HasColumnName(@"ORD_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotTnd).HasColumnName(@"ORD_TOT_TND").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotChng).HasColumnName(@"ORD_TOT_CHNG").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdNetTnd).HasColumnName(@"ORD_NET_TND").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.OrdAmtDue).HasColumnName(@"ORD_AMT_DUE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyLins).HasColumnName(@"LWY_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LwySubTot).HasColumnName(@"LWY_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyTotMisc).HasColumnName(@"LWY_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyNormTaxAmt).HasColumnName(@"LWY_NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyTaxAmt).HasColumnName(@"LWY_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyTotExtCost).HasColumnName(@"LWY_TOT_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyTotEstCost).HasColumnName(@"LWY_TOT_EST_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyTot).HasColumnName(@"LWY_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyTotTnd).HasColumnName(@"LWY_TOT_TND").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyTotChng).HasColumnName(@"LWY_TOT_CHNG").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyNetTnd).HasColumnName(@"LWY_NET_TND").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.LwyAmtDue).HasColumnName(@"LWY_AMT_DUE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.Lins).HasColumnName(@"LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SubTot).HasColumnName(@"SUB_TOT").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotSvcAmt).HasColumnName(@"TOT_SVC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotGfcAmt).HasColumnName(@"TOT_GFC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotMisc).HasColumnName(@"TOT_MISC").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.NormTaxAmt).HasColumnName(@"NORM_TAX_AMT").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TaxAmt).HasColumnName(@"TAX_AMT").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotExtCost).HasColumnName(@"TOT_EXT_COST").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotEstCost).HasColumnName(@"TOT_EST_COST").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.Tot).HasColumnName(@"TOT").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotTnd).HasColumnName(@"TOT_TND").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotChng).HasColumnName(@"TOT_CHNG").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.AmtDue).HasColumnName(@"AMT_DUE").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.NetTnd).HasColumnName(@"NET_TND").HasColumnType("decimal(20,2)").IsRequired(false);
        }
    }

}
// </auto-generated>

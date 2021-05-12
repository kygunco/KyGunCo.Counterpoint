// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PS_VOID_HIST_AUDIT_LOG
    public class ViPsVoidHistAuditLog
    {
        public DateTime BusDat { get; set; } // BUS_DAT
        public long DocId { get; set; } // DOC_ID
        public int LogSeqNo { get; set; } // LOG_SEQ_NO
        public int SeqNo { get; set; } // SEQ_NO
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public string Activ { get; set; } // ACTIV (length: 1)
        public string LogEntry { get; set; } // LOG_ENTRY (length: 250)
        public string CurrStrId { get; set; } // CURR_STR_ID (length: 10)
        public string CurrStaId { get; set; } // CURR_STA_ID (length: 10)
        public string CurrDrwId { get; set; } // CURR_DRW_ID (length: 10)
        public string CurrUsrId { get; set; } // CURR_USR_ID (length: 10)
        public string CurrWkstnNam { get; set; } // CURR_WKSTN_NAM (length: 128)
        public string CurrServNam { get; set; } // CURR_SERV_NAM (length: 128)
        public string CurrDbNam { get; set; } // CURR_DB_NAM (length: 128)
        public DateTime? CurrDt { get; set; } // CURR_DT
        public DateTime? CurrDat { get; set; } // CURR_DAT
        public DateTime? CurrTim { get; set; } // CURR_TIM
        public string DocTyp { get; set; } // DOC_TYP (length: 1)
        public Guid DocGuid { get; set; } // DOC_GUID
        public string LinkStrId { get; set; } // LINK_STR_ID (length: 10)
        public string LinkStaId { get; set; } // LINK_STA_ID (length: 10)
        public string LinkDocNo { get; set; } // LINK_DOC_NO (length: 15)
        public string LinkTktNo { get; set; } // LINK_TKT_NO (length: 15)
        public Guid? LinkDocGuid { get; set; } // LINK_DOC_GUID
        public int? SalLins { get; set; } // SAL_LINS
        public decimal? SalSubTot { get; set; } // SAL_SUB_TOT
        public decimal? SalTotSvcAmt { get; set; } // SAL_TOT_SVC_AMT
        public decimal? SalTotGfcAmt { get; set; } // SAL_TOT_GFC_AMT
        public decimal? SalTotMisc { get; set; } // SAL_TOT_MISC
        public decimal? SalNormTaxAmt { get; set; } // SAL_NORM_TAX_AMT
        public decimal? SalTaxAmt { get; set; } // SAL_TAX_AMT
        public decimal? SalTotExtCost { get; set; } // SAL_TOT_EXT_COST
        public decimal? SalTotEstCost { get; set; } // SAL_TOT_EST_COST
        public decimal? SalTot { get; set; } // SAL_TOT
        public decimal? SalTotTnd { get; set; } // SAL_TOT_TND
        public decimal? SalTotChng { get; set; } // SAL_TOT_CHNG
        public decimal? SalNetTnd { get; set; } // SAL_NET_TND
        public decimal? SalAmtDue { get; set; } // SAL_AMT_DUE
        public decimal? DepNetChange { get; set; } // DEP_NET_CHANGE
        public int? OrdLins { get; set; } // ORD_LINS
        public decimal? OrdSubTot { get; set; } // ORD_SUB_TOT
        public decimal? OrdTotMisc { get; set; } // ORD_TOT_MISC
        public decimal? OrdNormTaxAmt { get; set; } // ORD_NORM_TAX_AMT
        public decimal? OrdTaxAmt { get; set; } // ORD_TAX_AMT
        public decimal? OrdTotExtCost { get; set; } // ORD_TOT_EXT_COST
        public decimal? OrdTotEstCost { get; set; } // ORD_TOT_EST_COST
        public decimal? OrdTot { get; set; } // ORD_TOT
        public decimal? OrdTotTnd { get; set; } // ORD_TOT_TND
        public decimal? OrdTotChng { get; set; } // ORD_TOT_CHNG
        public decimal? OrdNetTnd { get; set; } // ORD_NET_TND
        public decimal? OrdAmtDue { get; set; } // ORD_AMT_DUE
        public int? LwyLins { get; set; } // LWY_LINS
        public decimal? LwySubTot { get; set; } // LWY_SUB_TOT
        public decimal? LwyTotMisc { get; set; } // LWY_TOT_MISC
        public decimal? LwyNormTaxAmt { get; set; } // LWY_NORM_TAX_AMT
        public decimal? LwyTaxAmt { get; set; } // LWY_TAX_AMT
        public decimal? LwyTotExtCost { get; set; } // LWY_TOT_EXT_COST
        public decimal? LwyTotEstCost { get; set; } // LWY_TOT_EST_COST
        public decimal? LwyTot { get; set; } // LWY_TOT
        public decimal? LwyTotTnd { get; set; } // LWY_TOT_TND
        public decimal? LwyTotChng { get; set; } // LWY_TOT_CHNG
        public decimal? LwyNetTnd { get; set; } // LWY_NET_TND
        public decimal? LwyAmtDue { get; set; } // LWY_AMT_DUE
        public int? Lins { get; set; } // LINS
        public decimal? SubTot { get; set; } // SUB_TOT
        public decimal? TotSvcAmt { get; set; } // TOT_SVC_AMT
        public decimal? TotGfcAmt { get; set; } // TOT_GFC_AMT
        public decimal? TotMisc { get; set; } // TOT_MISC
        public decimal? NormTaxAmt { get; set; } // NORM_TAX_AMT
        public decimal? TaxAmt { get; set; } // TAX_AMT
        public decimal? TotExtCost { get; set; } // TOT_EXT_COST
        public decimal? TotEstCost { get; set; } // TOT_EST_COST
        public decimal? Tot { get; set; } // TOT
        public decimal? TotTnd { get; set; } // TOT_TND
        public decimal? TotChng { get; set; } // TOT_CHNG
        public decimal? AmtDue { get; set; } // AMT_DUE
        public decimal? NetTnd { get; set; } // NET_TND
    }

}
// </auto-generated>

// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_REAS_COD
    public class PsReasCod
    {
        public string ReasCod { get; set; } // REAS_COD (Primary key) (length: 10)
        public string Descr { get; set; } // DESCR (length: 30)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 30)
        public string ValRet { get; set; } = "N"; // VAL_RET (length: 1)
        public string ValPrcChng { get; set; } = "N"; // VAL_PRC_CHNG (length: 1)
        public string ValVoidCompTkt { get; set; } = "N"; // VAL_VOID_COMP_TKT (length: 1)
        public string ValTktTaxOvrd { get; set; } = "N"; // VAL_TKT_TAX_OVRD (length: 1)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public string ValScrapInv { get; set; } = "N"; // VAL_SCRAP_INV (length: 1)
        public string ScrapReasonCod { get; set; } // SCRAP_REASON_COD (length: 15)
        public byte RsStat { get; set; } = 1; // RS_STAT

        // Foreign keys

        /// <summary>
        /// Parent ImAdjReasCod pointed by [PS_REAS_COD].([ScrapReasonCod]) (FK_PS_REAS_COD_IM_ADJ_REAS_COD)
        /// </summary>
        public virtual ImAdjReasCod ImAdjReasCod { get; set; } // FK_PS_REAS_COD_IM_ADJ_REAS_COD
    }

}
// </auto-generated>
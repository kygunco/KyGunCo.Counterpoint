// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_ADJ_REAS_COD
    public class ImAdjReasCod
    {
        public string ReasCod { get; set; } // REAS_COD (Primary key) (length: 15)
        public string Descr { get; set; } // DESCR (length: 30)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 30)
        public string AdjExpAcctNo { get; set; } // ADJ_EXP_ACCT_NO (length: 20)
        public string AdjExpMeth { get; set; } = "!"; // ADJ_EXP_METH (length: 1)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT

        // Reverse navigation

        /// <summary>
        /// Child ImAdjTrxes where [IM_ADJ_TRX].[REAS_COD] point to this entity (FK_IM_ADJ_TRX_IM_ADJ_REAS_COD)
        /// </summary>
        public virtual IList<ImAdjTrx> ImAdjTrxes { get; set; } = new List<ImAdjTrx>(); // IM_ADJ_TRX.FK_IM_ADJ_TRX_IM_ADJ_REAS_COD

        /// <summary>
        /// Child PsReasCods where [PS_REAS_COD].[SCRAP_REASON_COD] point to this entity (FK_PS_REAS_COD_IM_ADJ_REAS_COD)
        /// </summary>
        public virtual IList<PsReasCod> PsReasCods { get; set; } = new List<PsReasCod>(); // PS_REAS_COD.FK_PS_REAS_COD_IM_ADJ_REAS_COD

        // Foreign keys

        /// <summary>
        /// Parent SyAcct pointed by [IM_ADJ_REAS_COD].([AdjExpAcctNo]) (FK_IM_ADJ_REAS_COD_SY_ACCT)
        /// </summary>
        public virtual SyAcct SyAcct { get; set; } // FK_IM_ADJ_REAS_COD_SY_ACCT
    }

}
// </auto-generated>

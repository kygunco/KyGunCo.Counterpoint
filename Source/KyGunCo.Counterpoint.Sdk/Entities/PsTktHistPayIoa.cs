// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_TKT_HIST_PAY_IOA
    public class PsTktHistPayIoa
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public string DocDescr { get; set; } // DOC_DESCR (length: 30)
        public string PayAcctNo { get; set; } // PAY_ACCT_NO (length: 20)
        public string PayApplyMeth { get; set; } = "S"; // PAY_APPLY_METH (length: 1)
        public decimal? PayAmt { get; set; } = 0m; // PAY_AMT

        // Reverse navigation

        /// <summary>
        /// Child PsTktHistPayIoaApplyToes where [PS_TKT_HIST_PAY_IOA_APPLY_TO].([BUS_DAT], [DOC_ID]) point to this entity (FK_PS_TKT_HIST_PAY_IOA_APPLY_TO_PS_TKT_HIST_PAY_IOA)
        /// </summary>
        public virtual IList<PsTktHistPayIoaApplyTo> PsTktHistPayIoaApplyToes { get; set; } = new List<PsTktHistPayIoaApplyTo>(); // PS_TKT_HIST_PAY_IOA_APPLY_TO.FK_PS_TKT_HIST_PAY_IOA_APPLY_TO_PS_TKT_HIST_PAY_IOA

        // Foreign keys

        /// <summary>
        /// Parent PsTktHist pointed by [PS_TKT_HIST_PAY_IOA].([BusDat], [DocId]) (FK_PS_TKT_HIST_PAY_IOA_PS_TKT_HIST)
        /// </summary>
        public virtual PsTktHist PsTktHist { get; set; } // FK_PS_TKT_HIST_PAY_IOA_PS_TKT_HIST
    }

}
// </auto-generated>

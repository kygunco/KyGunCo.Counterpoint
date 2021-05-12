// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_VOID_HIST_PAY_IOA
    public class PsVoidHistPayIoa
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public string DocDescr { get; set; } // DOC_DESCR (length: 30)
        public string PayAcctNo { get; set; } // PAY_ACCT_NO (length: 20)
        public string PayApplyMeth { get; set; } = "S"; // PAY_APPLY_METH (length: 1)
        public decimal? PayAmt { get; set; } = 0m; // PAY_AMT

        // Reverse navigation

        /// <summary>
        /// Child PsVoidHistPayIoaApplyToes where [PS_VOID_HIST_PAY_IOA_APPLY_TO].([BUS_DAT], [DOC_ID]) point to this entity (FK_PS_VOID_HIST_PAY_IOA_APPLY_TO_PS_VOID_HIST_PAY_IOA)
        /// </summary>
        public virtual IList<PsVoidHistPayIoaApplyTo> PsVoidHistPayIoaApplyToes { get; set; } = new List<PsVoidHistPayIoaApplyTo>(); // PS_VOID_HIST_PAY_IOA_APPLY_TO.FK_PS_VOID_HIST_PAY_IOA_APPLY_TO_PS_VOID_HIST_PAY_IOA

        // Foreign keys

        /// <summary>
        /// Parent PsVoidHist pointed by [PS_VOID_HIST_PAY_IOA].([BusDat], [DocId]) (FK_PS_VOID_HIST_PAY_IOA_PS_VOID_HIST)
        /// </summary>
        public virtual PsVoidHist PsVoidHist { get; set; } // FK_PS_VOID_HIST_PAY_IOA_PS_VOID_HIST
    }

}
// </auto-generated>

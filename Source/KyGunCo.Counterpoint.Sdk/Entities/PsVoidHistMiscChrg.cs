// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_VOID_HIST_MISC_CHRG
    public class PsVoidHistMiscChrg
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int MiscChrgNo { get; set; } // MISC_CHRG_NO (Primary key)
        public string MiscTyp { get; set; } = "N"; // MISC_TYP (length: 1)
        public decimal MiscAmt { get; set; } // MISC_AMT
        public decimal MiscPct { get; set; } // MISC_PCT
        public decimal MiscTaxAmtAlloc { get; set; } = 0m; // MISC_TAX_AMT_ALLOC
        public decimal MiscNormTaxAmtAlloc { get; set; } = 0m; // MISC_NORM_TAX_AMT_ALLOC

        // Foreign keys

        /// <summary>
        /// Parent PsVoidHist pointed by [PS_VOID_HIST_MISC_CHRG].([BusDat], [DocId]) (FK_PS_VOID_HIST_MISC_CHRG_PS_VOID_HIST)
        /// </summary>
        public virtual PsVoidHist PsVoidHist { get; set; } // FK_PS_VOID_HIST_MISC_CHRG_PS_VOID_HIST
    }

}
// </auto-generated>

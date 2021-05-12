// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PS_VOID_HIST_PAY_IOA_APPLY_TO
    public class ViPsVoidHistPayIoaApplyTo
    {
        public DateTime BusDat { get; set; } // BUS_DAT
        public long DocId { get; set; } // DOC_ID
        public int SeqNo { get; set; } // SEQ_NO
        public string ApplyToDocNo { get; set; } // APPLY_TO_DOC_NO (length: 15)
        public DateTime ApplyToDocDat { get; set; } // APPLY_TO_DOC_DAT
        public string ApplyToDocTyp { get; set; } // APPLY_TO_DOC_TYP (length: 1)
        public decimal Amt { get; set; } // AMT
    }

}
// </auto-generated>

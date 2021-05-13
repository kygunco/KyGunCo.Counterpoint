// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_VOID_HIST_GFC
    public class PsVoidHistGfc
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public string GfcCod { get; set; } // GFC_COD (length: 10)
        public int GfcSeqNo { get; set; } // GFC_SEQ_NO (Primary key)
        public string GfcNo { get; set; } // GFC_NO (length: 30)
        public string Descr { get; set; } // DESCR (length: 30)
        public decimal Amt { get; set; } // AMT
        public string CreateAsStc { get; set; } = "N"; // CREATE_AS_STC (length: 1)
        public int? LinSeqNo { get; set; } // LIN_SEQ_NO

        // Foreign keys

        /// <summary>
        /// Parent PsVoidHist pointed by [PS_VOID_HIST_GFC].([BusDat], [DocId]) (FK_PS_VOID_HIST_GFC_PS_VOID_HIST)
        /// </summary>
        public virtual PsVoidHist PsVoidHist { get; set; } // FK_PS_VOID_HIST_GFC_PS_VOID_HIST
    }

}
// </auto-generated>
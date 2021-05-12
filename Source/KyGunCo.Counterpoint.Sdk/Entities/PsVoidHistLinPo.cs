// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_VOID_HIST_LIN_PO
    public class PsVoidHistLinPo
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int LinSeqNo { get; set; } // LIN_SEQ_NO (Primary key)
        public string PoPreqNo { get; set; } // PO_PREQ_NO (length: 15)
        public string PoOrdNo { get; set; } // PO_ORD_NO (length: 20)
        public int? PoLinSeqNo { get; set; } // PO_LIN_SEQ_NO
        public string PoRecvrNo { get; set; } // PO_RECVR_NO (length: 15)
        public int? PoRecvrLinSeqNo { get; set; } // PO_RECVR_LIN_SEQ_NO
        public decimal? PoTotQtyRecvd { get; set; } // PO_TOT_QTY_RECVD
        public decimal? PoQtyExpectd { get; set; } // PO_QTY_EXPECTD
        public int? PoRecvrCnt { get; set; } // PO_RECVR_CNT

        // Foreign keys

        /// <summary>
        /// Parent PsVoidHistLin pointed by [PS_VOID_HIST_LIN_PO].([BusDat], [DocId], [LinSeqNo]) (FK_PS_VOID_HIST_LIN_PO_PS_VOID_HIST_LIN)
        /// </summary>
        public virtual PsVoidHistLin PsVoidHistLin { get; set; } // FK_PS_VOID_HIST_LIN_PO_PS_VOID_HIST_LIN
    }

}
// </auto-generated>

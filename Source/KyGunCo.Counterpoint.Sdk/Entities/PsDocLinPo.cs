// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DOC_LIN_PO
    public class PsDocLinPo
    {
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
        public Guid? PoPreqOrPoDocGuid { get; set; } // PO_PREQ_OR_PO_DOC_GUID
        public Guid? PoPreqOrPoLinGuid { get; set; } // PO_PREQ_OR_PO_LIN_GUID

        // Foreign keys

        /// <summary>
        /// Parent PsDocLin pointed by [PS_DOC_LIN_PO].([DocId], [LinSeqNo]) (FK_PS_DOC_LIN_PO_PS_DOC_LIN)
        /// </summary>
        public virtual PsDocLin PsDocLin { get; set; } // FK_PS_DOC_LIN_PO_PS_DOC_LIN
    }

}
// </auto-generated>

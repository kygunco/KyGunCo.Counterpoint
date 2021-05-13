// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PS_VALIDATED_RETURNS_LIN_CELL
    public class ViPsValidatedReturnsLinCell
    {
        public DateTime? BusDat { get; set; } // BUS_DAT
        public long DocId { get; set; } // DOC_ID
        public int LinSeqNo { get; set; } // LIN_SEQ_NO
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public decimal QtySold { get; set; } // QTY_SOLD
        public decimal QtyRet { get; set; } // QTY_RET
    }

}
// </auto-generated>
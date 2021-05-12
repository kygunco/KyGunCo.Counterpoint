// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_XFER_OUT_CELL
    public class ImXferOutCell
    {
        public string XferNo { get; set; } // XFER_NO (Primary key) (length: 15)
        public int XferLinSeqNo { get; set; } // XFER_LIN_SEQ_NO (Primary key)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public decimal XferQty { get; set; } // XFER_QTY
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent ImXferOutLin pointed by [IM_XFER_OUT_CELL].([XferNo], [XferLinSeqNo]) (FK_IM_XFER_OUT_CELL_IM_XFER_OUT_LIN)
        /// </summary>
        public virtual ImXferOutLin ImXferOutLin { get; set; } // FK_IM_XFER_OUT_CELL_IM_XFER_OUT_LIN
    }

}
// </auto-generated>

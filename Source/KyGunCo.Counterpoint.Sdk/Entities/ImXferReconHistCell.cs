// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_XFER_RECON_HIST_CELL
    public class ImXferReconHistCell
    {
        public string XferNo { get; set; } // XFER_NO (Primary key) (length: 15)
        public int XferLinSeqNo { get; set; } // XFER_LIN_SEQ_NO (Primary key)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public decimal XferQty { get; set; } // XFER_QTY
        public decimal? QtyRecvd { get; set; } // QTY_RECVD
        public decimal? FromQohBefore { get; set; } // FROM_QOH_BEFORE
        public decimal? FromQohAfter { get; set; } // FROM_QOH_AFTER
        public decimal? ToQohBefore { get; set; } // TO_QOH_BEFORE
        public decimal? ToQohAfter { get; set; } // TO_QOH_AFTER
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public decimal? QtyVariance { get; private set; } // QTY_VARIANCE

        // Foreign keys

        /// <summary>
        /// Parent ImXferReconHistLin pointed by [IM_XFER_RECON_HIST_CELL].([XferNo], [XferLinSeqNo]) (FK_IM_XFER_RECON_HIST_CELL_IM_XFER_RECON_HIST_LIN)
        /// </summary>
        public virtual ImXferReconHistLin ImXferReconHistLin { get; set; } // FK_IM_XFER_RECON_HIST_CELL_IM_XFER_RECON_HIST_LIN
    }

}
// </auto-generated>

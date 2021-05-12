// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PO_QRECV_TRX_CELL
    public class PoQrecvTrxCell
    {
        public string BatId { get; set; } // BAT_ID (Primary key) (length: 10)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public DateTime TrxDat { get; set; } = DateTime.Now; // TRX_DAT (Primary key)
        public int SeqNo { get; set; } = 1; // SEQ_NO (Primary key)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public decimal Qty { get; set; } // QTY
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent PoQrecvTrx pointed by [PO_QRECV_TRX_CELL].([BatId], [ItemNo], [LocId], [TrxDat], [SeqNo]) (FK_PO_QRECV_TRX_CELL_PO_QRECV_TRX)
        /// </summary>
        public virtual PoQrecvTrx PoQrecvTrx { get; set; } // FK_PO_QRECV_TRX_CELL_PO_QRECV_TRX
    }

}
// </auto-generated>

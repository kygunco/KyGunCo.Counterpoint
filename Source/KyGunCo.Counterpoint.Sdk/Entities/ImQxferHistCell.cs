// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_QXFER_HIST_CELL
    public class ImQxferHistCell
    {
        public string EventNo { get; set; } // EVENT_NO (Primary key) (length: 15)
        public string BatId { get; set; } // BAT_ID (Primary key) (length: 10)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string FromLocId { get; set; } // FROM_LOC_ID (Primary key) (length: 10)
        public string ToLocId { get; set; } // TO_LOC_ID (Primary key) (length: 10)
        public DateTime TrxDat { get; set; } = DateTime.Now; // TRX_DAT (Primary key)
        public int SeqNo { get; set; } = 1; // SEQ_NO (Primary key)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public decimal Qty { get; set; } // QTY
        public decimal FromQohBefore { get; set; } = 0m; // FROM_QOH_BEFORE
        public decimal ToQohBefore { get; set; } = 0m; // TO_QOH_BEFORE
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent ImQxferHist pointed by [IM_QXFER_HIST_CELL].([EventNo], [BatId], [ItemNo], [FromLocId], [ToLocId], [TrxDat], [SeqNo]) (FK_IM_QXFER_HIST_CELL_IM_QXFER_HIST)
        /// </summary>
        public virtual ImQxferHist ImQxferHist { get; set; } // FK_IM_QXFER_HIST_CELL_IM_QXFER_HIST
    }

}
// </auto-generated>

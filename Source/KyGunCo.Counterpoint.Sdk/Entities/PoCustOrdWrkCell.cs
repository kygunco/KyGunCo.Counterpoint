// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PO_CUST_ORD_WRK_CELL
    public class PoCustOrdWrkCell
    {
        public Guid SessId { get; set; } // SESS_ID (Primary key)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public int TktLinSeqNo { get; set; } // TKT_LIN_SEQ_NO (Primary key)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public decimal? Qty { get; set; } // QTY
        public decimal? QtyOnHnd { get; set; } = 0m; // QTY_ON_HND
        public decimal? QtyOnPo { get; set; } = 0m; // QTY_ON_PO
        public decimal? QtyCommit { get; set; } = 0m; // QTY_COMMIT
        public decimal? QtyOnBo { get; set; } = 0m; // QTY_ON_BO
        public decimal MinQty { get; set; } = 0m; // MIN_QTY
        public decimal MaxQty { get; set; } = 0m; // MAX_QTY
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public decimal? QtyOnSo { get; set; } = 0m; // QTY_ON_SO
        public decimal? QtyOnOrd { get; set; } = 0m; // QTY_ON_ORD
        public decimal? QtyOnLwy { get; set; } = 0m; // QTY_ON_LWY
        public decimal? NetQty { get; private set; } // NET_QTY
        public decimal? QtyAvail { get; private set; } // QTY_AVAIL
        public long DocId { get; set; } // DOC_ID (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent PoCustOrdWrk pointed by [PO_CUST_ORD_WRK_CELL].([SessId], [DocId], [TktLinSeqNo]) (FK_PO_CUST_ORD_WRK_CELL_PO_CUST_ORD_WRK)
        /// </summary>
        public virtual PoCustOrdWrk PoCustOrdWrk { get; set; } // FK_PO_CUST_ORD_WRK_CELL_PO_CUST_ORD_WRK
    }

}
// </auto-generated>

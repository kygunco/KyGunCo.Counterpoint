// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_INV_COMMIT_TRX_CELL
    public class ViInvCommitTrxCell
    {
        public string Type { get; set; } // TYPE (length: 5)
        public string TypeSortOrder { get; set; } // TYPE_SORT_ORDER (length: 2)
        public string BatId { get; set; } // BAT_ID (length: 10)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string LocId { get; set; } // LOC_ID (length: 10)
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public DateTime? TrxDat { get; set; } // TRX_DAT
        public int SeqNo { get; set; } // SEQ_NO
        public decimal? QtyCommit { get; set; } // QTY_COMMIT
        public decimal? QtyOnBo { get; set; } // QTY_ON_BO
        public decimal? QtyOnSo { get; set; } // QTY_ON_SO
        public decimal? QtyOnOrd { get; set; } // QTY_ON_ORD
        public decimal? QtyOnLwy { get; set; } // QTY_ON_LWY
        public decimal? QtyOnPo { get; set; } // QTY_ON_PO
        public decimal? QtyOnXferOut { get; set; } // QTY_ON_XFER_OUT
        public decimal? QtyOnXferIn { get; set; } // QTY_ON_XFER_IN
        public decimal? DropshipQtyOnCustOrd { get; set; } // DROPSHIP_QTY_ON_CUST_ORD
        public decimal? DropshipQtyOnPo { get; set; } // DROPSHIP_QTY_ON_PO
        public string OthrLoc { get; set; } // OTHR_LOC (length: 10)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string DocNo { get; set; } // DOC_NO (length: 20)
    }

}
// </auto-generated>

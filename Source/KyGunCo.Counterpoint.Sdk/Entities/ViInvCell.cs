// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_INV_CELL
    public class ViInvCell
    {
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string LocId { get; set; } // LOC_ID (length: 10)
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public decimal MinQty { get; set; } // MIN_QTY
        public decimal MaxQty { get; set; } // MAX_QTY
        public decimal QtyCommit { get; set; } // QTY_COMMIT
        public decimal QtyOnHnd { get; set; } // QTY_ON_HND
        public decimal QtyOnPo { get; set; } // QTY_ON_PO
        public decimal QtyOnBo { get; set; } // QTY_ON_BO
        public decimal QtyOnXferOut { get; set; } // QTY_ON_XFER_OUT
        public decimal QtyOnXferIn { get; set; } // QTY_ON_XFER_IN
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public decimal QtyOnOrd { get; set; } // QTY_ON_ORD
        public decimal QtyOnLwy { get; set; } // QTY_ON_LWY
        public decimal QtyOnSo { get; set; } // QTY_ON_SO
        public decimal? NetQty { get; set; } // NET_QTY
        public decimal? QtyAvail { get; set; } // QTY_AVAIL
        public string StkStatPerQtyOnHnd { get; set; } // STK_STAT_PER_QTY_ON_HND (length: 1)
        public string StkStatPerQtyAvail { get; set; } // STK_STAT_PER_QTY_AVAIL (length: 1)
        public string StkStatPerNetQty { get; set; } // STK_STAT_PER_NET_QTY (length: 1)
        public decimal? ReordPnt { get; set; } // REORD_PNT
        public decimal? Eoq { get; set; } // EOQ
        public decimal? SftyStk { get; set; } // SFTY_STK
        public DateTime? EoqCalcOn { get; set; } // EOQ_CALC_ON
        public string CellStat { get; set; } // CELL_STAT (length: 1)
        public string IsEcommItemCell { get; set; } // IS_ECOMM_ITEM_CELL (length: 1)
        public decimal DropshipQtyOnCustOrd { get; set; } // DROPSHIP_QTY_ON_CUST_ORD
        public decimal DropshipQtyOnPo { get; set; } // DROPSHIP_QTY_ON_PO
        public string Dim1 { get; set; } // DIM_1 (length: 15)
        public int? Dim1SeqNo { get; set; } // DIM_1_SEQ_NO
        public string Dim2 { get; set; } // DIM_2 (length: 15)
        public int? Dim2SeqNo { get; set; } // DIM_2_SEQ_NO
        public string Dim3 { get; set; } // DIM_3 (length: 15)
        public int? Dim3SeqNo { get; set; } // DIM_3_SEQ_NO
        public string IsStocked { get; set; } // IS_STOCKED (length: 1)
    }

}
// </auto-generated>
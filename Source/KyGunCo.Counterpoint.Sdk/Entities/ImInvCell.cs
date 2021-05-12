// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_INV_CELL
    public class ImInvCell
    {
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public decimal MinQty { get; set; } = 0m; // MIN_QTY
        public decimal MaxQty { get; set; } = 0m; // MAX_QTY
        public decimal QtyCommit { get; set; } = 0m; // QTY_COMMIT
        public decimal QtyOnHnd { get; set; } = 0m; // QTY_ON_HND
        public decimal QtyOnPo { get; set; } = 0m; // QTY_ON_PO
        public decimal QtyOnBo { get; set; } = 0m; // QTY_ON_BO
        public decimal QtyOnXferOut { get; set; } = 0m; // QTY_ON_XFER_OUT
        public decimal QtyOnXferIn { get; set; } = 0m; // QTY_ON_XFER_IN
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public decimal QtyOnOrd { get; set; } = 0m; // QTY_ON_ORD
        public decimal QtyOnLwy { get; set; } = 0m; // QTY_ON_LWY
        public decimal QtyOnSo { get; set; } = 0m; // QTY_ON_SO
        public decimal? NetQty { get; private set; } // NET_QTY
        public decimal? QtyAvail { get; private set; } // QTY_AVAIL
        public string StkStatPerQtyOnHnd { get; private set; } // STK_STAT_PER_QTY_ON_HND (length: 1)
        public string StkStatPerQtyAvail { get; private set; } // STK_STAT_PER_QTY_AVAIL (length: 1)
        public string StkStatPerNetQty { get; private set; } // STK_STAT_PER_NET_QTY (length: 1)
        public decimal? ReordPnt { get; set; } // REORD_PNT
        public decimal? Eoq { get; set; } // EOQ
        public decimal? SftyStk { get; set; } // SFTY_STK
        public DateTime? EoqCalcOn { get; set; } // EOQ_CALC_ON
        public string CellStat { get; set; } = "A"; // CELL_STAT (length: 1)
        public string IsEcommItemCell { get; set; } // IS_ECOMM_ITEM_CELL (length: 1)
        public decimal DropshipQtyOnCustOrd { get; set; } = 0m; // DROPSHIP_QTY_ON_CUST_ORD
        public decimal DropshipQtyOnPo { get; set; } = 0m; // DROPSHIP_QTY_ON_PO

        // Foreign keys

        /// <summary>
        /// Parent ImGridDim1 pointed by [IM_INV_CELL].([ItemNo], [Dim1Upr]) (FK_IM_INV_CELL_IM_GRID_DIM_1)
        /// </summary>
        public virtual ImGridDim1 ImGridDim1 { get; set; } // FK_IM_INV_CELL_IM_GRID_DIM_1

        /// <summary>
        /// Parent ImGridDim2 pointed by [IM_INV_CELL].([ItemNo], [Dim2Upr]) (FK_IM_INV_CELL_IM_GRID_DIM_2)
        /// </summary>
        public virtual ImGridDim2 ImGridDim2 { get; set; } // FK_IM_INV_CELL_IM_GRID_DIM_2

        /// <summary>
        /// Parent ImGridDim3 pointed by [IM_INV_CELL].([ItemNo], [Dim3Upr]) (FK_IM_INV_CELL_IM_GRID_DIM_3)
        /// </summary>
        public virtual ImGridDim3 ImGridDim3 { get; set; } // FK_IM_INV_CELL_IM_GRID_DIM_3

        /// <summary>
        /// Parent ImInv pointed by [IM_INV_CELL].([ItemNo], [LocId]) (FK_IM_INV_CELL_IM_INV)
        /// </summary>
        public virtual ImInv ImInv { get; set; } // FK_IM_INV_CELL_IM_INV
    }

}
// </auto-generated>

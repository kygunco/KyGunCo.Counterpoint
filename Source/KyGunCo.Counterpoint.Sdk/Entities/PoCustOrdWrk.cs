// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PO_CUST_ORD_WRK
    public class PoCustOrdWrk
    {
        public Guid SessId { get; set; } // SESS_ID (Primary key)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public int TktLinSeqNo { get; set; } // TKT_LIN_SEQ_NO (Primary key)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string LocId { get; set; } // LOC_ID (length: 10)
        public decimal? Qty { get; set; } // QTY
        public decimal? QtyNumer { get; set; } = 1m; // QTY_NUMER
        public decimal? QtyDenom { get; set; } = 1m; // QTY_DENOM
        public string CustNo { get; set; } // CUST_NO (length: 15)
        public string BillNam { get; set; } // BILL_NAM (length: 40)
        public DateTime? TktDat { get; set; } // TKT_DAT
        public decimal? QtyOnHnd { get; set; } = 0m; // QTY_ON_HND
        public decimal? QtyOnPo { get; set; } = 0m; // QTY_ON_PO
        public decimal? QtyCommit { get; set; } = 0m; // QTY_COMMIT
        public decimal? QtyOnBo { get; set; } = 0m; // QTY_ON_BO
        public decimal MinQty { get; set; } = 0m; // MIN_QTY
        public decimal MaxQty { get; set; } = 0m; // MAX_QTY
        public decimal? AvgCost { get; set; } // AVG_COST
        public decimal? LstCost { get; set; } = 0m; // LST_COST
        public decimal? UnitRetlVal { get; set; } // UNIT_RETL_VAL
        public string Descr { get; set; } // DESCR (length: 30)
        public string ItemVendNo { get; set; } // ITEM_VEND_NO (length: 15)
        public int? QtyDecs { get; set; } = 0; // QTY_DECS
        public string TrkMeth { get; set; } = "N"; // TRK_METH (length: 1)
        public string VendNo { get; set; } // VEND_NO (length: 15)
        public decimal? VendItemCost { get; set; } // VEND_ITEM_COST
        public string VendItemNo { get; set; } // VEND_ITEM_NO (length: 30)
        public string VendDescr { get; set; } // VEND_DESCR (length: 50)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string LinDescr { get; set; } // LIN_DESCR (length: 50)
        public DateTime? TktTim { get; set; } // TKT_TIM
        public decimal? QtyOnSo { get; set; } = 0m; // QTY_ON_SO
        public decimal? QtyOnOrd { get; set; } = 0m; // QTY_ON_ORD
        public decimal? QtyOnLwy { get; set; } = 0m; // QTY_ON_LWY
        public string Unit { get; set; } // UNIT (length: 15)
        public string QtyUnit { get; set; } = "0"; // QTY_UNIT (length: 1)
        public decimal? CostEntd { get; set; } = 0m; // COST_ENTD
        public string UseCostEntd { get; set; } = "N"; // USE_COST_ENTD (length: 1)
        public decimal? ExtAvgCost { get; private set; } // EXT_AVG_COST
        public decimal? ExtLstCost { get; private set; } // EXT_LST_COST
        public decimal? ExtRetlPrc { get; private set; } // EXT_RETL_PRC
        public decimal? ExtVendItemCost { get; private set; } // EXT_VEND_ITEM_COST
        public decimal? NetQty { get; private set; } // NET_QTY
        public decimal? QtyAvail { get; private set; } // QTY_AVAIL
        public long DocId { get; set; } // DOC_ID (Primary key)

        // Reverse navigation

        /// <summary>
        /// Child PoCustOrdWrkCells where [PO_CUST_ORD_WRK_CELL].([DOC_ID], [SESS_ID], [TKT_LIN_SEQ_NO]) point to this entity (FK_PO_CUST_ORD_WRK_CELL_PO_CUST_ORD_WRK)
        /// </summary>
        public virtual IList<PoCustOrdWrkCell> PoCustOrdWrkCells { get; set; } = new List<PoCustOrdWrkCell>(); // PO_CUST_ORD_WRK_CELL.FK_PO_CUST_ORD_WRK_CELL_PO_CUST_ORD_WRK
    }

}
// </auto-generated>
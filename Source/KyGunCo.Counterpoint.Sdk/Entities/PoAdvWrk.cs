// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PO_ADV_WRK
    public class PoAdvWrk
    {
        public string SessId { get; set; } // SESS_ID (Primary key) (length: 40)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public decimal? OrigSuggQty { get; set; } // ORIG_SUGG_QTY
        public decimal? AdjSuggQty { get; set; } // ADJ_SUGG_QTY
        public string AdjUnit { get; set; } // ADJ_UNIT (length: 15)
        public string AdjQtyUnit { get; set; } = "0"; // ADJ_QTY_UNIT (length: 1)
        public decimal? AdjQtyNumer { get; set; } // ADJ_QTY_NUMER
        public decimal? AdjQtyDenom { get; set; } // ADJ_QTY_DENOM
        public decimal? QtySold { get; set; } // QTY_SOLD
        public decimal? QtyOnHnd { get; set; } = 0m; // QTY_ON_HND
        public decimal? QtyOnPo { get; set; } = 0m; // QTY_ON_PO
        public decimal? QtyOnPreq { get; set; } // QTY_ON_PREQ
        public decimal? QtyCommit { get; set; } = 0m; // QTY_COMMIT
        public decimal? QtyOnBo { get; set; } = 0m; // QTY_ON_BO
        public decimal MinQty { get; set; } = 0m; // MIN_QTY
        public decimal MaxQty { get; set; } = 0m; // MAX_QTY
        public decimal? NetQty { get; set; } // NET_QTY
        public decimal? AvgCost { get; set; } // AVG_COST
        public decimal? LstCost { get; set; } = 0m; // LST_COST
        public decimal? UnitRetlVal { get; set; } // UNIT_RETL_VAL
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
        public decimal? QtyOnSo { get; set; } = 0m; // QTY_ON_SO
        public decimal? QtyOnOrd { get; set; } = 0m; // QTY_ON_ORD
        public decimal? QtyOnLwy { get; set; } = 0m; // QTY_ON_LWY
        public decimal? ExtAvgCost { get; private set; } // EXT_AVG_COST
        public decimal? ExtLstCost { get; private set; } // EXT_LST_COST
        public decimal? ExtRetlPrc { get; private set; } // EXT_RETL_PRC
        public decimal? ExtVendItemCost { get; private set; } // EXT_VEND_ITEM_COST
        public int? CurrDaysOfSupply { get; set; } // CURR_DAYS_OF_SUPPLY
        public int? LeadDays { get; set; } // LEAD_DAYS
        public string PurUnit { get; set; } // PUR_UNIT (length: 15)
        public decimal? PurNumer { get; set; } // PUR_NUMER
        public decimal? PurDenom { get; set; } // PUR_DENOM

        // Reverse navigation

        /// <summary>
        /// Child PoAdvWrkCells where [PO_ADV_WRK_CELL].([ITEM_NO], [LOC_ID], [SESS_ID]) point to this entity (FK_PO_ADV_WRK_CELL_PO_ADV_WRK)
        /// </summary>
        public virtual IList<PoAdvWrkCell> PoAdvWrkCells { get; set; } = new List<PoAdvWrkCell>(); // PO_ADV_WRK_CELL.FK_PO_ADV_WRK_CELL_PO_ADV_WRK

        /// <summary>
        /// Child PoAdvWrkCustOrds where [PO_ADV_WRK_CUST_ORDS].([ITEM_NO], [LOC_ID], [SESS_ID]) point to this entity (FK_PO_ADV_WRK_CUST_ORDS_PO_ADV_WRK)
        /// </summary>
        public virtual IList<PoAdvWrkCustOrd> PoAdvWrkCustOrds { get; set; } = new List<PoAdvWrkCustOrd>(); // PO_ADV_WRK_CUST_ORDS.FK_PO_ADV_WRK_CUST_ORDS_PO_ADV_WRK
    }

}
// </auto-generated>

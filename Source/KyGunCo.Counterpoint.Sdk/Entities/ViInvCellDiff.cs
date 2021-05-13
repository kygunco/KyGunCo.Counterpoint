// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_INV_CELL_DIFF
    public class ViInvCellDiff
    {
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string LocId { get; set; } // LOC_ID (length: 10)
        public string Descr { get; set; } // DESCR (length: 30)
        public string WhatsWrong { get; set; } // WHATS_WRONG (length: 21)
        public decimal InvQtyOnHnd { get; set; } // INV_QTY_ON_HND
        public decimal? CalcQtyOnHnd { get; set; } // CALC_QTY_ON_HND
        public decimal InvMinQty { get; set; } // INV_MIN_QTY
        public decimal? CalcMinQty { get; set; } // CALC_MIN_QTY
        public decimal InvMaxQty { get; set; } // INV_MAX_QTY
        public decimal? CalcMaxQty { get; set; } // CALC_MAX_QTY
    }

}
// </auto-generated>
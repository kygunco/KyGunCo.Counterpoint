// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_FILL_BO_SUPPLY_WRK
    public class PsFillBoSupplyWrk
    {
        public Guid SessId { get; set; } // SESS_ID (Primary key)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public decimal QtyOnHnd { get; set; } = 0m; // QTY_ON_HND
        public decimal QtyCommit { get; set; } = 0m; // QTY_COMMIT
        public decimal? QtyAvail { get; private set; } // QTY_AVAIL
    }

}
// </auto-generated>

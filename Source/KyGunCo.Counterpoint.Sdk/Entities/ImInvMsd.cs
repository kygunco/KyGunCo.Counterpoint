// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_INV_MSD
    public class ImInvMsd
    {
        public int SiteId { get; set; } // SITE_ID (Primary key)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public decimal? QtyCommit { get; set; } // QTY_COMMIT
        public decimal? QtyOnHnd { get; set; } // QTY_ON_HND
        public decimal? QtyOnPo { get; set; } // QTY_ON_PO
        public decimal? QtyOnBo { get; set; } // QTY_ON_BO
        public decimal? QtyOnXferOut { get; set; } // QTY_ON_XFER_OUT
        public decimal? QtyOnXferIn { get; set; } // QTY_ON_XFER_IN
        public decimal? GlVal { get; set; } // GL_VAL
        public decimal? QtyOnOrd { get; set; } // QTY_ON_ORD
        public decimal? QtyOnLwy { get; set; } // QTY_ON_LWY
        public decimal? QtyOnSo { get; set; } // QTY_ON_SO
        public decimal? DropshipQtyOnCustOrd { get; set; } // DROPSHIP_QTY_ON_CUST_ORD
        public decimal? DropshipQtyOnPo { get; set; } // DROPSHIP_QTY_ON_PO
    }

}
// </auto-generated>

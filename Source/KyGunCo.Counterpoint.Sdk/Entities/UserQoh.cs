// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_QOH
    public class UserQoh
    {
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string Descr { get; set; } // DESCR (length: 50)
        public decimal QtySold { get; set; } // QTY_SOLD
        public string CustNo { get; set; } // CUST_NO (length: 15)
        public string BillNam { get; set; } // BILL_NAM (length: 40)
        public decimal QtyOnHnd { get; set; } // QTY_ON_HND
        public DateTime? TktDt { get; set; } // TKT_DT
        public string OrderNotes { get; set; } // ORDER_NOTES (length: 30)
    }

}
// </auto-generated>
// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_RANGE_RESERVATION
    public class UserRangeReservation
    {
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string CustNo { get; set; } // CUST_NO (Primary key) (length: 15)
        public DateTime? ReservationDtStart { get; set; } // RESERVATION_DT_START
        public DateTime? ReservationDtEnd { get; set; } // RESERVATION_DT_END
        public int? Status { get; set; } // STATUS
    }

}
// </auto-generated>

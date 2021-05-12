// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // The table 'USER_PAYMENT_API_LOG' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // USER_PAYMENT_API_LOG
    public class UserPaymentApiLog
    {
        public DateTime? Time { get; set; } // TIME
        public string UserEcommOrdNo { get; set; } // USER_ECOMM_ORD_NO (length: 15)
        public string Step { get; set; } // STEP (length: 15)
        public string Result { get; set; } // RESULT
        public decimal? Amt { get; set; } // AMT
    }

}
// </auto-generated>

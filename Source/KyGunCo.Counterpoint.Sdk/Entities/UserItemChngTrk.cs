// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_ITEM_CHNG_TRK
    public class UserItemChngTrk
    {
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public DateTime ChngDt { get; set; } // CHNG_DT (Primary key)
        public string UsrId { get; set; } // USR_ID (Primary key) (length: 10)
        public string ChngMade { get; set; } // CHNG_MADE (length: 1000)
    }

}
// </auto-generated>

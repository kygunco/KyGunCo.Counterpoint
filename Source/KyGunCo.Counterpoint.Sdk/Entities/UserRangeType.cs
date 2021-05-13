// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_RANGE_TYPE
    public class UserRangeType
    {
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string AddlShooterItemNo { get; set; } = "0"; // ADDL_SHOOTER_ITEM_NO (length: 20)
        public int MaxLaneReserv1Hr { get; set; } = 0; // MAX_LANE_RESERV_1HR
        public int MaxLaneReserv30Min { get; set; } = 0; // MAX_LANE_RESERV_30MIN
    }

}
// </auto-generated>
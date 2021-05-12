// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // AR_CUST_MSD
    public class ArCustMsd
    {
        public int SiteId { get; set; } // SITE_ID (Primary key)
        public string CustNo { get; set; } // CUST_NO (Primary key) (length: 15)
        public decimal? UnpstdBal { get; set; } // UNPSTD_BAL
        public decimal? Bal { get; set; } // BAL
        public decimal? OrdBal { get; set; } // ORD_BAL
        public int? NoOfOrds { get; set; } // NO_OF_ORDS
        public decimal? LwyBal { get; set; } // LWY_BAL
        public int? NoOfLwys { get; set; } // NO_OF_LWYS
        public int? LoyPtsBal { get; set; } // LOY_PTS_BAL
        public int? TotLoyPtsEarnd { get; set; } // TOT_LOY_PTS_EARND
        public int? TotLoyPtsRdm { get; set; } // TOT_LOY_PTS_RDM
        public int? TotLoyPtsAdj { get; set; } // TOT_LOY_PTS_ADJ
    }

}
// </auto-generated>

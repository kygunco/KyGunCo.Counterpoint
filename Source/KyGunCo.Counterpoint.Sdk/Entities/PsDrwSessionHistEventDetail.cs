// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DRW_SESSION_HIST_EVENT_DETAIL
    public class PsDrwSessionHistEventDetail
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string DrwId { get; set; } // DRW_ID (Primary key) (length: 10)
        public long DrwSessionId { get; set; } // DRW_SESSION_ID (Primary key)
        public int EventId { get; set; } // EVENT_ID (Primary key)
        public string PayCod { get; set; } // PAY_COD (Primary key) (length: 10)
        public decimal? Amt { get; set; } // AMT
        public decimal? OverShortAmt { get; set; } // OVER_SHORT_AMT
        public string CurncyCod { get; set; } = "HOME"; // CURNCY_COD (length: 10)
        public string CurncyCodDescr { get; set; } // CURNCY_COD_DESCR (length: 30)
        public decimal ExchRateNumer { get; set; } = 1m; // EXCH_RATE_NUMER
        public decimal ExchRateDenom { get; set; } // EXCH_RATE_DENOM
        public decimal? HomeCurncyAmt { get; set; } // HOME_CURNCY_AMT
        public decimal? OverShortHomeCurncyAmt { get; set; } // OVER_SHORT_HOME_CURNCY_AMT
        public decimal? HomeCurncyDistAmt { get; set; } // HOME_CURNCY_DIST_AMT
        public bool AddDuringPost { get; set; } // ADD_DURING_POST

        // Foreign keys

        /// <summary>
        /// Parent PsDrwSessionHistEvent pointed by [PS_DRW_SESSION_HIST_EVENT_DETAIL].([BusDat], [StrId], [DrwId], [DrwSessionId], [EventId]) (FK_PS_DRW_SESSION_HIST_EVENT_DETAIL_PS_DRW_SESSION_HIST_EVENT)
        /// </summary>
        public virtual PsDrwSessionHistEvent PsDrwSessionHistEvent { get; set; } // FK_PS_DRW_SESSION_HIST_EVENT_DETAIL_PS_DRW_SESSION_HIST_EVENT
    }

}
// </auto-generated>

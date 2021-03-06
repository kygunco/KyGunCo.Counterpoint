// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // AR_TERMS_COD
    public class ArTermsCod
    {
        public string TermsCod { get; set; } // TERMS_COD (Primary key) (length: 10)
        public string Descr { get; set; } // DESCR (length: 30)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 30)
        public int? NetDueDays { get; set; } // NET_DUE_DAYS
        public int? ProxDueDay { get; set; } // PROX_DUE_DAY
        public string UseProxDueDay { get; set; } = "N"; // USE_PROX_DUE_DAY (length: 1)
        public int? NetDiscDays { get; set; } // NET_DISC_DAYS
        public int? ProxDiscDay { get; set; } // PROX_DISC_DAY
        public string UseProxDiscDay { get; set; } = "N"; // USE_PROX_DISC_DAY (length: 1)
        public decimal? DiscPct { get; set; } // DISC_PCT
        public string DiscAcctNo { get; set; } // DISC_ACCT_NO (length: 20)
        public int? CutoffDay { get; set; } // CUTOFF_DAY
        public string CutoffIsEom { get; set; } = "N"; // CUTOFF_IS_EOM (length: 1)
        public string DiscMeth { get; set; } = "!"; // DISC_METH (length: 1)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT

        // Reverse navigation

        /// <summary>
        /// Child ArCusts where [AR_CUST].[TERMS_COD] point to this entity (FK_AR_CUST_AR_TERMS_COD)
        /// </summary>
        public virtual IList<ArCust> ArCusts { get; set; } = new List<ArCust>(); // AR_CUST.FK_AR_CUST_AR_TERMS_COD
    }

}
// </auto-generated>

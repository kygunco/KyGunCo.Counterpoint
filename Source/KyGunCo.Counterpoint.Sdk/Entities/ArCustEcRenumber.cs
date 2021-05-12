// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // AR_CUST_EC_RENUMBER
    public class ArCustEcRenumber
    {
        public string OldCustNo { get; set; } // OLD_CUST_NO (Primary key) (length: 15)
        public string NewCustNo { get; set; } // NEW_CUST_NO (Primary key) (length: 15)
        public string StrId { get; set; } // STR_ID (length: 10)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string Selectd { get; set; } = "N"; // SELECTD (length: 1)

        // Foreign keys

        /// <summary>
        /// Parent PsStr pointed by [AR_CUST_EC_RENUMBER].([StrId]) (FK_AR_CUST_EC_RENUMBER_PS_STR)
        /// </summary>
        public virtual PsStr PsStr { get; set; } // FK_AR_CUST_EC_RENUMBER_PS_STR
    }

}
// </auto-generated>

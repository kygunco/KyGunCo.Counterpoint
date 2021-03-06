// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // DM_CAL_MNTH
    public class DmCalMnth
    {
        public int MnthId { get; set; } // MNTH_ID (Primary key)
        public int YrId { get; set; } // YR_ID
        public string MnthNam { get; set; } // MNTH_NAM (length: 5)
        public int MnthOfYr { get; set; } // MNTH_OF_YR
        public int? SameMnthLstYr { get; set; } // SAME_MNTH_LST_YR
        public DateTime BegDat { get; set; } // BEG_DAT
        public DateTime EndDat { get; set; } // END_DAT
        public int? NxtMnthId { get; set; } // NXT_MNTH_ID
        public int? PrevMnthId { get; set; } // PREV_MNTH_ID
        public string CalndrId { get; set; } // CALNDR_ID (length: 10)
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent DmCalYr pointed by [DM_CAL_MNTH].([YrId]) (FK_DM_CAL_MNTH_DM_CAL_YR)
        /// </summary>
        public virtual DmCalYr DmCalYr { get; set; } // FK_DM_CAL_MNTH_DM_CAL_YR
    }

}
// </auto-generated>

// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_LWY_HIST_PMT_CHK
    public class PsLwyHistPmtChk
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int PmtSeqNo { get; set; } // PMT_SEQ_NO (Primary key)
        public string ChkAcctNo { get; set; } // CHK_ACCT_NO (length: 25)
        public string ChkTransitNo { get; set; } // CHK_TRANSIT_NO (length: 20)
        public string ChkNo { get; set; } // CHK_NO (length: 10)
        public string ChkDrivLicNo { get; set; } // CHK_DRIV_LIC_NO (length: 30)
        public string ChkDrivLicState { get; set; } // CHK_DRIV_LIC_STATE (length: 10)
        public DateTime? ChkBirthDat { get; set; } // CHK_BIRTH_DAT

        // Foreign keys

        /// <summary>
        /// Parent PsLwyHistPmt pointed by [PS_LWY_HIST_PMT_CHK].([BusDat], [DocId], [PmtSeqNo]) (FK_PS_LWY_HIST_PMT_CHK_PS_LWY_HIST_PMT)
        /// </summary>
        public virtual PsLwyHistPmt PsLwyHistPmt { get; set; } // FK_PS_LWY_HIST_PMT_CHK_PS_LWY_HIST_PMT
    }

}
// </auto-generated>

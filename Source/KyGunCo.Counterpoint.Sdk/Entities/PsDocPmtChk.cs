// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DOC_PMT_CHK
    public class PsDocPmtChk
    {
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
        /// Parent PsDocPmt pointed by [PS_DOC_PMT_CHK].([DocId], [PmtSeqNo]) (FK_PS_DOC_PMT_CHK_PS_DOC_PMT)
        /// </summary>
        public virtual PsDocPmt PsDocPmt { get; set; } // FK_PS_DOC_PMT_CHK_PS_DOC_PMT
    }

}
// </auto-generated>

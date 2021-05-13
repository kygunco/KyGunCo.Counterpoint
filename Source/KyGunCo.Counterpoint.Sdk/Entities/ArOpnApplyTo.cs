// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // AR_OPN_APPLY_TO
    public class ArOpnApplyTo
    {
        public string CustNo { get; set; } // CUST_NO (Primary key) (length: 15)
        public DateTime DocDat { get; set; } // DOC_DAT (Primary key)
        public string DocNo { get; set; } // DOC_NO (Primary key) (length: 15)
        public string DocTyp { get; set; } = "T"; // DOC_TYP (Primary key) (length: 1)
        public DateTime ApplyToDocDat { get; set; } // APPLY_TO_DOC_DAT (Primary key)
        public string ApplyToDocNo { get; set; } // APPLY_TO_DOC_NO (Primary key) (length: 15)
        public string ApplyToDocTyp { get; set; } // APPLY_TO_DOC_TYP (Primary key) (length: 1)
        public int EntrySeqNo { get; set; } // ENTRY_SEQ_NO
        public decimal? Amt { get; set; } // AMT
        public decimal? EntdAmt { get; set; } // ENTD_AMT
        public decimal? DiscntblAmt { get; set; } // DISCNTBL_AMT
        public decimal? EntdDiscntblAmt { get; set; } // ENTD_DISCNTBL_AMT
        public decimal? DiscAmt { get; set; } = 0m; // DISC_AMT
        public decimal? WrtoffAmt { get; set; } = 0m; // WRTOFF_AMT
        public string LinIsOpn { get; set; } = "N"; // LIN_IS_OPN (length: 1)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string SelfApplied { get; private set; } // SELF_APPLIED (length: 1)
        public int? StmntDocTypOrder { get; private set; } // STMNT_DOC_TYP_ORDER

        // Foreign keys

        /// <summary>
        /// Parent ArOpnItem pointed by [AR_OPN_APPLY_TO].([CustNo], [DocDat], [DocNo], [DocTyp]) (FK_AR_OPN_APPLY_TO_AR_OPN_ITEM)
        /// </summary>
        public virtual ArOpnItem ArOpnItem { get; set; } // FK_AR_OPN_APPLY_TO_AR_OPN_ITEM
    }

}
// </auto-generated>
// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DOC_LIN_LOY
    public class PsDocLinLoy
    {
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int LinSeqNo { get; set; } // LIN_SEQ_NO (Primary key)
        public decimal LinLoyPtsEarnd { get; set; } = 0m; // LIN_LOY_PTS_EARND
        public string LoyPgmRdmElig { get; set; } = "N"; // LOY_PGM_RDM_ELIG (length: 1)
        public decimal LoyPgmAmtPdWithPts { get; set; } = 0m; // LOY_PGM_AMT_PD_WITH_PTS
        public string LoyPtEarnRulDescr { get; set; } // LOY_PT_EARN_RUL_DESCR (length: 30)
        public int? LoyPtEarnRulSeqNo { get; set; } // LOY_PT_EARN_RUL_SEQ_NO
        public string LoyPtRdmRulDescr { get; set; } // LOY_PT_RDM_RUL_DESCR (length: 30)
        public int? LoyPtRdmRulSeqNo { get; set; } // LOY_PT_RDM_RUL_SEQ_NO

        // Foreign keys

        /// <summary>
        /// Parent PsDocLin pointed by [PS_DOC_LIN_LOY].([DocId], [LinSeqNo]) (FK_PS_DOC_LIN_LOY_PS_DOC_LIN)
        /// </summary>
        public virtual PsDocLin PsDocLin { get; set; } // FK_PS_DOC_LIN_LOY_PS_DOC_LIN
    }

}
// </auto-generated>

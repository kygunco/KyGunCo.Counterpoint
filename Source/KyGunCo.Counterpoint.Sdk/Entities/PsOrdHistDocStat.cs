// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_ORD_HIST_DOC_STAT
    public class PsOrdHistDocStat
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public string LstDocActiv { get; set; } = "!"; // LST_DOC_ACTIV (length: 1)
        public int DocAsTktSeqNo { get; set; } = 0; // DOC_AS_TKT_SEQ_NO
        public string DocStat { get; set; } = "O"; // DOC_STAT (length: 1)
        public decimal LstCancelDepRefunded { get; set; } // LST_CANCEL_DEP_REFUNDED
        public decimal LstCancelDepForfeit { get; set; } // LST_CANCEL_DEP_FORFEIT
        public decimal TotDepReceived { get; set; } = 0m; // TOT_DEP_RECEIVED
        public decimal TotDepApplied { get; set; } = 0m; // TOT_DEP_APPLIED
        public decimal TotDepRefunded { get; set; } = 0m; // TOT_DEP_REFUNDED
        public decimal TotDepForfeit { get; set; } = 0m; // TOT_DEP_FORFEIT
        public DateTime? LstDocEditDt { get; set; } // LST_DOC_EDIT_DT
        public string LstDocEditUsrId { get; set; } // LST_DOC_EDIT_USR_ID (length: 10)
        public DateTime? LstDocPrtDt { get; set; } // LST_DOC_PRT_DT
        public string LstDocPrtUsrId { get; set; } // LST_DOC_PRT_USR_ID (length: 10)
        public DateTime? LstDocPickDt { get; set; } // LST_DOC_PICK_DT
        public string LstDocPickUsrId { get; set; } // LST_DOC_PICK_USR_ID (length: 10)
        public DateTime? LstDocRelDt { get; set; } // LST_DOC_REL_DT
        public string LstDocRelUsrId { get; set; } // LST_DOC_REL_USR_ID (length: 10)
        public DateTime? LstDocInvcdDt { get; set; } // LST_DOC_INVCD_DT
        public string LstDocInvcdUsrId { get; set; } // LST_DOC_INVCD_USR_ID (length: 10)
        public DateTime? LstDocPckvrfdDt { get; set; } // LST_DOC_PCKVRFD_DT
        public string LstDocPckvrfdUsrId { get; set; } // LST_DOC_PCKVRFD_USR_ID (length: 10)
        public string IsSuspended { get; set; } = "N"; // IS_SUSPENDED (length: 1)
        public DateTime? LstDocSuspendedDt { get; set; } // LST_DOC_SUSPENDED_DT
        public string LstDocSuspendedUsrId { get; set; } // LST_DOC_SUSPENDED_USR_ID (length: 10)
        public string PreqWrkgrpId { get; set; } // PREQ_WRKGRP_ID (length: 15)

        // Foreign keys

        /// <summary>
        /// Parent PsOrdHist pointed by [PS_ORD_HIST_DOC_STAT].([BusDat], [DocId]) (FK_PS_ORD_HIST_DOC_STAT_PS_ORD_HIST)
        /// </summary>
        public virtual PsOrdHist PsOrdHist { get; set; } // FK_PS_ORD_HIST_DOC_STAT_PS_ORD_HIST
    }

}
// </auto-generated>

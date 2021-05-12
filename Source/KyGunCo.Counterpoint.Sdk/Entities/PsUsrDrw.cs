// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_USR_DRW
    public class PsUsrDrw
    {
        public string UsrId { get; set; } // USR_ID (Primary key) (length: 10)
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string DrwId { get; set; } // DRW_ID (Primary key) (length: 10)
        public string AllowActiv { get; set; } = "N"; // ALLOW_ACTIV (length: 1)
        public string AllowCnt { get; set; } = "N"; // ALLOW_CNT (length: 1)
        public string AllowUse { get; set; } = "N"; // ALLOW_USE (length: 1)
        public string AllowRecon { get; set; } = "N"; // ALLOW_RECON (length: 1)
        public string AllowPost { get; set; } = "N"; // ALLOW_POST (length: 1)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string AllowLoan { get; set; } = "N"; // ALLOW_LOAN (length: 1)
        public string AllowDrop { get; set; } = "N"; // ALLOW_DROP (length: 1)
        public string AllowVoid { get; set; } = "N"; // ALLOW_VOID (length: 1)

        // Foreign keys

        /// <summary>
        /// Parent SyUsr pointed by [PS_USR_DRW].([UsrId]) (FK_PS_USR_DRW_SY_USR)
        /// </summary>
        public virtual SyUsr SyUsr { get; set; } // FK_PS_USR_DRW_SY_USR
    }

}
// </auto-generated>

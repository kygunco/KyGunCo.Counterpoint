// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // DM_AGG
    public class DmAgg
    {
        public int AggId { get; set; } // AGG_ID (Primary key)
        public string Descr { get; set; } // DESCR (length: 50)
        public string ProcNam { get; set; } // PROC_NAM (length: 128)
        public int SeqNo { get; set; } // SEQ_NO
        public string IsActive { get; set; } = "Y"; // IS_ACTIVE (length: 1)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public int? AggGrpId { get; set; } // AGG_GRP_ID
        public string TableName { get; set; } // TABLE_NAME (length: 128)

        // Foreign keys

        /// <summary>
        /// Parent DmAggGrp pointed by [DM_AGG].([AggGrpId]) (FK_DM_AGG_DM_AGG_GRP)
        /// </summary>
        public virtual DmAggGrp DmAggGrp { get; set; } // FK_DM_AGG_DM_AGG_GRP
    }

}
// </auto-generated>

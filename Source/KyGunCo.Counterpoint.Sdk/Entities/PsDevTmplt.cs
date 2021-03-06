// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DEV_TMPLT
    public class PsDevTmplt
    {
        public long DevTmpltId { get; set; } // DEV_TMPLT_ID (Primary key)
        public string Nam { get; set; } // NAM (length: 40)
        public string Descr { get; set; } // DESCR (length: 250)
        public int DevTmpltTypId { get; set; } // DEV_TMPLT_TYP_ID
        public DateTime? FstMaintDt { get; set; } // FST_MAINT_DT
        public string FstMaintUsrId { get; set; } // FST_MAINT_USR_ID (length: 10)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public byte[] RowTs { get; set; } // ROW_TS
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT

        // Reverse navigation

        /// <summary>
        /// Child PsDevTmpltConfigs where [PS_DEV_TMPLT_CONFIG].[DEV_TMPLT_ID] point to this entity (FK_PS_DEV_TMPLT_CONFIG_PS_DEV_TMPLT)
        /// </summary>
        public virtual IList<PsDevTmpltConfig> PsDevTmpltConfigs { get; set; } = new List<PsDevTmpltConfig>(); // PS_DEV_TMPLT_CONFIG.FK_PS_DEV_TMPLT_CONFIG_PS_DEV_TMPLT

        // Foreign keys

        /// <summary>
        /// Parent PsDevTmpltTyp pointed by [PS_DEV_TMPLT].([DevTmpltTypId]) (FK_PS_DEV_TMPLT_PS_DEV_TMPLT_TYP)
        /// </summary>
        public virtual PsDevTmpltTyp PsDevTmpltTyp { get; set; } // FK_PS_DEV_TMPLT_PS_DEV_TMPLT_TYP
    }

}
// </auto-generated>

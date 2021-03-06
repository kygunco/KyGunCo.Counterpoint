// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DEV_CFG
    public class PsDevCfg
    {
        public long DevCfgId { get; set; } // DEV_CFG_ID (Primary key)
        public string AssemNam { get; set; } // ASSEM_NAM (length: 255)
        public string ClassNam { get; set; } // CLASS_NAM (length: 255)
        public string WorkstationId { get; set; } // WORKSTATION_ID (length: 40)
        public string Disabled { get; set; } // DISABLED (length: 1)
        public DateTime? FstMaintDt { get; set; } // FST_MAINT_DT
        public string FstMaintUsrId { get; set; } // FST_MAINT_USR_ID (length: 10)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public byte[] RowTs { get; set; } // ROW_TS
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT

        // Reverse navigation

        /// <summary>
        /// Child PsDevAttrs where [PS_DEV_ATTR].[DEV_CFG_ID] point to this entity (FK_PS_DEV_ATTR_PS_DEV_CFG)
        /// </summary>
        public virtual IList<PsDevAttr> PsDevAttrs { get; set; } = new List<PsDevAttr>(); // PS_DEV_ATTR.FK_PS_DEV_ATTR_PS_DEV_CFG

        /// <summary>
        /// Child PsDevTmpltConfigs where [PS_DEV_TMPLT_CONFIG].[DEV_CFG_ID] point to this entity (FK_PS_DEV_TMPLT_CONFIG_PS_DEV_CFG)
        /// </summary>
        public virtual IList<PsDevTmpltConfig> PsDevTmpltConfigs { get; set; } = new List<PsDevTmpltConfig>(); // PS_DEV_TMPLT_CONFIG.FK_PS_DEV_TMPLT_CONFIG_PS_DEV_CFG
    }

}
// </auto-generated>

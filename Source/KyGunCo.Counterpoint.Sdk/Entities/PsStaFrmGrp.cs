// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_STA_FRM_GRP
    public class PsStaFrmGrp
    {
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string StaId { get; set; } // STA_ID (Primary key) (length: 10)
        public string FrmGrpId { get; set; } // FRM_GRP_ID (Primary key) (length: 10)
        public int? SeqNo { get; set; } // SEQ_NO
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT

        // Foreign keys

        /// <summary>
        /// Parent PsSta pointed by [PS_STA_FRM_GRP].([StrId], [StaId]) (FK_PS_STA_FRM_GRP_PS_STA)
        /// </summary>
        public virtual PsSta PsSta { get; set; } // FK_PS_STA_FRM_GRP_PS_STA
    }

}
// </auto-generated>

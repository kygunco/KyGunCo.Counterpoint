// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_STA
    public class PsSta
    {
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string StaId { get; set; } // STA_ID (Primary key) (length: 10)
        public string Descr { get; set; } // DESCR (length: 30)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 30)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string UseOe { get; set; } = "N"; // USE_OE (length: 1)
        public short StaNo { get; set; } // STA_NO
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT

        // Reverse navigation

        /// <summary>
        /// Child PsDocHdrs where [PS_DOC_HDR].([STA_ID], [STR_ID]) point to this entity (FK_PS_DOC_HDR_PS_STA)
        /// </summary>
        public virtual IList<PsDocHdr> PsDocHdrs { get; set; } = new List<PsDocHdr>(); // PS_DOC_HDR.FK_PS_DOC_HDR_PS_STA

        /// <summary>
        /// Child PsStaFrmGrps where [PS_STA_FRM_GRP].([STA_ID], [STR_ID]) point to this entity (FK_PS_STA_FRM_GRP_PS_STA)
        /// </summary>
        public virtual IList<PsStaFrmGrp> PsStaFrmGrps { get; set; } = new List<PsStaFrmGrp>(); // PS_STA_FRM_GRP.FK_PS_STA_FRM_GRP_PS_STA

        /// <summary>
        /// Parent (One-to-One) PsSta pointed by [PS_STA_CFG_PS].([STA_ID], [STR_ID]) (FK_PS_STA_CFG_PS_PS_STA)
        /// </summary>
        public virtual PsStaCfgP PsStaCfgP { get; set; } // PS_STA_CFG_PS.FK_PS_STA_CFG_PS_PS_STA

        // Foreign keys

        /// <summary>
        /// Parent PsStr pointed by [PS_STA].([StrId]) (FK_PS_STA_PS_STR)
        /// </summary>
        public virtual PsStr PsStr { get; set; } // FK_PS_STA_PS_STR
    }

}
// </auto-generated>

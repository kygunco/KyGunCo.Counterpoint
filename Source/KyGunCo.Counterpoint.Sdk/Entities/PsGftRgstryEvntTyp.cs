// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_GFT_RGSTRY_EVNT_TYP
    public class PsGftRgstryEvntTyp
    {
        public string GftRgstryEvntTyp { get; set; } // GFT_RGSTRY_EVNT_TYP (Primary key) (length: 10)
        public string Descr { get; set; } // DESCR (length: 30)
        public string EcommNxtPubMode { get; set; } = "N"; // ECOMM_NXT_PUB_MODE (length: 1)
        public DateTime? EcommLstPubDt { get; set; } // ECOMM_LST_PUB_DT
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT

        // Reverse navigation

        /// <summary>
        /// Child PsGftRgstryHdrs where [PS_GFT_RGSTRY_HDR].[GFT_RGSTRY_EVNT_TYP] point to this entity (FK_PS_GFT_RGSTRY_HDR_PS_GFT_RGSTRY_EVNT_TYP)
        /// </summary>
        public virtual IList<PsGftRgstryHdr> PsGftRgstryHdrs { get; set; } = new List<PsGftRgstryHdr>(); // PS_GFT_RGSTRY_HDR.FK_PS_GFT_RGSTRY_HDR_PS_GFT_RGSTRY_EVNT_TYP
    }

}
// </auto-generated>
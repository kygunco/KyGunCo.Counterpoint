// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // OM_CTL
    public class OmCtl
    {
        public int KeyId { get; set; } = 1; // KEY_ID (Primary key)
        public string WhlDoc { get; set; } = "N"; // WHL_DOC (length: 1)
        public string PckTktFrmGrpId { get; set; } // PCK_TKT_FRM_GRP_ID (length: 10)
        public string PckVrfyFrmGrpId { get; set; } // PCK_VRFY_FRM_GRP_ID (length: 10)
        public string InvcFrmGrpId { get; set; } // INVC_FRM_GRP_ID (length: 10)
        public string RelFrmGrpId { get; set; } // REL_FRM_GRP_ID (length: 10)
        public string PckTktSummFrmFil { get; set; } // PCK_TKT_SUMM_FRM_FIL (length: 100)
        public string PckVrfySummFrmFil { get; set; } // PCK_VRFY_SUMM_FRM_FIL (length: 100)
        public string InvcSummFrmFil { get; set; } // INVC_SUMM_FRM_FIL (length: 100)
        public string RelSummFrmFil { get; set; } // REL_SUMM_FRM_FIL (length: 100)
        public string PckTktSummFrmPrtMeth { get; set; } = "P"; // PCK_TKT_SUMM_FRM_PRT_METH (length: 1)
        public string PckVrfySummFrmPrtMeth { get; set; } = "P"; // PCK_VRFY_SUMM_FRM_PRT_METH (length: 1)
        public string InvcSummFrmPrtMeth { get; set; } = "P"; // INVC_SUMM_FRM_PRT_METH (length: 1)
        public string RelSummFrmPrtMeth { get; set; } = "P"; // REL_SUMM_FRM_PRT_METH (length: 1)
    }

}
// </auto-generated>

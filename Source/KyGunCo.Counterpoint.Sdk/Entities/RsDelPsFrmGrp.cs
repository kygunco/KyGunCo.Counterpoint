// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // RS_DEL_PS_FRM_GRP
    public class RsDelPsFrmGrp
    {
        public int DelId { get; set; } // DEL_ID (Primary key)
        public byte? RsStat { get; set; } = 1; // RS_STAT
        public DateTime? DeleteDt { get; set; } = DateTime.UtcNow; // DELETE_DT
        public string FrmGrpId { get; set; } // FRM_GRP_ID (length: 10)
    }

}
// </auto-generated>
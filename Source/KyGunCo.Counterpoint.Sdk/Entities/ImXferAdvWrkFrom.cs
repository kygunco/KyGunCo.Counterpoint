// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_XFER_ADV_WRK_FROM
    public class ImXferAdvWrkFrom
    {
        public string SessId { get; set; } // SESS_ID (Primary key) (length: 40)
        public string FromLocId { get; set; } // FROM_LOC_ID (Primary key) (length: 10)
        public int? FromLocSeqNo { get; set; } // FROM_LOC_SEQ_NO
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
    }

}
// </auto-generated>

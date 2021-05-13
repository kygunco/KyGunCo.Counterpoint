// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PS_TRX_LOG
    public class ViPsTrxLog
    {
        public long LogId { get; set; } // LOG_ID
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string DrwId { get; set; } // DRW_ID (length: 10)
        public long DocId { get; set; } // DOC_ID
        public DateTime ActivDt { get; set; } // ACTIV_DT
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string OvrdUsrId { get; set; } // OVRD_USR_ID (length: 10)
        public string ActivTyp { get; set; } // ACTIV_TYP (length: 1)
        public string SysFuncTyp { get; set; } // SYS_FUNC_TYP (length: 2)
        public string PsSecTyp { get; set; } // PS_SEC_TYP (length: 2)
        public Guid? LinId { get; set; } // LIN_ID
        public string Value1 { get; set; } // VALUE_1 (length: 30)
        public string Value2 { get; set; } // VALUE_2 (length: 30)
        public string Processed { get; set; } // PROCESSED (length: 1)
    }

}
// </auto-generated>
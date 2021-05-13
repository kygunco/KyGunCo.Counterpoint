// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PHYS_CNT_EVENTS
    public class ViPhysCntEvent
    {
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string PkgId { get; set; } // PKG_ID (length: 2)
        public string EventTyp { get; set; } // EVENT_TYP (length: 3)
        public string UsrId { get; set; } // USR_ID (length: 10)
        public DateTime? EventDat { get; set; } // EVENT_DAT
        public DateTime? EventTim { get; set; } // EVENT_TIM
        public string SysErr { get; set; } // SYS_ERR (length: 1)
        public string SysErrRef { get; set; } // SYS_ERR_REF (length: 2147483647)
        public int? TrxCnt { get; set; } // TRX_CNT
        public int? PostCnt { get; set; } // POST_CNT
        public int? BrErrCnt { get; set; } // BR_ERR_CNT
        public int? DbErrCnt { get; set; } // DB_ERR_CNT
        public string BatId { get; set; } // BAT_ID (length: 15)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string DrwId { get; set; } // DRW_ID (length: 10)
        public DateTime? PostDat { get; set; } // POST_DAT
        public string AddlParams { get; set; } // ADDL_PARAMS (length: 2147483647)
        public string WrkgrpId { get; set; } // WRKGRP_ID (length: 10)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string WkstnNam { get; set; } // WKSTN_NAM (length: 128)
        public string ServNam { get; set; } // SERV_NAM (length: 128)
        public string DbNam { get; set; } // DB_NAM (length: 128)
        public string SwVerIni { get; set; } // SW_VER_INI (length: 50)
        public string SwVerExe { get; set; } // SW_VER_EXE (length: 50)
        public DateTime? SwVerBuildDt { get; set; } // SW_VER_BUILD_DT
        public DateTime? FstPostDat { get; set; } // FST_POST_DAT
        public DateTime? LstPostDat { get; set; } // LST_POST_DAT
        public DateTime? EventDt { get; set; } // EVENT_DT
        public long? DrwSessionId { get; set; } // DRW_SESSION_ID
        public int? OrigSiteId { get; set; } // ORIG_SITE_ID
    }

}
// </auto-generated>
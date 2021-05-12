// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_FRM_GRP_FRM
    public class PsFrmGrpFrm
    {
        public string FrmGrpId { get; set; } // FRM_GRP_ID (Primary key) (length: 10)
        public int SeqNo { get; set; } // SEQ_NO (Primary key)
        public string FrmFil { get; set; } // FRM_FIL (length: 100)
        public string Commnt { get; set; } // COMMNT (length: 50)
        public string PrtrMeth { get; set; } = "D"; // PRTR_METH (length: 1)
        public string PrtrNam { get; set; } // PRTR_NAM (length: 100)
        public string MsgBefore { get; set; } // MSG_BEFORE (length: 250)
        public string BtnLblYes { get; set; } // BTN_LBL_YES (length: 10)
        public string BtnLblNo { get; set; } // BTN_LBL_NO (length: 10)
        public string BtnLblCancel { get; set; } // BTN_LBL_CANCEL (length: 10)
        public string MsgAfter { get; set; } // MSG_AFTER (length: 250)
        public string CutPaper { get; set; } = "N"; // CUT_PAPER (length: 1)
        public string FiltTbl { get; set; } = "!"; // FILT_TBL (length: 100)
        public string Filt { get; set; } // FILT (length: 2147483647)
        public string FiltTmplt { get; set; } // FILT_TMPLT (length: 2147483647)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string FiltText { get; set; } // FILT_TEXT (length: 2147483647)
        public string IsAdmTkts { get; set; } = "N"; // IS_ADM_TKTS (length: 1)
        public string PrtIfNeedSig { get; set; } = "N"; // PRT_IF_NEED_SIG (length: 1)

        // Foreign keys

        /// <summary>
        /// Parent PsFrmGrp pointed by [PS_FRM_GRP_FRM].([FrmGrpId]) (FK_PS_FRM_GRP_FRM_PS_FRM_GRP)
        /// </summary>
        public virtual PsFrmGrp PsFrmGrp { get; set; } // FK_PS_FRM_GRP_FRM_PS_FRM_GRP
    }

}
// </auto-generated>

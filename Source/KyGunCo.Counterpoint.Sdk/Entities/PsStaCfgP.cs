// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_STA_CFG_PS
    public class PsStaCfgP
    {
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string StaId { get; set; } // STA_ID (Primary key) (length: 10)
        public string UseDfltCust { get; set; } = "N"; // USE_DFLT_CUST (length: 1)
        public string DfltLinMod { get; set; } = "S"; // DFLT_LIN_MOD (length: 1)
        public string BegTktAt { get; set; } = "C"; // BEG_TKT_AT (length: 1)
        public string BegLinAt { get; set; } = "I"; // BEG_LIN_AT (length: 1)
        public string DfltEntMod { get; set; } = "N"; // DFLT_ENT_MOD (length: 1)
        public string DfltTndPayCod { get; set; } // DFLT_TND_PAY_COD (length: 10)
        public string DfltChngPayCod { get; set; } // DFLT_CHNG_PAY_COD (length: 10)
        public string DfltRfndPayCod { get; set; } // DFLT_RFND_PAY_COD (length: 10)
        public string TouchScrnCod { get; set; } // TOUCH_SCRN_COD (length: 10)
        public string NxtTktNo { get; set; } // NXT_TKT_NO (length: 15)
        public string NxtTktNoAuto { get; set; } = "N"; // NXT_TKT_NO_AUTO (length: 1)
        public string NxtHoldNo { get; set; } // NXT_HOLD_NO (length: 15)
        public string NxtHoldNoAuto { get; set; } = "N"; // NXT_HOLD_NO_AUTO (length: 1)
        public string NxtQuotNo { get; set; } // NXT_QUOT_NO (length: 15)
        public string NxtQuotNoAuto { get; set; } = "N"; // NXT_QUOT_NO_AUTO (length: 1)
        public string NxtOrdNo { get; set; } // NXT_ORD_NO (length: 15)
        public string NxtOrdNoAuto { get; set; } = "N"; // NXT_ORD_NO_AUTO (length: 1)
        public string ServNam1 { get; set; } // SERV_NAM_1 (length: 100)
        public string ServNam2 { get; set; } // SERV_NAM_2 (length: 100)
        public string FrmTyp { get; set; } = "B"; // FRM_TYP (length: 1)
        public string UseAllFrmGrps { get; set; } = "Y"; // USE_ALL_FRM_GRPS (length: 1)
        public string ShowItemImg { get; set; } = "N"; // SHOW_ITEM_IMG (length: 1)
        public string ShowCustImg { get; set; } = "N"; // SHOW_CUST_IMG (length: 1)
        public string UseConsolLins { get; set; } = "N"; // USE_CONSOL_LINS (length: 1)
        public string SigCapAfterPrt { get; set; } = "N"; // SIG_CAP_AFTER_PRT (length: 1)
        public string OfflineNxtTktNo { get; set; } // OFFLINE_NXT_TKT_NO (length: 15)
        public string OfflineNxtHoldNo { get; set; } // OFFLINE_NXT_HOLD_NO (length: 15)
        public string OfflineNxtQuotNo { get; set; } // OFFLINE_NXT_QUOT_NO (length: 15)
        public string OfflineNxtOrdNo { get; set; } // OFFLINE_NXT_ORD_NO (length: 15)
        public string OfflineNxtTktNoAuto { get; set; } = "N"; // OFFLINE_NXT_TKT_NO_AUTO (length: 1)
        public string OfflineNxtHoldNoAuto { get; set; } = "N"; // OFFLINE_NXT_HOLD_NO_AUTO (length: 1)
        public string OfflineNxtQuotNoAuto { get; set; } = "N"; // OFFLINE_NXT_QUOT_NO_AUTO (length: 1)
        public string OfflineNxtOrdNoAuto { get; set; } = "N"; // OFFLINE_NXT_ORD_NO_AUTO (length: 1)
        public string OfflineNxtGfcNo { get; set; } // OFFLINE_NXT_GFC_NO (length: 30)
        public string OfflineNxtStcNo { get; set; } // OFFLINE_NXT_STC_NO (length: 30)
        public string OfflineNxtGfcNoAuto { get; set; } = "N"; // OFFLINE_NXT_GFC_NO_AUTO (length: 1)
        public string OfflineNxtStcNoAuto { get; set; } = "N"; // OFFLINE_NXT_STC_NO_AUTO (length: 1)
        public string OfflineNxtCustNo { get; set; } // OFFLINE_NXT_CUST_NO (length: 15)
        public string OfflineNxtCustNoAuto { get; set; } = "N"; // OFFLINE_NXT_CUST_NO_AUTO (length: 1)
        public string NxtLwyNo { get; set; } // NXT_LWY_NO (length: 15)
        public string NxtLwyNoAuto { get; set; } = "N"; // NXT_LWY_NO_AUTO (length: 1)
        public string OfflineNxtLwyNo { get; set; } // OFFLINE_NXT_LWY_NO (length: 15)
        public string OfflineNxtLwyNoAuto { get; set; } = "N"; // OFFLINE_NXT_LWY_NO_AUTO (length: 1)
        public string ShowRdmLoyPtsMsg { get; set; } = "N"; // SHOW_RDM_LOY_PTS_MSG (length: 1)
        public string UseTndPayCodForChng { get; set; } = "N"; // USE_TND_PAY_COD_FOR_CHNG (length: 1)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public long? PsHdrCustFldFrmId { get; set; } // PS_HDR_CUST_FLD_FRM_ID
        public long? PsPmtCustFldFrmId { get; set; } // PS_PMT_CUST_FLD_FRM_ID
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT
        public string AllowTip { get; set; } = "Y"; // ALLOW_TIP (length: 1)
        public string AllowViewTip { get; set; } = "Y"; // ALLOW_VIEW_TIP (length: 1)

        // Foreign keys

        /// <summary>
        /// Parent PsSta pointed by [PS_STA_CFG_PS].([StrId], [StaId]) (FK_PS_STA_CFG_PS_PS_STA)
        /// </summary>
        public virtual PsSta PsSta { get; set; } // FK_PS_STA_CFG_PS_PS_STA
    }

}
// </auto-generated>
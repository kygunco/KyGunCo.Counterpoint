// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_SY_USR_WITH_ADDRESS
    public class ViSyUsrWithAddress
    {
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string Nam { get; set; } // NAM (length: 40)
        public string NamUpr { get; set; } // NAM_UPR (length: 40)
        public string Initials { get; set; } // INITIALS (length: 5)
        public string Pwd { get; set; } // PWD (length: 32)
        public string Adrs1 { get; set; } // ADRS_1 (length: 40)
        public string Adrs2 { get; set; } // ADRS_2 (length: 40)
        public string Adrs3 { get; set; } // ADRS_3 (length: 40)
        public string City { get; set; } // CITY (length: 20)
        public string State { get; set; } // STATE (length: 10)
        public string ZipCod { get; set; } // ZIP_COD (length: 15)
        public string Cntry { get; set; } // CNTRY (length: 20)
        public string Contct1 { get; set; } // CONTCT_1 (length: 40)
        public string Contct2 { get; set; } // CONTCT_2 (length: 40)
        public string Phone1 { get; set; } // PHONE_1 (length: 25)
        public string Phone2 { get; set; } // PHONE_2 (length: 25)
        public string Fax1 { get; set; } // FAX_1 (length: 25)
        public string Fax2 { get; set; } // FAX_2 (length: 25)
        public string EmailAdrs1 { get; set; } // EMAIL_ADRS_1 (length: 50)
        public string EmailAdrs2 { get; set; } // EMAIL_ADRS_2 (length: 50)
        public string Url1 { get; set; } // URL_1 (length: 100)
        public string Url2 { get; set; } // URL_2 (length: 100)
        public string WrkgrpId { get; set; } // WRKGRP_ID (length: 10)
        public string AllowOthrWrkgrps { get; set; } // ALLOW_OTHR_WRKGRPS (length: 1)
        public string Dept { get; set; } // DEPT (length: 10)
        public string EmpNo { get; set; } // EMP_NO (length: 15)
        public string SecCod { get; set; } // SEC_COD (length: 10)
        public string IsPsUsr { get; set; } // IS_PS_USR (length: 1)
        public string IsPsMgr { get; set; } // IS_PS_MGR (length: 1)
        public string PsSecCod { get; set; } // PS_SEC_COD (length: 10)
        public string IsSlsRep { get; set; } // IS_SLS_REP (length: 1)
        public string IsBuyer { get; set; } // IS_BUYER (length: 1)
        public string LoginDisabled { get; set; } // LOGIN_DISABLED (length: 1)
        public string ChngPwdNxtLogin { get; set; } // CHNG_PWD_NXT_LOGIN (length: 1)
        public DateTime? LstPwdChngDat { get; set; } // LST_PWD_CHNG_DAT
        public DateTime? LstLoginDt { get; set; } // LST_LOGIN_DT
        public string LstStrId { get; set; } // LST_STR_ID (length: 10)
        public string LstStaId { get; set; } // LST_STA_ID (length: 10)
        public string LstDrwId { get; set; } // LST_DRW_ID (length: 10)
        public string CommisCod { get; set; } // COMMIS_COD (length: 10)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string LstWrkgrpId { get; set; } // LST_WRKGRP_ID (length: 10)
        public int LoginFailCnt { get; set; } // LOGIN_FAIL_CNT
        public string PrevPwd1 { get; set; } // PREV_PWD_1 (length: 32)
        public string PrevPwd2 { get; set; } // PREV_PWD_2 (length: 32)
        public string PrevPwd3 { get; set; } // PREV_PWD_3 (length: 32)
        public DateTime? LstClckInDt { get; set; } // LST_CLCK_IN_DT
        public DateTime? LstClckOutDt { get; set; } // LST_CLCK_OUT_DT
        public byte[] BioIdData { get; set; } // BIO_ID_DATA (length: 2147483647)
        public string LstLoginWkstnNam { get; set; } // LST_LOGIN_WKSTN_NAM (length: 128)
        public DateTime? LstTeLoginDt { get; set; } // LST_TE_LOGIN_DT
        public string LstTeWrkgrpId { get; set; } // LST_TE_WRKGRP_ID (length: 10)
        public string LstTeLoginWkstnNam { get; set; } // LST_TE_LOGIN_WKSTN_NAM (length: 128)
        public string CopyFrmUsrId { get; set; } // COPY_FRM_USR_ID (length: 10)
        public DateTime? RsUtcDt { get; set; } // RS_UTC_DT
        public string IsMailMgr { get; set; } // IS_MAIL_MGR (length: 1)
        public string AllowSendPopupmail { get; set; } // ALLOW_SEND_POPUPMAIL (length: 1)
        public string IsOmUsr { get; set; } // IS_OM_USR (length: 1)
        public byte RsStat { get; set; } // RS_STAT
        public string RptEmail { get; set; } // RPT_EMAIL (length: 1)
        public string MsrLoginId1 { get; set; } // MSR_LOGIN_ID_1 (length: 8)
        public string MsrLoginId2 { get; set; } // MSR_LOGIN_ID_2 (length: 32)
        public string UserEnableItemActivity { get; set; } // USER_ENABLE_ITEM_ACTIVITY (length: 1)
        public string UserEnableIsFirearm { get; set; } // USER_ENABLE_IS_FIREARM (length: 1)
        public string CityStateZipCntry { get; set; } // CITY_STATE_ZIP_CNTRY (length: 70)
        public string AdrsMsk { get; set; } // ADRS_MSK (length: 4)
        public string LblNumber { get; set; } // LBL_NUMBER (length: 10)
        public string LblName { get; set; } // LBL_NAME (length: 40)
        public string LblAddress1 { get; set; } // LBL_ADDRESS_1 (length: 70)
        public string LblAddress2 { get; set; } // LBL_ADDRESS_2 (length: 70)
        public string LblAddress3 { get; set; } // LBL_ADDRESS_3 (length: 70)
        public string LblAddress4 { get; set; } // LBL_ADDRESS_4 (length: 70)
    }

}
// </auto-generated>
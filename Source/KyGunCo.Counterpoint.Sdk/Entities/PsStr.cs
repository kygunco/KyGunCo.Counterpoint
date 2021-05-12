// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_STR
    public class PsStr
    {
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string Descr { get; set; } // DESCR (length: 50)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 50)
        public string Adrs1 { get; set; } // ADRS_1 (length: 40)
        public string Adrs2 { get; set; } // ADRS_2 (length: 40)
        public string Adrs3 { get; set; } // ADRS_3 (length: 40)
        public string City { get; set; } // CITY (length: 20)
        public string State { get; set; } // STATE (length: 10)
        public string ZipCod { get; set; } // ZIP_COD (length: 15)
        public string Cntry { get; set; } // CNTRY (length: 20)
        public string Phone1 { get; set; } // PHONE_1 (length: 25)
        public string Phone2 { get; set; } // PHONE_2 (length: 25)
        public string Fax1 { get; set; } // FAX_1 (length: 25)
        public string Fax2 { get; set; } // FAX_2 (length: 25)
        public string Contct1 { get; set; } // CONTCT_1 (length: 40)
        public string Contct2 { get; set; } // CONTCT_2 (length: 40)
        public string EmailAdrs1 { get; set; } // EMAIL_ADRS_1 (length: 50)
        public string EmailAdrs2 { get; set; } // EMAIL_ADRS_2 (length: 50)
        public string Url1 { get; set; } // URL_1 (length: 100)
        public string Url2 { get; set; } // URL_2 (length: 100)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public int? SlsArea { get; set; } // SLS_AREA
        public int? TotArea { get; set; } // TOT_AREA
        public string UsePs { get; set; } = "Y"; // USE_PS (length: 1)
        public string UseOe { get; set; } = "N"; // USE_OE (length: 1)
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public short StrNo { get; set; } // STR_NO
        public byte RsStat { get; set; } = 1; // RS_STAT
        public string UserAddCustFromDl { get; set; } = "N"; // USER_ADD_CUST_FROM_DL (length: 1)
        public string UserVerifyAgeFromDl { get; set; } = "N"; // USER_VERIFY_AGE_FROM_DL (length: 1)
        public string UserUpdateCustAdrsFromDl { get; set; } = "N"; // USER_UPDATE_CUST_ADRS_FROM_DL (length: 1)
        public string TaxIdNo { get; set; } // TAX_ID_NO (length: 30)
        public string User4473RequiredVerify { get; set; } // USER_4473_REQUIRED_VERIFY (length: 1)
        public string UserE4473AllowCashCust { get; set; } // USER_E4473_ALLOW_CASH_CUST (length: 1)
        public string UserRequireLongGunReporting { get; set; } = "N"; // USER_REQUIRE_LONG_GUN_REPORTING (length: 1)

        // Reverse navigation

        /// <summary>
        /// Child ArCusts where [AR_CUST].[STR_ID] point to this entity (FK_AR_CUST_PS_STR)
        /// </summary>
        public virtual IList<ArCust> ArCusts { get; set; } = new List<ArCust>(); // AR_CUST.FK_AR_CUST_PS_STR

        /// <summary>
        /// Child ArCustEcDels where [AR_CUST_EC_DEL].[STR_ID] point to this entity (FK_AR_CUST_EC_DEL_PS_STR)
        /// </summary>
        public virtual IList<ArCustEcDel> ArCustEcDels { get; set; } = new List<ArCustEcDel>(); // AR_CUST_EC_DEL.FK_AR_CUST_EC_DEL_PS_STR

        /// <summary>
        /// Child ArCustEcRenumbers where [AR_CUST_EC_RENUMBER].[STR_ID] point to this entity (FK_AR_CUST_EC_RENUMBER_PS_STR)
        /// </summary>
        public virtual IList<ArCustEcRenumber> ArCustEcRenumbers { get; set; } = new List<ArCustEcRenumber>(); // AR_CUST_EC_RENUMBER.FK_AR_CUST_EC_RENUMBER_PS_STR

        /// <summary>
        /// Child PsDrws where [PS_DRW].[STR_ID] point to this entity (FK_PS_DRW_PS_STR)
        /// </summary>
        public virtual IList<PsDrw> PsDrws { get; set; } = new List<PsDrw>(); // PS_DRW.FK_PS_DRW_PS_STR

        /// <summary>
        /// Child PsStas where [PS_STA].[STR_ID] point to this entity (FK_PS_STA_PS_STR)
        /// </summary>
        public virtual IList<PsSta> PsStas { get; set; } = new List<PsSta>(); // PS_STA.FK_PS_STA_PS_STR

        /// <summary>
        /// Child PsStrPayCods where [PS_STR_PAY_COD].[STR_ID] point to this entity (FK_PS_STR_PAY_COD_PS_STR)
        /// </summary>
        public virtual IList<PsStrPayCod> PsStrPayCods { get; set; } = new List<PsStrPayCod>(); // PS_STR_PAY_COD.FK_PS_STR_PAY_COD_PS_STR

        /// <summary>
        /// Child SyEdcTrxes where [SY_EDC_TRX].[STR_ID] point to this entity (FK_SY_EDC_TRX_PS_STR)
        /// </summary>
        public virtual IList<SyEdcTrx> SyEdcTrxes { get; set; } = new List<SyEdcTrx>(); // SY_EDC_TRX.FK_SY_EDC_TRX_PS_STR

        /// <summary>
        /// Parent (One-to-One) PsStr pointed by [PS_STR_CFG_PS].[STR_ID] (FK_PS_STR_CFG_PS_PS_STR)
        /// </summary>
        public virtual PsStrCfgP PsStrCfgP { get; set; } // PS_STR_CFG_PS.FK_PS_STR_CFG_PS_PS_STR
    }

}
// </auto-generated>

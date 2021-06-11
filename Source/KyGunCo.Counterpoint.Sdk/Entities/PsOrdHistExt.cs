// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_ORD_HIST_EXT
    public class PsOrdHistExt
    {
        public DateTime BusDatExt { get; set; } // BUS_DAT_EXT (Primary key)
        public long DocIdExt { get; set; } // DOC_ID_EXT (Primary key)
        public string UserNicsDros { get; set; } // USER_NICS_DROS (length: 30)
        public string User4473 { get; set; } // USER_4473 (length: 30)
        public string UserFfl { get; set; } // USER_FFL (length: 30)
        public string UserIntrfacdToShip { get; set; } // USER_INTRFACD_TO_SHIP (length: 1)
        public int? UserShipRespStat { get; set; } // USER_SHIP_RESP_STAT
        public string UserShipResp { get; set; } // USER_SHIP_RESP (length: 2147483647)
        public string UserEcommAuthCode { get; set; } // USER_ECOMM_AUTH_CODE (length: 10)
        public string UserEcommOrdNo { get; set; } // USER_ECOMM_ORD_NO (length: 15)
        public string UserEcommReceiptNo { get; set; } // USER_ECOMM_RECEIPT_NO (length: 10)
        public string UserDlData2D { get; set; } // USER_DL_DATA_2D (length: 2147483647)
        public int? E4473SeqNo { get; set; } // E4473_SEQ_NO
        public string E4473FirstName { get; set; } // E4473_FIRST_NAME (length: 256)
        public string E4473MiddleName { get; set; } // E4473_MIDDLE_NAME (length: 256)
        public string E4473LastName { get; set; } // E4473_LAST_NAME (length: 256)
        public string E4473Addrs1 { get; set; } // E4473_ADDRS_1 (length: 256)
        public string E4473Addrs2 { get; set; } // E4473_ADDRS_2 (length: 256)
        public string E4473City { get; set; } // E4473_CITY (length: 256)
        public string E4473County { get; set; } // E4473_COUNTY (length: 256)
        public string E4473State { get; set; } // E4473_STATE (length: 256)
        public string E4473ZipCod { get; set; } // E4473_ZIP_COD (length: 256)
        public string E4473ActivDutyAddrs1 { get; set; } // E4473_ACTIV_DUTY_ADDRS_1 (length: 256)
        public string E4473ActivDutyAddrs2 { get; set; } // E4473_ACTIV_DUTY_ADDRS_2 (length: 256)
        public string E4473ActivDutyCity { get; set; } // E4473_ACTIV_DUTY_CITY (length: 256)
        public string E4473ActivDutyCounty { get; set; } // E4473_ACTIV_DUTY_COUNTY (length: 256)
        public string E4473ActivDutyState { get; set; } // E4473_ACTIV_DUTY_STATE (length: 256)
        public string E4473ActivDutyZipCod { get; set; } // E4473_ACTIV_DUTY_ZIP_COD (length: 256)
        public string E4473Alien { get; set; } // E4473_ALIEN (length: 256)
        public string E4473AlienNum { get; set; } // E4473_ALIEN_NUM (length: 256)
        public string E4473Birthdate { get; set; } // E4473_BIRTHDATE (length: 256)
        public string E4473Citizenship { get; set; } // E4473_CITIZENSHIP (length: 256)
        public string E4473Ethnicity { get; set; } // E4473_ETHNICITY (length: 256)
        public string E4473Gender { get; set; } // E4473_GENDER (length: 256)
        public string E4473HeightFt { get; set; } // E4473_HEIGHT_FT (length: 256)
        public string E4473HeightIn { get; set; } // E4473_HEIGHT_IN (length: 256)
        public string E4473PlaceOfBirthCity { get; set; } // E4473_PLACE_OF_BIRTH_CITY (length: 256)
        public string E4473PlaceOfBirthForeign { get; set; } // E4473_PLACE_OF_BIRTH_FOREIGN (length: 256)
        public string E4473PlaceOfBirthState { get; set; } // E4473_PLACE_OF_BIRTH_STATE (length: 256)
        public string E4473Race { get; set; } // E4473_RACE (length: 256)
        public string E4473ResidenceState { get; set; } // E4473_RESIDENCE_STATE (length: 256)
        public string E4473SocSecNum { get; set; } // E4473_SOC_SEC_NUM (length: 256)
        public string E4473Weight { get; set; } // E4473_WEIGHT (length: 256)
        public string E4473Upin { get; set; } // E4473_UPIN (length: 256)
        public string E4473C11A { get; set; } // E4473_C11A (length: 256)
        public string E4473C11B { get; set; } // E4473_C11B (length: 256)
        public string E4473C11C { get; set; } // E4473_C11C (length: 256)
        public string E4473C11D { get; set; } // E4473_C11D (length: 256)
        public string E4473C11E { get; set; } // E4473_C11E (length: 256)
        public string E4473C11F { get; set; } // E4473_C11F (length: 256)
        public string E4473C11G { get; set; } // E4473_C11G (length: 256)
        public string E4473C11H { get; set; } // E4473_C11H (length: 256)
        public string E4473C11I { get; set; } // E4473_C11I (length: 256)
        public string E4473C11J { get; set; } // E4473_C11J (length: 256)
        public string E4473C11K { get; set; } // E4473_C11K (length: 256)
        public string E4473C11L { get; set; } // E4473_C11L (length: 256)
        public string E4473C12B { get; set; } // E4473_C12B (length: 256)
        public string E4473C12C { get; set; } // E4473_C12C (length: 256)
        public string E4473C12D1 { get; set; } // E4473_C12D1 (length: 256)
        public string E4473C12D2 { get; set; } // E4473_C12D2 (length: 256)
        public byte? UserShippingEasyStat { get; set; } // USER_SHIPPING_EASY_STAT
        public string UserShippingEasyResponse { get; set; } // USER_SHIPPING_EASY_RESPONSE (length: 1000)
        public int? UserShippingEasyId { get; set; } // USER_SHIPPING_EASY_ID
        public string UserIsLayaway { get; set; } = "N"; // USER_IS_LAYAWAY (length: 1)
        public string UserIsClass3 { get; set; } = "N"; // USER_IS_CLASS_3 (length: 1)
        public string UserIsVirtual { get; set; } = "N"; // USER_IS_VIRTUAL (length: 1)
        public string UserIssueRequiresCheck { get; set; } = "N"; // USER_ISSUE_REQUIRES_CHECK (length: 1)
        public string UserIssueRequiresPayment { get; set; } = "N"; // USER_ISSUE_REQUIRES_PAYMENT (length: 1)
        public string UserIssueRequiresFfl { get; set; } = "N"; // USER_ISSUE_REQUIRES_FFL (length: 1)
        public string UserIssueRequiresDocumentation { get; set; } = "N"; // USER_ISSUE_REQUIRES_DOCUMENTATION (length: 1)
        public string UserIssueIsOnOrder { get; set; } = "N"; // USER_ISSUE_IS_ON_ORDER (length: 1)

        // Foreign keys

        /// <summary>
        /// Parent PsOrdHist pointed by [PS_ORD_HIST_EXT].([BusDatExt], [DocIdExt]) (FK_PS_ORD_HIST_EXT_PS_ORD_HIST)
        /// </summary>
        public virtual PsOrdHist PsOrdHist { get; set; } // FK_PS_ORD_HIST_EXT_PS_ORD_HIST
    }

}
// </auto-generated>

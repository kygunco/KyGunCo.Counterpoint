// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

namespace KyGunCo.Counterpoint.Sdk.Data
{
    using System;
    using ServiceStack.DataAnnotations;
    using ServiceStack.Model;
    using ServiceStack;

    public partial class PS_VOID_HIST_EXT 
    {
        [References(typeof(PS_VOID_HIST))]
        [Required]
        public DateTime BUS_DAT_EXT { get; set; }
        [References(typeof(PS_VOID_HIST))]
        [Required]
        public long DOC_ID_EXT { get; set; }
        public string USER_INTRFACD_TO_SHIP { get; set; }
        public int? USER_SHIP_RESP_STAT { get; set; }
        public string USER_SHIP_RESP { get; set; }
        public string USER_ECOMM_AUTH_CODE { get; set; }
        public string USER_ECOMM_ORD_NO { get; set; }
        public string USER_ECOMM_RECEIPT_NO { get; set; }
        public string USER_DL_DATA_2D { get; set; }
        public string USER_NICS_DROS { get; set; }
        public string USER_FFL { get; set; }
        public string USER_4473 { get; set; }
        public int? E4473_SEQ_NO { get; set; }
        public string E4473_FIRST_NAME { get; set; }
        public string E4473_MIDDLE_NAME { get; set; }
        public string E4473_LAST_NAME { get; set; }
        public string E4473_ADDRS_1 { get; set; }
        public string E4473_ADDRS_2 { get; set; }
        public string E4473_CITY { get; set; }
        public string E4473_COUNTY { get; set; }
        public string E4473_STATE { get; set; }
        public string E4473_ZIP_COD { get; set; }
        public string E4473_ACTIV_DUTY_ADDRS_1 { get; set; }
        public string E4473_ACTIV_DUTY_ADDRS_2 { get; set; }
        public string E4473_ACTIV_DUTY_CITY { get; set; }
        public string E4473_ACTIV_DUTY_COUNTY { get; set; }
        public string E4473_ACTIV_DUTY_STATE { get; set; }
        public string E4473_ACTIV_DUTY_ZIP_COD { get; set; }
        public string E4473_ALIEN { get; set; }
        public string E4473_ALIEN_NUM { get; set; }
        public string E4473_BIRTHDATE { get; set; }
        public string E4473_CITIZENSHIP { get; set; }
        public string E4473_ETHNICITY { get; set; }
        public string E4473_GENDER { get; set; }
        public string E4473_HEIGHT_FT { get; set; }
        public string E4473_HEIGHT_IN { get; set; }
        public string E4473_PLACE_OF_BIRTH_CITY { get; set; }
        public string E4473_PLACE_OF_BIRTH_FOREIGN { get; set; }
        public string E4473_PLACE_OF_BIRTH_STATE { get; set; }
        public string E4473_RACE { get; set; }
        public string E4473_RESIDENCE_STATE { get; set; }
        public string E4473_SOC_SEC_NUM { get; set; }
        public string E4473_WEIGHT { get; set; }
        public string E4473_UPIN { get; set; }
        public string E4473_C11A { get; set; }
        public string E4473_C11B { get; set; }
        public string E4473_C11C { get; set; }
        public string E4473_C11D { get; set; }
        public string E4473_C11E { get; set; }
        public string E4473_C11F { get; set; }
        public string E4473_C11G { get; set; }
        public string E4473_C11H { get; set; }
        public string E4473_C11I { get; set; }
        public string E4473_C11J { get; set; }
        public string E4473_C11K { get; set; }
        public string E4473_C11L { get; set; }
        public string E4473_C12B { get; set; }
        public string E4473_C12C { get; set; }
        public string E4473_C12D1 { get; set; }
        public string E4473_C12D2 { get; set; }
        public byte? USER_SHIPPING_EASY_STAT { get; set; }
        public string USER_SHIPPING_EASY_RESPONSE { get; set; }
        public int? USER_SHIPPING_EASY_ID { get; set; }
        public string USER_OPTICS_OWL_ID { get; set; }
    }

}
#pragma warning restore 1591

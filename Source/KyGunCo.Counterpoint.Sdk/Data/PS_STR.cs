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

    public partial class PS_STR 
    {
        [Required]
        [PrimaryKey]
        public string STR_ID { get; set; }
        [Required]
        public string DESCR { get; set; }
        public string DESCR_UPR { get; set; }
        public string ADRS_1 { get; set; }
        public string ADRS_2 { get; set; }
        public string ADRS_3 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string ZIP_COD { get; set; }
        public string CNTRY { get; set; }
        public string PHONE_1 { get; set; }
        public string PHONE_2 { get; set; }
        public string FAX_1 { get; set; }
        public string FAX_2 { get; set; }
        public string CONTCT_1 { get; set; }
        public string CONTCT_2 { get; set; }
        public string EMAIL_ADRS_1 { get; set; }
        public string EMAIL_ADRS_2 { get; set; }
        public string URL_1 { get; set; }
        public string URL_2 { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        public int? SLS_AREA { get; set; }
        public int? TOT_AREA { get; set; }
        [Required]
        public string USE_PS { get; set; }
        [Required]
        public string USE_OE { get; set; }
        public DateTime? RS_UTC_DT { get; set; }
        [Required]
        public short STR_NO { get; set; }
        [Required]
        public byte RS_STAT { get; set; }
        public string USER_ADD_CUST_FROM_DL { get; set; }
        public string USER_VERIFY_AGE_FROM_DL { get; set; }
        public string USER_UPDATE_CUST_ADRS_FROM_DL { get; set; }
        public string TAX_ID_NO { get; set; }
        public string USER_4473_REQUIRED_VERIFY { get; set; }
        public string USER_E4473_ALLOW_CASH_CUST { get; set; }
        public string USER_REQUIRE_LONG_GUN_REPORTING { get; set; }
    }

}
#pragma warning restore 1591

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

    public partial class AR_SHIP_ADRS 
    {
        [References(typeof(AR_CUST))]
        [Required]
        public string CUST_NO { get; set; }
        [Required]
        public string SHIP_ADRS_ID { get; set; }
        [Required]
        public string NAM { get; set; }
        public string NAM_UPR { get; set; }
        public string FST_NAM { get; set; }
        public string FST_NAM_UPR { get; set; }
        public string LST_NAM { get; set; }
        public string LST_NAM_UPR { get; set; }
        public string SALUTATION { get; set; }
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
        public string SHIP_ZONE_COD { get; set; }
        public string SHIP_VIA_COD { get; set; }
        public string TAX_COD { get; set; }
        public string COMMNT { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        [Required]
        public string SHIP_NAM_TYP { get; set; }
        [Compute]
        public string SHIP_FST_LST_NAM { get; set; }
    }

}
#pragma warning restore 1591

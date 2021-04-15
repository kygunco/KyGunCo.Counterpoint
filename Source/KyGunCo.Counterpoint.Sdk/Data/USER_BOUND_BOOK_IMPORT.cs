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

    public partial class USER_BOUND_BOOK_IMPORT 
    {
        [Required]
        public string ACQ_DOC_NO { get; set; }
        [Required]
        public string ACQ_TRANS_TYPE { get; set; }
        [Required]
        public string ITEM_NO { get; set; }
        [Required]
        public string SER_NO { get; set; }
        [Required]
        public string LOC_ID { get; set; }
        [Required]
        public string DESCR { get; set; }
        public string USER_MANUFACTURER { get; set; }
        public string USER_IMPORTER { get; set; }
        public string USER_MODEL { get; set; }
        public string USER_ACTION { get; set; }
        public string USER_CALIBER_GAUGE { get; set; }
        public string USER_ATF_TYPE { get; set; }
        public string USER_STATE_TYPE { get; set; }
        public DateTime? ACQ_DATE { get; set; }
        public string ACQ_VEND_NO { get; set; }
        public string ACQ_CUST_NO { get; set; }
        public string ACQ_NAME { get; set; }
        public string ACQ_ADRS_1 { get; set; }
        public string ACQ_ADRS_2 { get; set; }
        public string ACQ_CITY { get; set; }
        public string ACQ_STATE { get; set; }
        public string ACQ_ZIP_CODE { get; set; }
        public string ACQ_FFL { get; set; }
        public string ACQ_DOJ_VERIFICATION_NO { get; set; }
        public string ACQ_USR_ID { get; set; }
        public string DISP_DOC_NO { get; set; }
        public string DISP_TRANS_TYPE { get; set; }
        public string DISP_DATE { get; set; }
        public string DISP_VEND_NO { get; set; }
        public string DISP_CUST_NO { get; set; }
        public string DISP_NAME { get; set; }
        public string DISP_ADRS_1 { get; set; }
        public string DISP_ADRS_2 { get; set; }
        public string DISP_CITY { get; set; }
        public string DISP_STATE { get; set; }
        public string DISP_ZIP_CODE { get; set; }
        public string DISP_FFL { get; set; }
        public string DISP_4473 { get; set; }
        public string DISP_APPROVAL_NO { get; set; }
        public DateTime? DISP_DOB { get; set; }
        public string DISP_USR_ID { get; set; }
        public string CHANGE_NOTES { get; set; }
        [Required]
        public DateTime LST_UPDATE_DT { get; set; }
        [Required]
        public string LST_UPDATE_USR_ID { get; set; }
        [AutoIncrement]
        public int BOUND_BOOK_SEQ_NO { get; set; }
        public string BOUND_BOOK_LOC_SEQ_NO { get; set; }
        [Compute]
        public int? BOUND_BOOK_PAGE_NO { get; set; }
        [Compute]
        public int? BOUND_BOOK_PAGE_SEQ_NO { get; set; }
        public string USER_COUNTRY_OF_ORIGIN { get; set; }
        public string COR_SER_NO { get; set; }
        public string BOUND_BOOK_TYPE { get; set; }
        public string BOUND_BOOK_TYPE_LOC_SEQ_NO { get; set; }
    }

}
#pragma warning restore 1591

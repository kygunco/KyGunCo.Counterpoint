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

    public partial class PS_CTL 
    {
        [Required]
        [PrimaryKey]
        public int KEY_ID { get; set; }
        public string CUST_AUTO_NOTE_ID { get; set; }
        public string ITEM_AUTO_NOTE_ID { get; set; }
        [Required]
        public string USE_MISC_1 { get; set; }
        public string MISC_1_ACCT_NO { get; set; }
        [Required]
        public string MISC_1_METH { get; set; }
        [Required]
        public string USE_MISC_2 { get; set; }
        public string MISC_2_ACCT_NO { get; set; }
        [Required]
        public string MISC_2_METH { get; set; }
        [Required]
        public string USE_MISC_3 { get; set; }
        public string MISC_3_ACCT_NO { get; set; }
        [Required]
        public string MISC_3_METH { get; set; }
        [Required]
        public string USE_MISC_4 { get; set; }
        public string MISC_4_ACCT_NO { get; set; }
        [Required]
        public string MISC_4_METH { get; set; }
        [Required]
        public string USE_MISC_5 { get; set; }
        public string MISC_5_ACCT_NO { get; set; }
        [Required]
        public string MISC_5_METH { get; set; }
        [Required]
        public string DRW_SUM_JRNL_METH { get; set; }
        [Required]
        public string TKT_AUDT_JRNL_METH { get; set; }
        [Required]
        public string TKT_PROF_ALPHA_1 { get; set; }
        [Required]
        public string TKT_PROF_ALPHA_2 { get; set; }
        [Required]
        public string TKT_PROF_ALPHA_3 { get; set; }
        [Required]
        public string TKT_PROF_ALPHA_4 { get; set; }
        [Required]
        public string TKT_PROF_ALPHA_5 { get; set; }
        [Required]
        public string TKT_PROF_COD_1 { get; set; }
        [Required]
        public string TKT_PROF_COD_2 { get; set; }
        [Required]
        public string TKT_PROF_COD_3 { get; set; }
        [Required]
        public string TKT_PROF_COD_4 { get; set; }
        [Required]
        public string TKT_PROF_COD_5 { get; set; }
        [Required]
        public string TKT_PROF_DAT_1 { get; set; }
        [Required]
        public string TKT_PROF_DAT_2 { get; set; }
        [Required]
        public string TKT_PROF_DAT_3 { get; set; }
        [Required]
        public string TKT_PROF_DAT_4 { get; set; }
        [Required]
        public string TKT_PROF_DAT_5 { get; set; }
        [Required]
        public string TKT_PROF_NO_1 { get; set; }
        [Required]
        public string TKT_PROF_NO_2 { get; set; }
        [Required]
        public string TKT_PROF_NO_3 { get; set; }
        [Required]
        public string TKT_PROF_NO_4 { get; set; }
        [Required]
        public string TKT_PROF_NO_5 { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        [Required]
        public string DRW_SUM_JRNL_DIST { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        [Required]
        public string Z_TAPE_PRT_METH { get; set; }
        [Required]
        public string SETTLE_JRNL_PRT_METH { get; set; }
        [Required]
        public string ORD_AUDT_JRNL_METH { get; set; }
        [Required]
        public string LWY_AUDT_JRNL_METH { get; set; }
        [Required]
        public string USE_MISC_5_AS_DISC { get; set; }
        public DateTime? RS_UTC_DT { get; set; }
        [Required]
        public string BATCH_REL_REV_METH { get; set; }
        [Required]
        public string FREIGHT_MISC { get; set; }
        [Required]
        public byte RS_STAT { get; set; }
        [Required]
        public string DISP_CLS_DRW_DLG { get; set; }
        [Required]
        public string RELOAD_TKT_BEFORE_PRNT { get; set; }
        [Required]
        public string LOAD_EXT_VIEW_BEFORE_PRNT { get; set; }
    }

}
#pragma warning restore 1591

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

    public partial class AR_LOY_PT_ADJ_HIST 
    {
        [Required]
        public string EVENT_NO { get; set; }
        [Required]
        public string BAT_ID { get; set; }
        [Required]
        public string CUST_NO { get; set; }
        [Required]
        public DateTime TRX_DAT { get; set; }
        public string DOC_NO { get; set; }
        public int? ENTRY_SEQ_NO { get; set; }
        [Required]
        public int NO_OF_PTS { get; set; }
        public string COMMNT { get; set; }
        [Required]
        public int PT_BAL_BEFORE { get; set; }
        [Required]
        public string LOY_PGM_COD { get; set; }
        [References(typeof(PS_STR_HIST))]
        public string CUST_STR_ID { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
    }

}
#pragma warning restore 1591

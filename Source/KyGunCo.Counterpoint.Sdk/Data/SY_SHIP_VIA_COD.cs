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

    public partial class SY_SHIP_VIA_COD 
    {
        [Required]
        [PrimaryKey]
        public string SHIP_VIA_COD { get; set; }
        [Required]
        public string DESCR { get; set; }
        public string DESCR_UPR { get; set; }
        [Required]
        public string VAL_FOR_VEND { get; set; }
        [Required]
        public string VAL_FOR_CUST { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        public DateTime? RS_UTC_DT { get; set; }
        [Required]
        public byte RS_STAT { get; set; }
    }

}
#pragma warning restore 1591

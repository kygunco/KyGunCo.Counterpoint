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

    public partial class IM_ITEM_PURGE_WRK 
    {
        [Required]
        public string SESS_ID { get; set; }
        [Required]
        public string ITEM_NO { get; set; }
        public string PURGE_STAT { get; set; }
        public DateTime? LST_SAL_DAT { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        [Compute]
        [Required]
        public string CAN_PURGE { get; set; }
    }

}
#pragma warning restore 1591

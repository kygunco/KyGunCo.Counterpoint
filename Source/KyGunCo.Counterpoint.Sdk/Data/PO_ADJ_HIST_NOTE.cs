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

    public partial class PO_ADJ_HIST_NOTE 
    {
        [References(typeof(PO_ADJ_HIST))]
        [Required]
        public string EVENT_NO { get; set; }
        [References(typeof(PO_ADJ_HIST))]
        [Required]
        public string RECVR_NO { get; set; }
        [Required]
        public string NOTE_ID { get; set; }
        public DateTime? NOTE_DAT { get; set; }
        public string USR_ID { get; set; }
        public string NOTE { get; set; }
        public string NOTE_TXT { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
    }

}
#pragma warning restore 1591

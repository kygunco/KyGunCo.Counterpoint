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

    public partial class PS_TKT_HIST_LIN_LOY 
    {
        [References(typeof(PS_TKT_HIST_LIN))]
        [Required]
        public DateTime BUS_DAT { get; set; }
        [References(typeof(PS_TKT_HIST_LIN))]
        [Required]
        public long DOC_ID { get; set; }
        [References(typeof(PS_TKT_HIST_LIN))]
        [Required]
        public int LIN_SEQ_NO { get; set; }
        [Required]
        public decimal LIN_LOY_PTS_EARND { get; set; }
        [Required]
        public string LOY_PGM_RDM_ELIG { get; set; }
        [Required]
        public decimal LOY_PGM_AMT_PD_WITH_PTS { get; set; }
        public string LOY_PT_EARN_RUL_DESCR { get; set; }
        public int? LOY_PT_EARN_RUL_SEQ_NO { get; set; }
        public string LOY_PT_RDM_RUL_DESCR { get; set; }
        public int? LOY_PT_RDM_RUL_SEQ_NO { get; set; }
    }

}
#pragma warning restore 1591

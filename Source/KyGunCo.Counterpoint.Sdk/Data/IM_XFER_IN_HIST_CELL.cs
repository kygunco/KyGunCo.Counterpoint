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

    public partial class IM_XFER_IN_HIST_CELL 
    {
        [References(typeof(IM_XFER_IN_HIST_LIN))]
        [Required]
        public string XFER_NO { get; set; }
        [References(typeof(IM_XFER_IN_HIST_LIN))]
        [Required]
        public string EVENT_NO { get; set; }
        [References(typeof(IM_XFER_IN_HIST_LIN))]
        [Required]
        public int XFER_IN_LIN_SEQ_NO { get; set; }
        [Required]
        public string DIM_1_UPR { get; set; }
        [Required]
        public string DIM_2_UPR { get; set; }
        [Required]
        public string DIM_3_UPR { get; set; }
        public decimal? PREV_QTY_EXPECTD { get; set; }
        public decimal? QTY_RECVD { get; set; }
        [Required]
        public decimal NEW_QTY_EXPECTD { get; set; }
        public decimal? TO_QOH_BEFORE { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        [Compute]
        [Required]
        public string ADDED_DURING_ENT { get; set; }
    }

}
#pragma warning restore 1591

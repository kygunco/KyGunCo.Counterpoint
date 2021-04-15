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

    public partial class PS_VOID_HIST_LIN_PO 
    {
        [References(typeof(PS_VOID_HIST_LIN))]
        [Required]
        public DateTime BUS_DAT { get; set; }
        [References(typeof(PS_VOID_HIST_LIN))]
        [Required]
        public long DOC_ID { get; set; }
        [References(typeof(PS_VOID_HIST_LIN))]
        [Required]
        public int LIN_SEQ_NO { get; set; }
        public string PO_PREQ_NO { get; set; }
        public string PO_ORD_NO { get; set; }
        public int? PO_LIN_SEQ_NO { get; set; }
        public string PO_RECVR_NO { get; set; }
        public int? PO_RECVR_LIN_SEQ_NO { get; set; }
        public decimal? PO_TOT_QTY_RECVD { get; set; }
        public decimal? PO_QTY_EXPECTD { get; set; }
        public int? PO_RECVR_CNT { get; set; }
    }

}
#pragma warning restore 1591

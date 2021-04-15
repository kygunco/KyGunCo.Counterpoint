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

    public partial class VI_PO_RECVR_CELL 
    {
        [Required]
        public string RECVR_NO { get; set; }
        [Required]
        public int SEQ_NO { get; set; }
        [Required]
        public string ALLOC_LOC_ID { get; set; }
        [Required]
        public string DIM_1_UPR { get; set; }
        [Required]
        public string DIM_2_UPR { get; set; }
        [Required]
        public string DIM_3_UPR { get; set; }
        [Required]
        public decimal QTY_RECVD { get; set; }
        public decimal? NEW_QTY_EXPECTD { get; set; }
        public decimal? PREV_QTY_EXPECTD { get; set; }
        public string DisplayLabel1 { get; set; }
        public string DisplayLabel2 { get; set; }
        public string DisplayLabel3 { get; set; }
        public string DisplayDim1Value { get; set; }
        public string DisplayDim2Value { get; set; }
        public string DisplayDim3Value { get; set; }
        public int? DisplayDim1SeqNo { get; set; }
        public int? DisplayDim2SeqNo { get; set; }
        public int? DisplayDim3SeqNo { get; set; }
    }

}
#pragma warning restore 1591

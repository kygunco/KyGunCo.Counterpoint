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

    public partial class PO_PREQ_CELL_LOC 
    {
        [References(typeof(PO_PREQ_CELL))]
        [Required]
        public string PREQ_NO { get; set; }
        [References(typeof(PO_PREQ_CELL))]
        [Required]
        public int SEQ_NO { get; set; }
        [References(typeof(PO_PREQ_LIN_LOC))]
        [Required]
        public string LOC_ID { get; set; }
        [References(typeof(PO_PREQ_CELL))]
        [Required]
        public string DIM_1_UPR { get; set; }
        [References(typeof(PO_PREQ_CELL))]
        [Required]
        public string DIM_2_UPR { get; set; }
        [References(typeof(PO_PREQ_CELL))]
        [Required]
        public string DIM_3_UPR { get; set; }
        [Required]
        public decimal ORD_QTY { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
    }

}
#pragma warning restore 1591

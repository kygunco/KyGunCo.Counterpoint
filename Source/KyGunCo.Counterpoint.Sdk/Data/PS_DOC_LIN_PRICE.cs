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

    public partial class PS_DOC_LIN_PRICE 
    {
        [References(typeof(PS_DOC_LIN))]
        [Required]
        public long DOC_ID { get; set; }
        [References(typeof(PS_DOC_LIN))]
        [Required]
        public int LIN_SEQ_NO { get; set; }
        public string PRC_JUST_STR { get; set; }
        public string PRC_GRP_COD { get; set; }
        public string PRC_GRP_DESCR { get; set; }
        public string PRC_RUL_DESCR { get; set; }
        [Required]
        public string PRC_GRP_TYP { get; set; }
        public int? PRC_RUL_SEQ_NO { get; set; }
        public string PRC_BRK_DESCR { get; set; }
        [Required]
        public short PRC_SEQ_NO { get; set; }
        [Required]
        public decimal QTY_PRCD { get; set; }
        [Required]
        public decimal UNIT_PRC { get; set; }
        public string DIM_1_UPR { get; set; }
        public string DIM_2_UPR { get; set; }
        public string DIM_3_UPR { get; set; }
    }

}
#pragma warning restore 1591

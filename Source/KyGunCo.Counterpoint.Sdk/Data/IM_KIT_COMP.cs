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

    public partial class IM_KIT_COMP 
    {
        [References(typeof(IM_KIT_PAR))]
        [Required]
        public string ITEM_NO { get; set; }
        [Required]
        public int COMP_SEQ_NO { get; set; }
        [Required]
        public string COMP_ITEM_NO { get; set; }
        [Required]
        public string COMP_DIM_1_UPR { get; set; }
        [Required]
        public string COMP_DIM_2_UPR { get; set; }
        [Required]
        public string COMP_DIM_3_UPR { get; set; }
        public string COMP_CELL_DESCR { get; set; }
        [Required]
        public decimal COMP_QTY { get; set; }
        [Required]
        public string COMP_QTY_UNIT_FLG { get; set; }
        [Required]
        public string COMP_QTY_METH { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        public string COMP_PROMPT { get; set; }
        [Required]
        public string SUBS_TYP { get; set; }
        [Required]
        public string PRC_ADJ_TYP { get; set; }
        [Required]
        public string ADJ_PRC_LVL { get; set; }
        [Required]
        public string PROMPT_FOR_CELL { get; set; }
        [Compute]
        [Required]
        public string REQUIRED_COMP { get; set; }
    }

}
#pragma warning restore 1591

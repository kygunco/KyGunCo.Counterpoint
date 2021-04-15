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

    public partial class VI_PS_DOC_LIN_SER 
    {
        [Required]
        public long DOC_ID { get; set; }
        [Required]
        public int LIN_SEQ_NO { get; set; }
        [Required]
        public int SEQ_NO { get; set; }
        [Required]
        public string STR_ID { get; set; }
        [Required]
        public string STA_ID { get; set; }
        [Required]
        public string TKT_NO { get; set; }
        [Required]
        public string SER_NO { get; set; }
        public int? SER_SEQ_NO { get; set; }
        public decimal? SER_COST { get; set; }
        [Required]
        public decimal QTY_RET { get; set; }
        public decimal? PROMPT_NO_1 { get; set; }
        public string PROMPT_COD_1 { get; set; }
        public string PROMPT_ALPHA_1 { get; set; }
        public DateTime? PROMPT_DAT_1 { get; set; }
        public string PROMPT_1_STR { get; set; }
        public decimal? PROMPT_NO_2 { get; set; }
        public string PROMPT_COD_2 { get; set; }
        public string PROMPT_ALPHA_2 { get; set; }
        public DateTime? PROMPT_DAT_2 { get; set; }
        public string PROMPT_2_STR { get; set; }
        public decimal? PROMPT_NO_3 { get; set; }
        public string PROMPT_COD_3 { get; set; }
        public string PROMPT_ALPHA_3 { get; set; }
        public DateTime? PROMPT_DAT_3 { get; set; }
        public string PROMPT_3_STR { get; set; }
        public long? DOC_ID_EXT { get; set; }
        public int? LIN_SEQ_NO_EXT { get; set; }
        public string SER_NO_EXT { get; set; }
    }

}
#pragma warning restore 1591

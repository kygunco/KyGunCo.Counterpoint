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

    public partial class USER_ITEM_CONVERSION 
    {
        [Required]
        [PrimaryKey]
        public string DOC_NO { get; set; }
        public string FROM_ITEM_NO { get; set; }
        public string FROM_LOC_ID { get; set; }
        public string TO_ITEM_NO { get; set; }
        public string TO_LOC_ID { get; set; }
        public decimal? QTY { get; set; }
        public decimal? COST { get; set; }
        public string REAS_COD { get; set; }
        public string BAT_ID { get; set; }
        public string ERR_REF { get; set; }
    }

}
#pragma warning restore 1591

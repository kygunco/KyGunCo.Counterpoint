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

    public partial class USER_ITEM_ON_SALE_INFO 
    {
        [References(typeof(IM_ITEM))]
        [Required]
        public string ITEM_NO { get; set; }
        [Required]
        public string STR_ID { get; set; }
        public string UNIT { get; set; }
        public string ON_SALE { get; set; }
        public decimal? SALE_PRICE { get; set; }
        public string SALE_END_DT { get; set; }
        public string GRP_COD { get; set; }
        public decimal? ALT_1_PRC_1 { get; set; }
        public decimal? ALT_2_PRC_1 { get; set; }
        public decimal? ALT_3_PRC_1 { get; set; }
        public decimal? ALT_4_PRC_1 { get; set; }
        public decimal? ALT_5_PRC_1 { get; set; }
        public decimal? ALT_1_PRC_2 { get; set; }
        public decimal? ALT_2_PRC_2 { get; set; }
        public decimal? ALT_3_PRC_2 { get; set; }
        public decimal? ALT_4_PRC_2 { get; set; }
        public decimal? ALT_5_PRC_2 { get; set; }
    }

}
#pragma warning restore 1591

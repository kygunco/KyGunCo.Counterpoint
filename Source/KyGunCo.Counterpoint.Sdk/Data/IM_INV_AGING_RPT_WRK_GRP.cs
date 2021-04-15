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

    public partial class IM_INV_AGING_RPT_WRK_GRP 
    {
        [Required]
        public string SESS_ID { get; set; }
        [Required]
        public string GRP_ID { get; set; }
        public decimal? COST_ON_HND { get; set; }
        public decimal? QTY_ON_HND { get; set; }
        public decimal? COST_AGED_1 { get; set; }
        public decimal? QTY_AGED_1 { get; set; }
        public decimal? COST_AGED_2 { get; set; }
        public decimal? QTY_AGED_2 { get; set; }
        public decimal? COST_AGED_3 { get; set; }
        public decimal? QTY_AGED_3 { get; set; }
        public decimal? COST_AGED_4 { get; set; }
        public decimal? QTY_AGED_4 { get; set; }
        public decimal? COST_AGED_5 { get; set; }
        public decimal? QTY_AGED_5 { get; set; }
        [Compute]
        public decimal? COST_AGED_BEFORE_1 { get; set; }
        [Compute]
        public decimal? COST_AGED_BEFORE_2 { get; set; }
        [Compute]
        public decimal? COST_AGED_BEFORE_3 { get; set; }
        [Compute]
        public decimal? COST_AGED_AFTER_3 { get; set; }
        [Compute]
        public decimal? COST_AGED_AFTER_4 { get; set; }
        [Compute]
        public decimal? COST_AGED_AFTER_5 { get; set; }
        [Compute]
        public decimal? QTY_AGED_BEFORE_1 { get; set; }
        [Compute]
        public decimal? QTY_AGED_BEFORE_2 { get; set; }
        [Compute]
        public decimal? QTY_AGED_BEFORE_3 { get; set; }
        [Compute]
        public decimal? QTY_AGED_AFTER_3 { get; set; }
        [Compute]
        public decimal? QTY_AGED_AFTER_4 { get; set; }
        [Compute]
        public decimal? QTY_AGED_AFTER_5 { get; set; }
    }

}
#pragma warning restore 1591

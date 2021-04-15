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

    public partial class USER_RANGE_WAIT 
    {
        [Required]
        public string STR_ID { get; set; }
        [Required]
        public string ITEM_NO { get; set; }
        [Required]
        public string CUST_NO { get; set; }
        [Required]
        public DateTime ARRIVAL_DT { get; set; }
        public int? MIN_PURCHASED { get; set; }
        public int? NBR_SHOOTERS { get; set; }
        public string ALT_CUSTOMER_1 { get; set; }
        public string ALT_CUSTOMER_2 { get; set; }
        public string ALT_CUSTOMER_3 { get; set; }
        public string ALT_CUSTOMER_4 { get; set; }
        public string ALT_CUSTOMER_5 { get; set; }
        public string ALT_CUSTOMER_6 { get; set; }
        public string ALT_CUSTOMER_7 { get; set; }
        [Required]
        public long DOC_ID { get; set; }
        [Required]
        public int LIN_SEQ_NO { get; set; }
        [AutoIncrement]
        public int IDENTIFIER { get; set; }
    }

}
#pragma warning restore 1591

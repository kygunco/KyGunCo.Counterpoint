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

    public partial class RS_CTL 
    {
        [Required]
        [PrimaryKey]
        public int KEY_ID { get; set; }
        public string STR_ID { get; set; }
        public string STA_ID { get; set; }
        [Required]
        public bool IS_SITE_SERVER { get; set; }
        public string PARENT_SERV_NAM { get; set; }
        [Required]
        public int EXTRACTION_FREQ_SECS { get; set; }
        [Required]
        public string EXTRACTION_ENABLED { get; set; }
        public DateTime? LAST_EXTRACTION_DT { get; set; }
    }

}
#pragma warning restore 1591

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

    public partial class PS_DOC_AUDIT_LOG 
    {
        [References(typeof(PS_DOC_HDR))]
        [Required]
        public long DOC_ID { get; set; }
        [Required]
        public int LOG_SEQ_NO { get; set; }
        [Required]
        public string DOC_TYP { get; set; }
        [Required]
        public Guid DOC_GUID { get; set; }
        public DateTime? CURR_DT { get; set; }
        public string CURR_STR_ID { get; set; }
        public string CURR_STA_ID { get; set; }
        public string CURR_DRW_ID { get; set; }
        public string CURR_USR_ID { get; set; }
        public string CURR_WKSTN_NAM { get; set; }
        public string CURR_SERV_NAM { get; set; }
        public string CURR_DB_NAM { get; set; }
        [Required]
        public string ACTIV { get; set; }
        public string LINK_STR_ID { get; set; }
        public string LINK_STA_ID { get; set; }
        public string LINK_DOC_NO { get; set; }
        public Guid? LINK_DOC_GUID { get; set; }
        public string LOG_ENTRY { get; set; }
    }

}
#pragma warning restore 1591

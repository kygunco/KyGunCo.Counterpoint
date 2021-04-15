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

    public partial class VI_PHYS_CNT_EVENTS 
    {
        [Required]
        public string EVENT_NO { get; set; }
        [Required]
        public string PKG_ID { get; set; }
        [Required]
        public string EVENT_TYP { get; set; }
        [Required]
        public string USR_ID { get; set; }
        public DateTime? EVENT_DAT { get; set; }
        public DateTime? EVENT_TIM { get; set; }
        [Required]
        public string SYS_ERR { get; set; }
        public string SYS_ERR_REF { get; set; }
        public int? TRX_CNT { get; set; }
        public int? POST_CNT { get; set; }
        public int? BR_ERR_CNT { get; set; }
        public int? DB_ERR_CNT { get; set; }
        public string BAT_ID { get; set; }
        public string STR_ID { get; set; }
        public string DRW_ID { get; set; }
        public DateTime? POST_DAT { get; set; }
        public string ADDL_PARAMS { get; set; }
        public string WRKGRP_ID { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        public string WKSTN_NAM { get; set; }
        public string SERV_NAM { get; set; }
        public string DB_NAM { get; set; }
        public string SW_VER_INI { get; set; }
        public string SW_VER_EXE { get; set; }
        public DateTime? SW_VER_BUILD_DT { get; set; }
        public DateTime? FST_POST_DAT { get; set; }
        public DateTime? LST_POST_DAT { get; set; }
        public DateTime? EVENT_DT { get; set; }
        public long? DRW_SESSION_ID { get; set; }
        public int? ORIG_SITE_ID { get; set; }
    }

}
#pragma warning restore 1591

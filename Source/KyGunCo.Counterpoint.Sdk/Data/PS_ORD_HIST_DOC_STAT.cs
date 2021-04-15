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

    public partial class PS_ORD_HIST_DOC_STAT 
    {
        [References(typeof(PS_ORD_HIST))]
        [Required]
        public DateTime BUS_DAT { get; set; }
        [References(typeof(PS_ORD_HIST))]
        [Required]
        public long DOC_ID { get; set; }
        [Required]
        public string LST_DOC_ACTIV { get; set; }
        [Required]
        public int DOC_AS_TKT_SEQ_NO { get; set; }
        [Required]
        public string DOC_STAT { get; set; }
        [Required]
        public decimal LST_CANCEL_DEP_REFUNDED { get; set; }
        [Required]
        public decimal LST_CANCEL_DEP_FORFEIT { get; set; }
        [Required]
        public decimal TOT_DEP_RECEIVED { get; set; }
        [Required]
        public decimal TOT_DEP_APPLIED { get; set; }
        [Required]
        public decimal TOT_DEP_REFUNDED { get; set; }
        [Required]
        public decimal TOT_DEP_FORFEIT { get; set; }
        public DateTime? LST_DOC_EDIT_DT { get; set; }
        public string LST_DOC_EDIT_USR_ID { get; set; }
        public DateTime? LST_DOC_PRT_DT { get; set; }
        public string LST_DOC_PRT_USR_ID { get; set; }
        public DateTime? LST_DOC_PICK_DT { get; set; }
        public string LST_DOC_PICK_USR_ID { get; set; }
        public DateTime? LST_DOC_REL_DT { get; set; }
        public string LST_DOC_REL_USR_ID { get; set; }
        public DateTime? LST_DOC_INVCD_DT { get; set; }
        public string LST_DOC_INVCD_USR_ID { get; set; }
        public DateTime? LST_DOC_PCKVRFD_DT { get; set; }
        public string LST_DOC_PCKVRFD_USR_ID { get; set; }
        [Required]
        public string IS_SUSPENDED { get; set; }
        public DateTime? LST_DOC_SUSPENDED_DT { get; set; }
        public string LST_DOC_SUSPENDED_USR_ID { get; set; }
        public string PREQ_WRKGRP_ID { get; set; }
    }

}
#pragma warning restore 1591

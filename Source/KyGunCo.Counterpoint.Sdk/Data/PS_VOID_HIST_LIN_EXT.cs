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

    public partial class PS_VOID_HIST_LIN_EXT 
    {
        [References(typeof(PS_VOID_HIST_LIN))]
        [Required]
        public DateTime BUS_DAT_EXT { get; set; }
        [References(typeof(PS_VOID_HIST_LIN))]
        [Required]
        public long DOC_ID_EXT { get; set; }
        [References(typeof(PS_VOID_HIST_LIN))]
        [Required]
        public int LIN_SEQ_NO_EXT { get; set; }
        public decimal? USER_BUYBACK_PRC { get; set; }
        public string USER_BUYBACK_TRADEIN_ITEM_NO { get; set; }
        public string USER_BUYBACK_TRADEIN_DESCR { get; set; }
        public string USER_BUYBACK_TRADEIN_SER_NO { get; set; }
        public string USER_BUYBACK_TRADEIN_ITEM_NOTE { get; set; }
        public decimal? USER_TRADEIN_BUYBACK_EXT_COST { get; set; }
        public string USER_BUYBACK_TRADEIN_TRX_TYPE { get; set; }
        public decimal? USER_BUYBACK_TRADEIN_CONSIDERATION { get; set; }
        public string USER_BUYBACK_TRADEIN_RECVR_NO { get; set; }
        public int? USER_BUYBACK_TRADEIN_RECVR_LIN_SEQ_NO { get; set; }
        public string USER_TRADEIN_BUYBACK_PROCESSED { get; set; }
        [Required]
        public string USER_TRADE_IN_PROCESSED { get; set; }
        public string USER_CONSIGNMENT_ITEM_NO { get; set; }
        public string USER_CONSIGNMENT_DESCR { get; set; }
        public string USER_CONSIGNMENT_SER_NO { get; set; }
        public string USER_CONSIGNMENT_ITEM_NOTE { get; set; }
        public decimal? USER_CONSIGNMENT_EXT_COST { get; set; }
        public string USER_CONSIGNMENT_TRX_TYPE { get; set; }
        public decimal? USER_CONSIGNMENT_CONSIDERATION { get; set; }
        public string USER_CONSIGNMENT_RECVR_NO { get; set; }
        public int? USER_CONSIGNMENT_RECVR_LIN_SEQ_NO { get; set; }
        public string USER_CONSIGNMENT_PROCESSED { get; set; }
        public string USER_CONSIGNMENT_PAYOUT_ITEM_NO { get; set; }
        public string USER_CONSIGNMENT_PAYOUT_LOC_ID { get; set; }
        public string USER_CONSIGNMENT_PAYOUT_SER_NO { get; set; }
        public DateTime? USER_CONSIGNMENT_PAYOUT_RECVD_DT { get; set; }
        public int? USER_RENTAL_AMMO_COUNT { get; set; }
        public string USER_INTAKE_TYPE { get; set; }
        public string USER_INTAKE_DOC_NO { get; set; }
    }

}
#pragma warning restore 1591

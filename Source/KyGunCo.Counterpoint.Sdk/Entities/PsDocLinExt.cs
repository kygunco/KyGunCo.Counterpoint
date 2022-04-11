// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DOC_LIN_EXT
    public class PsDocLinExt
    {
        public long DocIdExt { get; set; } // DOC_ID_EXT (Primary key)
        public int LinSeqNoExt { get; set; } // LIN_SEQ_NO_EXT (Primary key)
        public string UserTradeInProcessed { get; set; } = "N"; // USER_TRADE_IN_PROCESSED (length: 1)
        public int? UserRentalAmmoCount { get; set; } // USER_RENTAL_AMMO_COUNT
        public decimal? UserBuybackPrc { get; set; } // USER_BUYBACK_PRC
        public string UserBuybackTradeinItemNo { get; set; } // USER_BUYBACK_TRADEIN_ITEM_NO (length: 20)
        public string UserBuybackTradeinDescr { get; set; } // USER_BUYBACK_TRADEIN_DESCR (length: 30)
        public string UserBuybackTradeinSerNo { get; set; } // USER_BUYBACK_TRADEIN_SER_NO (length: 30)
        public string UserBuybackTradeinItemNote { get; set; } // USER_BUYBACK_TRADEIN_ITEM_NOTE (length: 2147483647)
        public decimal? UserTradeinBuybackExtCost { get; set; } // USER_TRADEIN_BUYBACK_EXT_COST
        public string UserBuybackTradeinTrxType { get; set; } // USER_BUYBACK_TRADEIN_TRX_TYPE (length: 10)
        public decimal? UserBuybackTradeinConsideration { get; set; } // USER_BUYBACK_TRADEIN_CONSIDERATION
        public string UserBuybackTradeinRecvrNo { get; set; } // USER_BUYBACK_TRADEIN_RECVR_NO (length: 15)
        public int? UserBuybackTradeinRecvrLinSeqNo { get; set; } // USER_BUYBACK_TRADEIN_RECVR_LIN_SEQ_NO
        public string UserTradeinBuybackProcessed { get; set; } // USER_TRADEIN_BUYBACK_PROCESSED (length: 1)
        public string UserConsignmentItemNo { get; set; } // USER_CONSIGNMENT_ITEM_NO (length: 20)
        public string UserConsignmentDescr { get; set; } // USER_CONSIGNMENT_DESCR (length: 30)
        public string UserConsignmentSerNo { get; set; } // USER_CONSIGNMENT_SER_NO (length: 30)
        public string UserConsignmentItemNote { get; set; } // USER_CONSIGNMENT_ITEM_NOTE (length: 2147483647)
        public decimal? UserConsignmentExtCost { get; set; } // USER_CONSIGNMENT_EXT_COST
        public string UserConsignmentTrxType { get; set; } // USER_CONSIGNMENT_TRX_TYPE (length: 10)
        public decimal? UserConsignmentConsideration { get; set; } // USER_CONSIGNMENT_CONSIDERATION
        public string UserConsignmentRecvrNo { get; set; } // USER_CONSIGNMENT_RECVR_NO (length: 15)
        public int? UserConsignmentRecvrLinSeqNo { get; set; } // USER_CONSIGNMENT_RECVR_LIN_SEQ_NO
        public string UserConsignmentProcessed { get; set; } // USER_CONSIGNMENT_PROCESSED (length: 1)
        public string UserConsignmentPayoutItemNo { get; set; } // USER_CONSIGNMENT_PAYOUT_ITEM_NO (length: 20)
        public string UserConsignmentPayoutLocId { get; set; } // USER_CONSIGNMENT_PAYOUT_LOC_ID (length: 10)
        public string UserConsignmentPayoutSerNo { get; set; } // USER_CONSIGNMENT_PAYOUT_SER_NO (length: 30)
        public DateTime? UserConsignmentPayoutRecvdDt { get; set; } // USER_CONSIGNMENT_PAYOUT_RECVD_DT
        public string UserIntakeType { get; set; } // USER_INTAKE_TYPE (length: 15)
        public string UserIntakeDocNo { get; set; } // USER_INTAKE_DOC_NO (length: 15)
        public string UserKgcVendNo { get; set; } // USER_KGC_VEND_NO (length: 15)
        public string UserKgcIsDropship { get; set; } // USER_KGC_IS_DROPSHIP (length: 1)
        public string UserKgcOrigItemNo { get; set; } // USER_KGC_ORIG_ITEM_NO (length: 20)

        // Foreign keys

        /// <summary>
        /// Parent PsDocLin pointed by [PS_DOC_LIN_EXT].([DocIdExt], [LinSeqNoExt]) (FK_PS_DOC_LIN_EXT_PS_DOC_LIN)
        /// </summary>
        public virtual PsDocLin PsDocLin { get; set; } // FK_PS_DOC_LIN_EXT_PS_DOC_LIN
    }

}
// </auto-generated>

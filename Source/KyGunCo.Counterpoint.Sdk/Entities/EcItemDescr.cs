// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // EC_ITEM_DESCR
    public class EcItemDescr
    {
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string HtmlDescr { get; set; } // HTML_DESCR (length: 2147483647)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public DateTime? EcommLstChngUtcDt { get; set; } // ECOMM_LST_CHNG_UTC_DT
        public byte? EcommPubStat { get; set; } // ECOMM_PUB_STAT

        // Foreign keys

        /// <summary>
        /// Parent ImItem pointed by [EC_ITEM_DESCR].([ItemNo]) (FK_EC_ITEM_DESCR_IM_ITEM)
        /// </summary>
        public virtual ImItem ImItem { get; set; } // FK_EC_ITEM_DESCR_IM_ITEM
    }

}
// </auto-generated>
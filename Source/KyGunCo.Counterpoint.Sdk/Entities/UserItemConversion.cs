// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_ITEM_CONVERSION
    public class UserItemConversion
    {
        public string DocNo { get; set; } // DOC_NO (Primary key) (length: 15)
        public string FromItemNo { get; set; } // FROM_ITEM_NO (length: 20)
        public string FromLocId { get; set; } // FROM_LOC_ID (length: 10)
        public string ToItemNo { get; set; } // TO_ITEM_NO (length: 20)
        public string ToLocId { get; set; } // TO_LOC_ID (length: 10)
        public decimal? Qty { get; set; } // QTY
        public decimal? Cost { get; set; } // COST
        public string ReasCod { get; set; } // REAS_COD (length: 10)
        public string BatId { get; set; } // BAT_ID (length: 10)
        public string ErrRef { get; set; } // ERR_REF (length: 255)
    }

}
// </auto-generated>

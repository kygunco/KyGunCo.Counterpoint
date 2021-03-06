// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // RS_DEL_PO_VEND_ITEM
    public class RsDelPoVendItem
    {
        public int DelId { get; set; } // DEL_ID (Primary key)
        public byte? RsStat { get; set; } = 1; // RS_STAT
        public DateTime? DeleteDt { get; set; } = DateTime.UtcNow; // DELETE_DT
        public string VendNo { get; set; } // VEND_NO (length: 15)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
    }

}
// </auto-generated>

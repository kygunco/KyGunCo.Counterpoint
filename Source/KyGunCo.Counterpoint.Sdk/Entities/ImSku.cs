// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_SKU
    public class ImSku
    {
        public long SkuId { get; set; } // SKU_ID (Primary key)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string Unit { get; set; } // UNIT (length: 15)
        public string UnitOffset { get; set; } // UNIT_OFFSET (length: 1)
        public string Dim1 { get; set; } // DIM_1 (length: 15)
        public string Dim2 { get; set; } // DIM_2 (length: 15)
        public string Dim3 { get; set; } // DIM_3 (length: 15)

        // Foreign keys

        /// <summary>
        /// Parent ImItem pointed by [IM_SKU].([ItemNo]) (FK_IM_SKU_IM_ITEM)
        /// </summary>
        public virtual ImItem ImItem { get; set; } // FK_IM_SKU_IM_ITEM
    }

}
// </auto-generated>

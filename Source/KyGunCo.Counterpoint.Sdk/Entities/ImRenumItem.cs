// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_RENUM_ITEM
    public class ImRenumItem
    {
        public string RenumGrpId { get; set; } // RENUM_GRP_ID (Primary key) (length: 10)
        public int SeqNo { get; set; } // SEQ_NO (Primary key)
        public string OldItemNo { get; set; } // OLD_ITEM_NO (length: 20)
        public string NewItemNo { get; set; } // NEW_ITEM_NO (length: 20)
        public string ErrRef { get; set; } // ERR_REF (length: 255)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent ImRenumItemGrp pointed by [IM_RENUM_ITEM].([RenumGrpId]) (FK_IM_RENUM_ITEM_IM_RENUM_ITEM_GRP)
        /// </summary>
        public virtual ImRenumItemGrp ImRenumItemGrp { get; set; } // FK_IM_RENUM_ITEM_IM_RENUM_ITEM_GRP
    }

}
// </auto-generated>

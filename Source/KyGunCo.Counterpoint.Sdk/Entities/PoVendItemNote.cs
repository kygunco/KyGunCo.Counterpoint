// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PO_VEND_ITEM_NOTE
    public class PoVendItemNote
    {
        public string VendNo { get; set; } // VEND_NO (Primary key) (length: 15)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string NoteId { get; set; } // NOTE_ID (Primary key) (length: 20)
        public DateTime? NoteDat { get; set; } // NOTE_DAT
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string Note { get; set; } // NOTE (length: 2147483647)
        public string NoteTxt { get; set; } // NOTE_TXT (length: 2147483647)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent PoVendItem pointed by [PO_VEND_ITEM_NOTE].([VendNo], [ItemNo]) (FK_PO_VEND_ITEM_NOTE_PO_VEND_ITEM)
        /// </summary>
        public virtual PoVendItem PoVendItem { get; set; } // FK_PO_VEND_ITEM_NOTE_PO_VEND_ITEM
    }

}
// </auto-generated>
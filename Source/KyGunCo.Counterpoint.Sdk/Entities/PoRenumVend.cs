// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PO_RENUM_VEND
    public class PoRenumVend
    {
        public string RenumGrpId { get; set; } // RENUM_GRP_ID (Primary key) (length: 10)
        public int SeqNo { get; set; } // SEQ_NO (Primary key)
        public string OldVendNo { get; set; } // OLD_VEND_NO (length: 15)
        public string NewVendNo { get; set; } // NEW_VEND_NO (length: 15)
        public string ErrRef { get; set; } // ERR_REF (length: 255)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent PoRenumVendGrp pointed by [PO_RENUM_VEND].([RenumGrpId]) (FK_PO_RENUM_VEND_PO_RENUM_VEND_GRP)
        /// </summary>
        public virtual PoRenumVendGrp PoRenumVendGrp { get; set; } // FK_PO_RENUM_VEND_PO_RENUM_VEND_GRP
    }

}
// </auto-generated>
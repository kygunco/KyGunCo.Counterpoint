// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_SUBCAT_NOTE
    public class ImSubcatNote
    {
        public string SubcatCod { get; set; } // SUBCAT_COD (Primary key) (length: 10)
        public string CategCod { get; set; } // CATEG_COD (Primary key) (length: 10)
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
        /// Parent ImSubcatCod pointed by [IM_SUBCAT_NOTE].([SubcatCod], [CategCod]) (FK_IM_SUBCAT_NOTE_IM_SUBCAT_COD)
        /// </summary>
        public virtual ImSubcatCod ImSubcatCod { get; set; } // FK_IM_SUBCAT_NOTE_IM_SUBCAT_COD
    }

}
// </auto-generated>

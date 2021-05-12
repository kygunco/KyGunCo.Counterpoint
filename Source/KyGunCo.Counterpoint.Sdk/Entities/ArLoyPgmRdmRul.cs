// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // AR_LOY_PGM_RDM_RUL
    public class ArLoyPgmRdmRul
    {
        public string LoyPgmCod { get; set; } // LOY_PGM_COD (Primary key) (length: 10)
        public int RulSeqNo { get; set; } // RUL_SEQ_NO (Primary key)
        public string Descr { get; set; } // DESCR (length: 30)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 30)
        public string ItemFilt { get; set; } // ITEM_FILT (length: 2147483647)
        public string ItemFiltTmplt { get; set; } // ITEM_FILT_TMPLT (length: 2147483647)
        public string ItemFiltText { get; set; } // ITEM_FILT_TEXT (length: 2147483647)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string SalFilt { get; set; } // SAL_FILT (length: 2147483647)
        public string SalFiltTmplt { get; set; } // SAL_FILT_TMPLT (length: 2147483647)
        public string SalFiltText { get; set; } // SAL_FILT_TEXT (length: 2147483647)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent ArLoyPgm pointed by [AR_LOY_PGM_RDM_RUL].([LoyPgmCod]) (FK_AR_LOY_PGM_RDM_RUL_AR_LOY_PGM)
        /// </summary>
        public virtual ArLoyPgm ArLoyPgm { get; set; } // FK_AR_LOY_PGM_RDM_RUL_AR_LOY_PGM
    }

}
// </auto-generated>

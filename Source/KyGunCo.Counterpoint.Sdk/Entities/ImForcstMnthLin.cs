// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_FORCST_MNTH_LIN
    public class ImForcstMnthLin
    {
        public string ForcstCod { get; set; } // FORCST_COD (Primary key) (length: 10)
        public int SeqNo { get; set; } // SEQ_NO
        public int MnthId { get; set; } // MNTH_ID (Primary key)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public string Dim1Upr { get; set; } = "*"; // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } = "*"; // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } = "*"; // DIM_3_UPR (Primary key) (length: 15)
        public decimal ForcQty { get; set; } // FORC_QTY
        public string Commnt { get; set; } // COMMNT (length: 50)
        public string CellDescr { get; set; } // CELL_DESCR (length: 50)

        // Foreign keys

        /// <summary>
        /// Parent ImForcstMnth pointed by [IM_FORCST_MNTH_LIN].([ForcstCod]) (FK_IM_FORCST_MNTH_LIN_IM_FORCST_MNTH)
        /// </summary>
        public virtual ImForcstMnth ImForcstMnth { get; set; } // FK_IM_FORCST_MNTH_LIN_IM_FORCST_MNTH
    }

}
// </auto-generated>

// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_FORCST_WRK
    public class ImForcstWrk
    {
        public string SessId { get; set; } // SESS_ID (Primary key) (length: 40)
        public string ForcstCod { get; set; } // FORCST_COD (Primary key) (length: 10)
        public int SeqNo { get; set; } // SEQ_NO (Primary key)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public int MnthId { get; set; } // MNTH_ID
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string Dim1Upr { get; set; } = "*"; // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } = "*"; // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } = "*"; // DIM_3_UPR (length: 15)
        public decimal? ForcQty { get; set; } // FORC_QTY
        public string CellDescr { get; set; } // CELL_DESCR (length: 50)
    }

}
// </auto-generated>

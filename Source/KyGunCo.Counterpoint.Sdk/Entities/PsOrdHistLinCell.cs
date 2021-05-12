// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_ORD_HIST_LIN_CELL
    public class PsOrdHistLinCell
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int LinSeqNo { get; set; } // LIN_SEQ_NO (Primary key)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public decimal QtySold { get; set; } // QTY_SOLD
        public decimal OrigQty { get; set; } = 0m; // ORIG_QTY
        public decimal QtyShipped { get; set; } = 0m; // QTY_SHIPPED

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) PsOrdHistLinCell pointed by [PS_ORD_HIST_LIN_CELL_EXT].([BUS_DAT_EXT], [DIM_1_UPR_EXT], [DIM_2_UPR_EXT], [DIM_3_UPR_EXT], [DOC_ID_EXT], [LIN_SEQ_NO_EXT]) (FK_PS_ORD_HIST_LIN_CELL_EXT_PS_ORD_HIST_LIN_CELL)
        /// </summary>
        public virtual PsOrdHistLinCellExt PsOrdHistLinCellExt { get; set; } // PS_ORD_HIST_LIN_CELL_EXT.FK_PS_ORD_HIST_LIN_CELL_EXT_PS_ORD_HIST_LIN_CELL

        // Foreign keys

        /// <summary>
        /// Parent PsOrdHistLin pointed by [PS_ORD_HIST_LIN_CELL].([BusDat], [DocId], [LinSeqNo]) (FK_PS_ORD_HIST_LIN_CELL_PS_ORD_HIST_LIN)
        /// </summary>
        public virtual PsOrdHistLin PsOrdHistLin { get; set; } // FK_PS_ORD_HIST_LIN_CELL_PS_ORD_HIST_LIN
    }

}
// </auto-generated>

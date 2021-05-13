// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_QASSEM_TRX_COMP
    public class ImQassemTrxComp
    {
        public string BatId { get; set; } // BAT_ID (Primary key) (length: 10)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public DateTime TrxDat { get; set; } = DateTime.Now; // TRX_DAT (Primary key)
        public int SeqNo { get; set; } = 1; // SEQ_NO (Primary key)
        public int CompSeqNo { get; set; } = 1; // COMP_SEQ_NO (Primary key)
        public string CompItemNo { get; set; } // COMP_ITEM_NO (length: 20)
        public string CompDim1Upr { get; set; } // COMP_DIM_1_UPR (length: 15)
        public string CompDim2Upr { get; set; } // COMP_DIM_2_UPR (length: 15)
        public string CompDim3Upr { get; set; } // COMP_DIM_3_UPR (length: 15)
        public string CompCellDescr { get; set; } // COMP_CELL_DESCR (length: 50)
        public decimal CompUnitQty { get; set; } // COMP_UNIT_QTY
        public decimal CompExtQty { get; set; } // COMP_EXT_QTY
        public decimal CompAddlQty { get; set; } = 0m; // COMP_ADDL_QTY
        public decimal CompTotQty { get; set; } // COMP_TOT_QTY
        public string CompUnit { get; set; } // COMP_UNIT (length: 15)
        public string CompLocId { get; set; } // COMP_LOC_ID (length: 10)
        public string CompSerNo { get; set; } // COMP_SER_NO (length: 30)
        public string Commnt { get; set; } // COMMNT (length: 50)
        public string OrigCompItemNo { get; set; } // ORIG_COMP_ITEM_NO (length: 20)
        public string OrigCompDim1Upr { get; set; } // ORIG_COMP_DIM_1_UPR (length: 15)
        public string OrigCompDim2Upr { get; set; } // ORIG_COMP_DIM_2_UPR (length: 15)
        public string OrigCompDim3Upr { get; set; } // ORIG_COMP_DIM_3_UPR (length: 15)
        public string OrigCompCellDescr { get; set; } // ORIG_COMP_CELL_DESCR (length: 50)
        public decimal OrigCompUnitQty { get; set; } // ORIG_COMP_UNIT_QTY
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent ImQassemTrxPar pointed by [IM_QASSEM_TRX_COMP].([BatId], [ItemNo], [Dim1Upr], [Dim2Upr], [Dim3Upr], [LocId], [TrxDat], [SeqNo]) (FK_IM_QASSEM_TRX_COMP_IM_QASSEM_TRX_PAR)
        /// </summary>
        public virtual ImQassemTrxPar ImQassemTrxPar { get; set; } // FK_IM_QASSEM_TRX_COMP_IM_QASSEM_TRX_PAR
    }

}
// </auto-generated>
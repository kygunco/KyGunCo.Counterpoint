// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // DM_TRX_LOC_ITEM_MNTH
    public class DmTrxLocItemMnth
    {
        public int MnthId { get; set; } // MNTH_ID (Primary key)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public decimal SlsQty { get; set; } // SLS_QTY
        public decimal RtnQty { get; set; } // RTN_QTY
        public decimal AdjQty { get; set; } // ADJ_QTY
        public decimal XferOutQty { get; set; } // XFER_OUT_QTY
        public decimal XferInQty { get; set; } // XFER_IN_QTY
        public decimal QxferOutQty { get; set; } // QXFER_OUT_QTY
        public decimal QxferInQty { get; set; } // QXFER_IN_QTY
        public decimal QassemQty { get; set; } // QASSEM_QTY
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT

        // Foreign keys

        /// <summary>
        /// Parent DmLocHist pointed by [DM_TRX_LOC_ITEM_MNTH].([LocId]) (FK_DM_TRX_LOC_ITEM_MNTH_DM_LOC_HIST)
        /// </summary>
        public virtual DmLocHist DmLocHist { get; set; } // FK_DM_TRX_LOC_ITEM_MNTH_DM_LOC_HIST
    }

}
// </auto-generated>

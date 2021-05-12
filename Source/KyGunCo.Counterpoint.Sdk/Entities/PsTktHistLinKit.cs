// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_TKT_HIST_LIN_KIT
    public class PsTktHistLinKit
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int LinSeqNo { get; set; } // LIN_SEQ_NO (Primary key)
        public decimal KitCompQty { get; set; } // KIT_COMP_QTY
        public string KitCompQtyUnitFlg { get; set; } = "0"; // KIT_COMP_QTY_UNIT_FLG (length: 1)
        public decimal KitCompUpcharge { get; set; } // KIT_COMP_UPCHARGE
        public string KitCompItemNo { get; set; } // KIT_COMP_ITEM_NO (length: 20)
        public string KitCompDim1Upr { get; set; } // KIT_COMP_DIM_1_UPR (length: 15)
        public string KitCompDim2Upr { get; set; } // KIT_COMP_DIM_2_UPR (length: 15)
        public string KitCompDim3Upr { get; set; } // KIT_COMP_DIM_3_UPR (length: 15)
        public string KitSubsTyp { get; set; } = "!"; // KIT_SUBS_TYP (length: 1)
        public string KitPrcAdjTyp { get; set; } = "!"; // KIT_PRC_ADJ_TYP (length: 1)
        public string KitAdjPrcLvl { get; set; } = "1"; // KIT_ADJ_PRC_LVL (length: 1)
        public string RequiredComp { get; private set; } // REQUIRED_COMP (length: 1)

        // Foreign keys

        /// <summary>
        /// Parent PsTktHistLin pointed by [PS_TKT_HIST_LIN_KIT].([BusDat], [DocId], [LinSeqNo]) (FK_PS_TKT_HIST_LIN_KIT_PS_TKT_HIST_LIN)
        /// </summary>
        public virtual PsTktHistLin PsTktHistLin { get; set; } // FK_PS_TKT_HIST_LIN_KIT_PS_TKT_HIST_LIN
    }

}
// </auto-generated>

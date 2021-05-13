// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_ORD_HIST_LIN_PRICE
    public class PsOrdHistLinPrice
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int LinSeqNo { get; set; } // LIN_SEQ_NO (Primary key)
        public short PrcSeqNo { get; set; } = 1; // PRC_SEQ_NO (Primary key)
        public string PrcGrpTyp { get; set; } = "!"; // PRC_GRP_TYP (length: 1)
        public string PrcGrpCod { get; set; } // PRC_GRP_COD (length: 10)
        public string PrcGrpDescr { get; set; } // PRC_GRP_DESCR (length: 30)
        public string PrcRulDescr { get; set; } // PRC_RUL_DESCR (length: 30)
        public int? PrcRulSeqNo { get; set; } // PRC_RUL_SEQ_NO
        public string PrcBrkDescr { get; set; } // PRC_BRK_DESCR (length: 50)
        public string PrcJustStr { get; set; } // PRC_JUST_STR (length: 20)
        public decimal QtyPrcd { get; set; } // QTY_PRCD
        public decimal UnitPrc { get; set; } // UNIT_PRC
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)

        // Foreign keys

        /// <summary>
        /// Parent PsOrdHistLin pointed by [PS_ORD_HIST_LIN_PRICE].([BusDat], [DocId], [LinSeqNo]) (FK_PS_ORD_HIST_LIN_PRICE_PS_ORD_HIST_LIN)
        /// </summary>
        public virtual PsOrdHistLin PsOrdHistLin { get; set; } // FK_PS_ORD_HIST_LIN_PRICE_PS_ORD_HIST_LIN
    }

}
// </auto-generated>
// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_PRC_RPT_WRK
    public class ImPrcRptWrk
    {
        public Guid SessId { get; set; } // SESS_ID (Primary key)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string UnitFlg { get; set; } = "0"; // UNIT_FLG (Primary key) (length: 1)
        public string UnitNam { get; set; } // UNIT_NAM (length: 15)
        public decimal? UnitNumer { get; set; } // UNIT_NUMER
        public decimal? UnitDenom { get; set; } // UNIT_DENOM
        public string StkUnitNam { get; set; } // STK_UNIT_NAM (length: 15)
        public decimal? SalPrc { get; set; } // SAL_PRC
        public decimal? RegPrc { get; set; } // REG_PRC
        public decimal? Prc1 { get; set; } // PRC_1
        public string PrcGrpTyp { get; set; } = "!"; // PRC_GRP_TYP (length: 1)
        public string PrcGrpCod { get; set; } // PRC_GRP_COD (length: 10)
        public string PrcGrpDescr { get; set; } // PRC_GRP_DESCR (length: 30)
        public int? PrcRulSeqNo { get; set; } // PRC_RUL_SEQ_NO
        public string PrcRulDescr { get; set; } // PRC_RUL_DESCR (length: 30)
        public string PrcBrkDescr { get; set; } // PRC_BRK_DESCR (length: 30)
        public string PrcJustStr { get; set; } // PRC_JUST_STR (length: 20)
        public string PrcLocId { get; set; } // PRC_LOC_ID (length: 10)
        public string Dim1Upr { get; set; } = "*"; // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } = "*"; // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } = "*"; // DIM_3_UPR (Primary key) (length: 15)
        public decimal? UnitRetlVal { get; set; } // UNIT_RETL_VAL
    }

}
// </auto-generated>

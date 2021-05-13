// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_PRC_WRK_CELL
    public class ImPrcWrkCell
    {
        public Guid SessId { get; set; } // SESS_ID (Primary key)
        public Guid LinSessId { get; set; } // LIN_SESS_ID (Primary key)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public decimal? OrigQty { get; set; } // ORIG_QTY
        public decimal? RegPrc { get; set; } // REG_PRC
        public decimal? Prc1 { get; set; } // PRC_1
        public decimal? Prc2 { get; set; } // PRC_2
        public decimal? Prc3 { get; set; } // PRC_3
        public decimal? Prc4 { get; set; } // PRC_4
        public decimal? Prc5 { get; set; } // PRC_5
        public decimal? Prc6 { get; set; } // PRC_6
        public decimal? UnitRetlVal { get; set; } // UNIT_RETL_VAL
        public string Prc1Typ { get; set; } = "0"; // PRC_1_TYP (length: 3)
    }

}
// </auto-generated>
// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_GFT_RGSTRY_LIN
    public class PsGftRgstryLin
    {
        public long GftRgstryId { get; set; } = 0; // GFT_RGSTRY_ID (Primary key)
        public int SeqNo { get; set; } // SEQ_NO (Primary key)
        public string GftItemNo { get; set; } // GFT_ITEM_NO (length: 20)
        public string QtyReqstdUnitFlg { get; set; } = "0"; // QTY_REQSTD_UNIT_FLG (length: 1)
        public decimal QtyReqstd { get; set; } // QTY_REQSTD
        public decimal QtyFilled { get; set; } = 0m; // QTY_FILLED
        public decimal QtyFilledDelta { get; set; } = 0m; // QTY_FILLED_DELTA
        public string Dim1Upr { get; set; } = "*"; // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } = "*"; // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } = "*"; // DIM_3_UPR (length: 15)
        public string EcommNxtLinPubMode { get; set; } = "N"; // ECOMM_NXT_LIN_PUB_MODE (length: 1)
        public DateTime? EcommLstPubDt { get; set; } // ECOMM_LST_PUB_DT
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT

        // Foreign keys

        /// <summary>
        /// Parent PsGftRgstryHdr pointed by [PS_GFT_RGSTRY_LIN].([GftRgstryId]) (FK_PS_GFT_RGSTRY_LIN_PS_GFT_RGSTRY_HDR)
        /// </summary>
        public virtual PsGftRgstryHdr PsGftRgstryHdr { get; set; } // FK_PS_GFT_RGSTRY_LIN_PS_GFT_RGSTRY_HDR
    }

}
// </auto-generated>
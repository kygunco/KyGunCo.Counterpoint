// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_XFER_IN_HDR
    public class ImXferInHdr
    {
        public string XferNo { get; set; } // XFER_NO (Primary key) (length: 15)
        public string BatId { get; set; } // BAT_ID (length: 10)
        public string FromLocId { get; set; } // FROM_LOC_ID (length: 10)
        public string ToLocId { get; set; } // TO_LOC_ID (length: 10)
        public DateTime? RecvdDat { get; set; } = DateTime.Now; // RECVD_DAT
        public string RecvdBy { get; set; } // RECVD_BY (length: 10)
        public int? TotSelLins { get; set; } = 0; // TOT_SEL_LINS
        public decimal? TotQtyRecvd { get; set; } = 0m; // TOT_QTY_RECVD
        public decimal XferInMiscAmt { get; set; } = 0m; // XFER_IN_MISC_AMT
        public string Commnt1 { get; set; } // COMMNT_1 (length: 50)
        public string Commnt2 { get; set; } // COMMNT_2 (length: 50)
        public string Commnt3 { get; set; } // COMMNT_3 (length: 50)
        public string Ref { get; set; } // REF (length: 50)
        public string ErrRef { get; set; } // ERR_REF (length: 255)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public decimal? EstRecvdSubTot { get; set; } // EST_RECVD_SUB_TOT
        public decimal? EstRecvdTot { get; set; } // EST_RECVD_TOT
        public int? LinCnt { get; set; } // LIN_CNT

        // Reverse navigation

        /// <summary>
        /// Child ImXferInLins where [IM_XFER_IN_LIN].[XFER_NO] point to this entity (FK_IM_XFER_IN_LIN_IM_XFER_IN_HDR)
        /// </summary>
        public virtual IList<ImXferInLin> ImXferInLins { get; set; } = new List<ImXferInLin>(); // IM_XFER_IN_LIN.FK_IM_XFER_IN_LIN_IM_XFER_IN_HDR

        /// <summary>
        /// Child ImXferInNotes where [IM_XFER_IN_NOTE].[XFER_NO] point to this entity (FK_IM_XFER_IN_NOTE_IM_XFER_IN_HDR)
        /// </summary>
        public virtual IList<ImXferInNote> ImXferInNotes { get; set; } = new List<ImXferInNote>(); // IM_XFER_IN_NOTE.FK_IM_XFER_IN_NOTE_IM_XFER_IN_HDR

        // Foreign keys

        /// <summary>
        /// Parent ImLoc pointed by [IM_XFER_IN_HDR].([ToLocId]) (FK_IM_XFER_IN_HDR_IM_LOC)
        /// </summary>
        public virtual ImLoc ImLoc { get; set; } // FK_IM_XFER_IN_HDR_IM_LOC
    }

}
// </auto-generated>
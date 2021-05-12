// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_XFER_IN_HIST_SER
    public class ImXferInHistSer
    {
        public string XferNo { get; set; } // XFER_NO (Primary key) (length: 15)
        public string EventNo { get; set; } // EVENT_NO (Primary key) (length: 15)
        public int XferInLinSeqNo { get; set; } // XFER_IN_LIN_SEQ_NO (Primary key)
        public string SerNo { get; set; } // SER_NO (Primary key) (length: 30)
        public int? SerSeqNo { get; set; } // SER_SEQ_NO
        public decimal? SerCost { get; set; } // SER_COST
        public decimal? XferInMiscAmt { get; set; } // XFER_IN_MISC_AMT
        public string PromptCod1 { get; set; } // PROMPT_COD_1 (length: 10)
        public string PromptAlpha1 { get; set; } // PROMPT_ALPHA_1 (length: 30)
        public DateTime? PromptDat1 { get; set; } // PROMPT_DAT_1
        public decimal? PromptNo1 { get; set; } // PROMPT_NO_1
        public string Prompt1Str { get; set; } // PROMPT_1_STR (length: 30)
        public string PromptCod2 { get; set; } // PROMPT_COD_2 (length: 10)
        public string PromptAlpha2 { get; set; } // PROMPT_ALPHA_2 (length: 30)
        public DateTime? PromptDat2 { get; set; } // PROMPT_DAT_2
        public decimal? PromptNo2 { get; set; } // PROMPT_NO_2
        public string Prompt2Str { get; set; } // PROMPT_2_STR (length: 30)
        public string PromptCod3 { get; set; } // PROMPT_COD_3 (length: 10)
        public string PromptAlpha3 { get; set; } // PROMPT_ALPHA_3 (length: 30)
        public DateTime? PromptDat3 { get; set; } // PROMPT_DAT_3
        public decimal? PromptNo3 { get; set; } // PROMPT_NO_3
        public string Prompt3Str { get; set; } // PROMPT_3_STR (length: 30)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public decimal? OrigSerCost { get; private set; } // ORIG_SER_COST

        // Foreign keys

        /// <summary>
        /// Parent ImXferInHistLin pointed by [IM_XFER_IN_HIST_SER].([EventNo], [XferNo], [XferInLinSeqNo]) (FK_IM_XFER_IN_HIST_SER_IM_XFER_IN_HIST_LIN)
        /// </summary>
        public virtual ImXferInHistLin ImXferInHistLin { get; set; } // FK_IM_XFER_IN_HIST_SER_IM_XFER_IN_HIST_LIN
    }

}
// </auto-generated>

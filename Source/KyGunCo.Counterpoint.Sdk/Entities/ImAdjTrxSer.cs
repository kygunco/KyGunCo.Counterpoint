// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_ADJ_TRX_SER
    public class ImAdjTrxSer
    {
        public string BatId { get; set; } // BAT_ID (Primary key) (length: 10)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public DateTime TrxDat { get; set; } = DateTime.Now; // TRX_DAT (Primary key)
        public int SeqNo { get; set; } = 1; // SEQ_NO (Primary key)
        public string SerNo { get; set; } // SER_NO (Primary key) (length: 30)
        public int? SerSeqNo { get; set; } // SER_SEQ_NO
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
        public string SerIsNew { get; set; } = "N"; // SER_IS_NEW (length: 1)

        // Foreign keys

        /// <summary>
        /// Parent ImAdjTrx pointed by [IM_ADJ_TRX_SER].([BatId], [ItemNo], [LocId], [TrxDat], [SeqNo]) (FK_IM_ADJ_TRX_SER_IM_ADJ_TRX)
        /// </summary>
        public virtual ImAdjTrx ImAdjTrx { get; set; } // FK_IM_ADJ_TRX_SER_IM_ADJ_TRX
    }

}
// </auto-generated>

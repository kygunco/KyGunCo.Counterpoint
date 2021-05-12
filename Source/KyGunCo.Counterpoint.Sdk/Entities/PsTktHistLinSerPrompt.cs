// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_TKT_HIST_LIN_SER_PROMPT
    public class PsTktHistLinSerPrompt
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int LinSeqNo { get; set; } // LIN_SEQ_NO (Primary key)
        public string SerNo { get; set; } // SER_NO (Primary key) (length: 30)
        public byte PromptSeqNo { get; set; } // PROMPT_SEQ_NO (Primary key)
        public string PromptCod { get; set; } // PROMPT_COD (length: 10)
        public string PromptAlpha { get; set; } // PROMPT_ALPHA (length: 30)
        public DateTime? PromptDat { get; set; } // PROMPT_DAT
        public decimal? PromptNo { get; set; } // PROMPT_NO
        public string PromptStr { get; set; } // PROMPT_STR (length: 30)

        // Foreign keys

        /// <summary>
        /// Parent PsTktHistLinSer pointed by [PS_TKT_HIST_LIN_SER_PROMPT].([BusDat], [DocId], [LinSeqNo], [SerNo]) (FK_PS_TKT_HIST_LIN_SER_PROMPT_PS_TKT_HIST_LIN_SER)
        /// </summary>
        public virtual PsTktHistLinSer PsTktHistLinSer { get; set; } // FK_PS_TKT_HIST_LIN_SER_PROMPT_PS_TKT_HIST_LIN_SER
    }

}
// </auto-generated>

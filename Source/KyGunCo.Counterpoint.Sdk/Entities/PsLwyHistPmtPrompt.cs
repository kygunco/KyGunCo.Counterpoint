// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_LWY_HIST_PMT_PROMPT
    public class PsLwyHistPmtPrompt
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int PmtSeqNo { get; set; } // PMT_SEQ_NO (Primary key)
        public int PromptSeqNo { get; set; } // PROMPT_SEQ_NO (Primary key)
        public string PromptTxt { get; set; } // PROMPT_TXT (length: 50)
        public string PromptVal { get; set; } // PROMPT_VAL (length: 15)

        // Foreign keys

        /// <summary>
        /// Parent PsLwyHistPmt pointed by [PS_LWY_HIST_PMT_PROMPT].([BusDat], [DocId], [PmtSeqNo]) (FK_PS_LWY_HIST_PMT_PROMPT_PS_LWY_HIST_PMT)
        /// </summary>
        public virtual PsLwyHistPmt PsLwyHistPmt { get; set; } // FK_PS_LWY_HIST_PMT_PROMPT_PS_LWY_HIST_PMT
    }

}
// </auto-generated>

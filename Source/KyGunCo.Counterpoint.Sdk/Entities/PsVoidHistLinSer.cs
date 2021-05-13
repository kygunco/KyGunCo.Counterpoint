// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_VOID_HIST_LIN_SER
    public class PsVoidHistLinSer
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int LinSeqNo { get; set; } // LIN_SEQ_NO (Primary key)
        public string SerNo { get; set; } // SER_NO (Primary key) (length: 30)
        public int? SerSeqNo { get; set; } // SER_SEQ_NO
        public decimal? SerCost { get; set; } // SER_COST

        // Reverse navigation

        /// <summary>
        /// Child PsVoidHistLinSerPrompts where [PS_VOID_HIST_LIN_SER_PROMPT].([BUS_DAT], [DOC_ID], [LIN_SEQ_NO], [SER_NO]) point to this entity (FK_PS_VOID_HIST_LIN_SER_PROMPT_PS_VOID_HIST_LIN_SER)
        /// </summary>
        public virtual IList<PsVoidHistLinSerPrompt> PsVoidHistLinSerPrompts { get; set; } = new List<PsVoidHistLinSerPrompt>(); // PS_VOID_HIST_LIN_SER_PROMPT.FK_PS_VOID_HIST_LIN_SER_PROMPT_PS_VOID_HIST_LIN_SER

        /// <summary>
        /// Parent (One-to-One) PsVoidHistLinSer pointed by [PS_VOID_HIST_LIN_SER_EXT].([BUS_DAT_EXT], [DOC_ID_EXT], [LIN_SEQ_NO_EXT], [SER_NO_EXT]) (FK_PS_VOID_HIST_LIN_SER_EXT_PS_VOID_HIST_LIN_SER)
        /// </summary>
        public virtual PsVoidHistLinSerExt PsVoidHistLinSerExt { get; set; } // PS_VOID_HIST_LIN_SER_EXT.FK_PS_VOID_HIST_LIN_SER_EXT_PS_VOID_HIST_LIN_SER

        // Foreign keys

        /// <summary>
        /// Parent PsVoidHistLin pointed by [PS_VOID_HIST_LIN_SER].([BusDat], [DocId], [LinSeqNo]) (FK_PS_VOID_HIST_LIN_SER_PS_VOID_HIST_LIN)
        /// </summary>
        public virtual PsVoidHistLin PsVoidHistLin { get; set; } // FK_PS_VOID_HIST_LIN_SER_PS_VOID_HIST_LIN
    }

}
// </auto-generated>
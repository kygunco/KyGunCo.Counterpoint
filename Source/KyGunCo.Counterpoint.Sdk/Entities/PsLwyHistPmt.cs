// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_LWY_HIST_PMT
    public class PsLwyHistPmt
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int PmtSeqNo { get; set; } // PMT_SEQ_NO (Primary key)
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public string PmtLinTyp { get; set; } // PMT_LIN_TYP (length: 1)
        public string PayCod { get; set; } // PAY_COD (length: 10)
        public string PayCodTyp { get; set; } = "!"; // PAY_COD_TYP (length: 1)
        public string Descr { get; set; } // DESCR (length: 30)
        public DateTime? PayDat { get; set; } // PAY_DAT
        public decimal Amt { get; set; } // AMT
        public decimal HomeCurncyAmt { get; set; } // HOME_CURNCY_AMT
        public decimal ExchLoss { get; set; } // EXCH_LOSS
        public string CurncyCod { get; set; } = "HOME"; // CURNCY_COD (length: 10)
        public decimal ExchRateNumer { get; set; } = 1m; // EXCH_RATE_NUMER
        public decimal ExchRateDenom { get; set; } // EXCH_RATE_DENOM
        public string Swiped { get; set; } = "N"; // SWIPED (length: 1)
        public string CardNo { get; set; } // CARD_NO (length: 30)
        public string CardIsNew { get; set; } = "N"; // CARD_IS_NEW (length: 1)
        public byte[] SigImg { get; set; } // SIG_IMG (length: 2147483647)
        public byte[] SigImgVector { get; set; } // SIG_IMG_VECTOR (length: 2147483647)
        public string SecureEcommTrx { get; set; } = "N"; // SECURE_ECOMM_TRX (length: 1)
        public string EdcAuthCod { get; set; } // EDC_AUTH_COD (length: 10)
        public decimal? SvcBalRemain { get; set; } // SVC_BAL_REMAIN
        public string SvcRefNo { get; set; } // SVC_REF_NO (length: 10)
        public string FinalPmt { get; set; } = "N"; // FINAL_PMT (length: 1)
        public string DepLinCopiedToRelDoc { get; set; } = "N"; // DEP_LIN_COPIED_TO_REL_DOC (length: 1)

        // Reverse navigation

        /// <summary>
        /// Child PsLwyHistPmtPrompts where [PS_LWY_HIST_PMT_PROMPT].([BUS_DAT], [DOC_ID], [PMT_SEQ_NO]) point to this entity (FK_PS_LWY_HIST_PMT_PROMPT_PS_LWY_HIST_PMT)
        /// </summary>
        public virtual IList<PsLwyHistPmtPrompt> PsLwyHistPmtPrompts { get; set; } = new List<PsLwyHistPmtPrompt>(); // PS_LWY_HIST_PMT_PROMPT.FK_PS_LWY_HIST_PMT_PROMPT_PS_LWY_HIST_PMT

        /// <summary>
        /// Parent (One-to-One) PsLwyHistPmt pointed by [PS_LWY_HIST_PMT_CHK].([BUS_DAT], [DOC_ID], [PMT_SEQ_NO]) (FK_PS_LWY_HIST_PMT_CHK_PS_LWY_HIST_PMT)
        /// </summary>
        public virtual PsLwyHistPmtChk PsLwyHistPmtChk { get; set; } // PS_LWY_HIST_PMT_CHK.FK_PS_LWY_HIST_PMT_CHK_PS_LWY_HIST_PMT

        /// <summary>
        /// Parent (One-to-One) PsLwyHistPmt pointed by [PS_LWY_HIST_PMT_CR_CARD].([BUS_DAT], [DOC_ID], [PMT_SEQ_NO]) (FK_PS_LWY_HIST_PMT_CR_CARD_PS_LWY_HIST_PMT)
        /// </summary>
        public virtual PsLwyHistPmtCrCard PsLwyHistPmtCrCard { get; set; } // PS_LWY_HIST_PMT_CR_CARD.FK_PS_LWY_HIST_PMT_CR_CARD_PS_LWY_HIST_PMT

        /// <summary>
        /// Parent (One-to-One) PsLwyHistPmt pointed by [PS_LWY_HIST_PMT_EXT].([BUS_DAT_EXT], [DOC_ID_EXT], [PMT_SEQ_NO_EXT]) (FK_PS_LWY_HIST_PMT_EXT_PS_LWY_HIST_PMT)
        /// </summary>
        public virtual PsLwyHistPmtExt PsLwyHistPmtExt { get; set; } // PS_LWY_HIST_PMT_EXT.FK_PS_LWY_HIST_PMT_EXT_PS_LWY_HIST_PMT

        /// <summary>
        /// Parent (One-to-One) PsLwyHistPmt pointed by [PS_LWY_HIST_PMT_RCPT].([BUS_DAT], [DOC_ID], [PMT_SEQ_NO]) (FK_PS_LWY_HIST_PMT_RCPT_PS_LWY_HIST_PMT)
        /// </summary>
        public virtual PsLwyHistPmtRcpt PsLwyHistPmtRcpt { get; set; } // PS_LWY_HIST_PMT_RCPT.FK_PS_LWY_HIST_PMT_RCPT_PS_LWY_HIST_PMT

        // Foreign keys

        /// <summary>
        /// Parent PsLwyHist pointed by [PS_LWY_HIST_PMT].([BusDat], [DocId]) (FK_PS_LWY_HIST_PMT_PS_LWY_HIST)
        /// </summary>
        public virtual PsLwyHist PsLwyHist { get; set; } // FK_PS_LWY_HIST_PMT_PS_LWY_HIST
    }

}
// </auto-generated>

// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_LWY_HIST
    public class PsLwyHist
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public Guid DocGuid { get; set; } // DOC_GUID
        public DateTime? TktDt { get; set; } // TKT_DT
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string SlsRep { get; set; } // SLS_REP (length: 10)
        public string StkLocId { get; set; } // STK_LOC_ID (length: 10)
        public string PrcLocId { get; set; } // PRC_LOC_ID (length: 10)
        public string PftCtr { get; set; } // PFT_CTR (length: 20)
        public string CustNo { get; set; } // CUST_NO (length: 15)
        public byte? BillToContactId { get; set; } // BILL_TO_CONTACT_ID
        public byte? ShipToContactId { get; set; } // SHIP_TO_CONTACT_ID
        public string TermsCod { get; set; } // TERMS_COD (length: 10)
        public string ShipViaCod { get; set; } // SHIP_VIA_COD (length: 10)
        public string ShipZoneCod { get; set; } // SHIP_ZONE_COD (length: 30)
        public DateTime? ShipDat { get; set; } // SHIP_DAT
        public string NormTaxCod { get; set; } // NORM_TAX_COD (length: 10)
        public string TaxCod { get; set; } // TAX_COD (length: 10)
        public string TaxExemptNo { get; set; } // TAX_EXEMPT_NO (length: 30)
        public string TaxOvrdReas { get; set; } // TAX_OVRD_REAS (length: 10)
        public string CustPoNo { get; set; } // CUST_PO_NO (length: 20)
        public string LstFrmGrpPrtd { get; set; } // LST_FRM_GRP_PRTD (length: 10)
        public string LstFrmPrtd { get; set; } // LST_FRM_PRTD (length: 100)
        public int? TimesPrtd { get; set; } = 0; // TIMES_PRTD
        public string HasTaxOvrd { get; set; } = "!"; // HAS_TAX_OVRD (length: 1)
        public int TaxOvrdLins { get; set; } = 0; // TAX_OVRD_LINS
        public int? Lins { get; set; } = 0; // LINS
        public decimal SubTot { get; set; } = 0m; // SUB_TOT
        public decimal? TotExtCost { get; set; } // TOT_EXT_COST
        public decimal TotWeight { get; set; } // TOT_WEIGHT
        public decimal TotCube { get; set; } // TOT_CUBE
        public decimal TotMisc { get; set; } = 0m; // TOT_MISC
        public decimal NormTaxAmt { get; set; } = 0m; // NORM_TAX_AMT
        public decimal TaxAmt { get; set; } // TAX_AMT
        public decimal TaxAmtShipped { get; set; } // TAX_AMT_SHIPPED
        public decimal Tot { get; set; } = 0m; // TOT
        public decimal InitialMinDue { get; set; } // INITIAL_MIN_DUE
        public decimal TotTnd { get; set; } = 0m; // TOT_TND
        public decimal TotChng { get; set; } = 0m; // TOT_CHNG
        public decimal AmtDue { get; set; } = 0m; // AMT_DUE
        public string Ref { get; set; } // REF (length: 50)
        public decimal TotHdrDisc { get; set; } // TOT_HDR_DISC
        public decimal TotLinDisc { get; set; } // TOT_LIN_DISC
        public bool IsOffline { get; set; } = false; // IS_OFFLINE

        // Reverse navigation

        /// <summary>
        /// Child PsLwyHistAuditLogs where [PS_LWY_HIST_AUDIT_LOG].([BUS_DAT], [DOC_ID]) point to this entity (FK_PS_LWY_HIST_AUDIT_LOG_PS_LWY_HIST)
        /// </summary>
        public virtual IList<PsLwyHistAuditLog> PsLwyHistAuditLogs { get; set; } = new List<PsLwyHistAuditLog>(); // PS_LWY_HIST_AUDIT_LOG.FK_PS_LWY_HIST_AUDIT_LOG_PS_LWY_HIST

        /// <summary>
        /// Child PsLwyHistContacts where [PS_LWY_HIST_CONTACT].([BUS_DAT], [DOC_ID]) point to this entity (FK_PS_LWY_HIST_CONTACT_PS_LWY_HIST)
        /// </summary>
        public virtual IList<PsLwyHistContact> PsLwyHistContacts { get; set; } = new List<PsLwyHistContact>(); // PS_LWY_HIST_CONTACT.FK_PS_LWY_HIST_CONTACT_PS_LWY_HIST

        /// <summary>
        /// Child PsLwyHistDiscs where [PS_LWY_HIST_DISC].([BUS_DAT], [DOC_ID]) point to this entity (FK_PS_LWY_HIST_DISC_PS_LWY_HIST)
        /// </summary>
        public virtual IList<PsLwyHistDisc> PsLwyHistDiscs { get; set; } = new List<PsLwyHistDisc>(); // PS_LWY_HIST_DISC.FK_PS_LWY_HIST_DISC_PS_LWY_HIST

        /// <summary>
        /// Child PsLwyHistLins where [PS_LWY_HIST_LIN].([BUS_DAT], [DOC_ID]) point to this entity (FK_PS_LWY_HIST_LIN_PS_LWY_HIST)
        /// </summary>
        public virtual IList<PsLwyHistLin> PsLwyHistLins { get; set; } = new List<PsLwyHistLin>(); // PS_LWY_HIST_LIN.FK_PS_LWY_HIST_LIN_PS_LWY_HIST

        /// <summary>
        /// Child PsLwyHistMiscChrgs where [PS_LWY_HIST_MISC_CHRG].([BUS_DAT], [DOC_ID]) point to this entity (FK_PS_LWY_HIST_MISC_CHRG_PS_LWY_HIST)
        /// </summary>
        public virtual IList<PsLwyHistMiscChrg> PsLwyHistMiscChrgs { get; set; } = new List<PsLwyHistMiscChrg>(); // PS_LWY_HIST_MISC_CHRG.FK_PS_LWY_HIST_MISC_CHRG_PS_LWY_HIST

        /// <summary>
        /// Child PsLwyHistNotes where [PS_LWY_HIST_NOTE].([BUS_DAT], [DOC_ID]) point to this entity (FK_PS_LWY_HIST_NOTE_PS_LWY_HIST)
        /// </summary>
        public virtual IList<PsLwyHistNote> PsLwyHistNotes { get; set; } = new List<PsLwyHistNote>(); // PS_LWY_HIST_NOTE.FK_PS_LWY_HIST_NOTE_PS_LWY_HIST

        /// <summary>
        /// Child PsLwyHistPkgTrkNoes where [PS_LWY_HIST_PKG_TRK_NO].([BUS_DAT], [DOC_ID]) point to this entity (FK_PS_LWY_HIST_PKG_TRK_NO_PS_LWY_HIST)
        /// </summary>
        public virtual IList<PsLwyHistPkgTrkNo> PsLwyHistPkgTrkNoes { get; set; } = new List<PsLwyHistPkgTrkNo>(); // PS_LWY_HIST_PKG_TRK_NO.FK_PS_LWY_HIST_PKG_TRK_NO_PS_LWY_HIST

        /// <summary>
        /// Child PsLwyHistPmts where [PS_LWY_HIST_PMT].([BUS_DAT], [DOC_ID]) point to this entity (FK_PS_LWY_HIST_PMT_PS_LWY_HIST)
        /// </summary>
        public virtual IList<PsLwyHistPmt> PsLwyHistPmts { get; set; } = new List<PsLwyHistPmt>(); // PS_LWY_HIST_PMT.FK_PS_LWY_HIST_PMT_PS_LWY_HIST

        /// <summary>
        /// Child PsLwyHistTaxes where [PS_LWY_HIST_TAX].([BUS_DAT], [DOC_ID]) point to this entity (FK_PS_LWY_HIST_TAX_PS_LWY_HIST)
        /// </summary>
        public virtual IList<PsLwyHistTax> PsLwyHistTaxes { get; set; } = new List<PsLwyHistTax>(); // PS_LWY_HIST_TAX.FK_PS_LWY_HIST_TAX_PS_LWY_HIST

        /// <summary>
        /// Parent (One-to-One) PsLwyHist pointed by [PS_LWY_HIST_DOC_STAT].([BUS_DAT], [DOC_ID]) (FK_PS_LWY_HIST_DOC_STAT_PS_LWY_HIST)
        /// </summary>
        public virtual PsLwyHistDocStat PsLwyHistDocStat { get; set; } // PS_LWY_HIST_DOC_STAT.FK_PS_LWY_HIST_DOC_STAT_PS_LWY_HIST

        /// <summary>
        /// Parent (One-to-One) PsLwyHist pointed by [PS_LWY_HIST_EXT].([BUS_DAT_EXT], [DOC_ID_EXT]) (FK_PS_LWY_HIST_EXT_PS_LWY_HIST)
        /// </summary>
        public virtual PsLwyHistExt PsLwyHistExt { get; set; } // PS_LWY_HIST_EXT.FK_PS_LWY_HIST_EXT_PS_LWY_HIST

        /// <summary>
        /// Parent (One-to-One) PsLwyHist pointed by [PS_LWY_HIST_HOLD_QUOT].([BUS_DAT], [DOC_ID]) (FK_PS_LWY_HIST_HOLD_QUOT_PS_LWY_HIST)
        /// </summary>
        public virtual PsLwyHistHoldQuot PsLwyHistHoldQuot { get; set; } // PS_LWY_HIST_HOLD_QUOT.FK_PS_LWY_HIST_HOLD_QUOT_PS_LWY_HIST

        /// <summary>
        /// Parent (One-to-One) PsLwyHist pointed by [PS_LWY_HIST_PROF].([BUS_DAT], [DOC_ID]) (FK_PS_LWY_HIST_PROF_PS_LWY_HIST)
        /// </summary>
        public virtual PsLwyHistProf PsLwyHistProf { get; set; } // PS_LWY_HIST_PROF.FK_PS_LWY_HIST_PROF_PS_LWY_HIST
    }

}
// </auto-generated>

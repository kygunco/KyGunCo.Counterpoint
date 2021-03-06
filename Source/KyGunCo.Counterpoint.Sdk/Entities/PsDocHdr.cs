// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DOC_HDR
    public class PsDocHdr
    {
        public long DocId { get; set; } // DOC_ID (Primary key)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public string DocTyp { get; set; } = "T"; // DOC_TYP (length: 1)
        public int? SalLins { get; set; } = 0; // SAL_LINS
        public int OrdLins { get; set; } = 0; // ORD_LINS
        public decimal SalLinTot { get; set; } = 0m; // SAL_LIN_TOT
        public int GfcLins { get; set; } = 0; // GFC_LINS
        public int BoLins { get; set; } = 0; // BO_LINS
        public int SoLins { get; set; } = 0; // SO_LINS
        public string DrwId { get; set; } // DRW_ID (length: 10)
        public long? DrwSessionId { get; set; } // DRW_SESSION_ID
        public string CustNo { get; set; } // CUST_NO (length: 15)
        public int? RetLins { get; set; } = 0; // RET_LINS
        public string ShipViaCod { get; set; } // SHIP_VIA_COD (length: 10)
        public decimal RetLinTot { get; set; } = 0m; // RET_LIN_TOT
        public string ShipZoneCod { get; set; } // SHIP_ZONE_COD (length: 30)
        public string TaxCod { get; set; } // TAX_COD (length: 10)
        public string TermsCod { get; set; } // TERMS_COD (length: 10)
        public string CustPoNo { get; set; } // CUST_PO_NO (length: 20)
        public string TktTyp { get; set; } = "T"; // TKT_TYP (length: 1)
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string SlsRep { get; set; } // SLS_REP (length: 10)
        public string StkLocId { get; set; } // STK_LOC_ID (length: 10)
        public string PrcLocId { get; set; } // PRC_LOC_ID (length: 10)
        public int SvcLins { get; set; } = 0; // SVC_LINS
        public string PftCtr { get; set; } // PFT_CTR (length: 20)
        public string VoidUsrId { get; set; } // VOID_USR_ID (length: 10)
        public string VoidReas { get; set; } // VOID_REAS (length: 10)
        public string TaxExemptNo { get; set; } // TAX_EXEMPT_NO (length: 30)
        public string TaxOvrdReas { get; set; } // TAX_OVRD_REAS (length: 10)
        public Guid DocGuid { get; set; } // DOC_GUID
        public byte? BillToContactId { get; set; } // BILL_TO_CONTACT_ID
        public byte? ShipToContactId { get; set; } // SHIP_TO_CONTACT_ID
        public string ReqReprice { get; set; } = "N"; // REQ_REPRICE (length: 1)
        public DateTime? ShipDat { get; set; } // SHIP_DAT
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public string IsDocCommitted { get; set; } = "N"; // IS_DOC_COMMITTED (length: 1)
        public string LstFrmGrpPrtd { get; set; } // LST_FRM_GRP_PRTD (length: 10)
        public string LstFrmPrtd { get; set; } // LST_FRM_PRTD (length: 100)
        public decimal? FoodStmpAmt { get; set; } = 0m; // FOOD_STMP_AMT
        public int FoodStmpLins { get; set; } = 0; // FOOD_STMP_LINS
        public decimal? FoodStmpTaxAmt { get; set; } = 0m; // FOOD_STMP_TAX_AMT
        public int? TimesPrtd { get; set; } = 0; // TIMES_PRTD
        public string ErrRef { get; set; } // ERR_REF (length: 255)
        public DateTime? TktDt { get; set; } // TKT_DT
        public string IsRelTkt { get; set; } = "N"; // IS_REL_TKT (length: 1)
        public decimal? FoodStmpNormTaxAmt { get; set; } = 0m; // FOOD_STMP_NORM_TAX_AMT
        public string LoyPgmCod { get; set; } // LOY_PGM_COD (length: 10)
        public string NormTaxCod { get; set; } // NORM_TAX_COD (length: 10)
        public string DataUpgradeStat { get; set; } // DATA_UPGRADE_STAT (length: 1)
        public string Ref { get; set; } // REF (length: 50)
        public string HasEntdLins { get; set; } = "Y"; // HAS_ENTD_LINS (length: 1)
        public string HasPckdLins { get; set; } = "N"; // HAS_PCKD_LINS (length: 1)
        public string HasPckvrfdLins { get; set; } = "N"; // HAS_PCKVRFD_LINS (length: 1)
        public string HasInvcdLins { get; set; } = "N"; // HAS_INVCD_LINS (length: 1)
        public string HasRlsdLins { get; set; } = "N"; // HAS_RLSD_LINS (length: 1)
        public int ToRelLins { get; set; } = 0; // TO_REL_LINS
        public int ToLeaveLins { get; set; } = 0; // TO_LEAVE_LINS
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public bool IsOffline { get; set; } = false; // IS_OFFLINE
        public byte RsStat { get; set; } = 1; // RS_STAT
        public int DsLins { get; set; } = 0; // DS_LINS
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT

        // Reverse navigation

        /// <summary>
        /// Child PsDocAuditLogs where [PS_DOC_AUDIT_LOG].[DOC_ID] point to this entity (FK_PS_DOC_AUDIT_LOG_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocAuditLog> PsDocAuditLogs { get; set; } = new List<PsDocAuditLog>(); // PS_DOC_AUDIT_LOG.FK_PS_DOC_AUDIT_LOG_PS_DOC_HDR

        /// <summary>
        /// Child PsDocContacts where [PS_DOC_CONTACT].[DOC_ID] point to this entity (FK_PS_DOC_CONTACT_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocContact> PsDocContacts { get; set; } = new List<PsDocContact>(); // PS_DOC_CONTACT.FK_PS_DOC_CONTACT_PS_DOC_HDR

        /// <summary>
        /// Child PsDocDiscs where [PS_DOC_DISC].[DOC_ID] point to this entity (FK_PS_DOC_DISC_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocDisc> PsDocDiscs { get; set; } = new List<PsDocDisc>(); // PS_DOC_DISC.FK_PS_DOC_DISC_PS_DOC_HDR

        /// <summary>
        /// Child PsDocGfcs where [PS_DOC_GFC].[DOC_ID] point to this entity (FK_PS_DOC_GFC_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocGfc> PsDocGfcs { get; set; } = new List<PsDocGfc>(); // PS_DOC_GFC.FK_PS_DOC_GFC_PS_DOC_HDR

        /// <summary>
        /// Child PsDocHdrOrigDocs where [PS_DOC_HDR_ORIG_DOC].[DOC_ID] point to this entity (FK_PS_DOC_HDR_ORIG_DOC_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocHdrOrigDoc> PsDocHdrOrigDocs { get; set; } = new List<PsDocHdrOrigDoc>(); // PS_DOC_HDR_ORIG_DOC.FK_PS_DOC_HDR_ORIG_DOC_PS_DOC_HDR

        /// <summary>
        /// Child PsDocHdrTots where [PS_DOC_HDR_TOT].[DOC_ID] point to this entity (FK_PS_DOC_HDR_TOT_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocHdrTot> PsDocHdrTots { get; set; } = new List<PsDocHdrTot>(); // PS_DOC_HDR_TOT.FK_PS_DOC_HDR_TOT_PS_DOC_HDR

        /// <summary>
        /// Child PsDocLins where [PS_DOC_LIN].[DOC_ID] point to this entity (FK_PS_DOC_LIN_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocLin> PsDocLins { get; set; } = new List<PsDocLin>(); // PS_DOC_LIN.FK_PS_DOC_LIN_PS_DOC_HDR

        /// <summary>
        /// Child PsDocNotes where [PS_DOC_NOTE].[DOC_ID] point to this entity (FK_PS_DOC_NOTE_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocNote> PsDocNotes { get; set; } = new List<PsDocNote>(); // PS_DOC_NOTE.FK_PS_DOC_NOTE_PS_DOC_HDR

        /// <summary>
        /// Child PsDocPkgTrkNoes where [PS_DOC_PKG_TRK_NO].[DOC_ID] point to this entity (FK_PS_DOC_PKG_TRK_NO_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocPkgTrkNo> PsDocPkgTrkNoes { get; set; } = new List<PsDocPkgTrkNo>(); // PS_DOC_PKG_TRK_NO.FK_PS_DOC_PKG_TRK_NO_PS_DOC_HDR

        /// <summary>
        /// Child PsDocPmts where [PS_DOC_PMT].[DOC_ID] point to this entity (FK_PS_DOC_PMT_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocPmt> PsDocPmts { get; set; } = new List<PsDocPmt>(); // PS_DOC_PMT.FK_PS_DOC_PMT_PS_DOC_HDR

        /// <summary>
        /// Child PsDocSvcs where [PS_DOC_SVC].[DOC_ID] point to this entity (FK_PS_DOC_SVC_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocSvc> PsDocSvcs { get; set; } = new List<PsDocSvc>(); // PS_DOC_SVC.FK_PS_DOC_SVC_PS_DOC_HDR

        /// <summary>
        /// Child PsDocTaxes where [PS_DOC_TAX].[DOC_ID] point to this entity (FK_PS_DOC_TAX_PS_DOC_HDR)
        /// </summary>
        public virtual IList<PsDocTax> PsDocTaxes { get; set; } = new List<PsDocTax>(); // PS_DOC_TAX.FK_PS_DOC_TAX_PS_DOC_HDR

        /// <summary>
        /// Parent (One-to-One) PsDocHdr pointed by [PS_DOC_HDR_DOC_STAT].[DOC_ID] (FK_PS_DOC_HDR_DOC_STAT_PS_DOC_HDR)
        /// </summary>
        public virtual PsDocHdrDocStat PsDocHdrDocStat { get; set; } // PS_DOC_HDR_DOC_STAT.FK_PS_DOC_HDR_DOC_STAT_PS_DOC_HDR

        /// <summary>
        /// Parent (One-to-One) PsDocHdr pointed by [PS_DOC_HDR_EC].[DOC_ID] (FK_PS_DOC_HDR_EC_PS_DOC_HDR)
        /// </summary>
        public virtual PsDocHdrEc PsDocHdrEc { get; set; } // PS_DOC_HDR_EC.FK_PS_DOC_HDR_EC_PS_DOC_HDR

        /// <summary>
        /// Parent (One-to-One) PsDocHdr pointed by [PS_DOC_HDR_EXT].[DOC_ID_EXT] (FK_PS_DOC_HDR_EXT_PS_DOC_HDR)
        /// </summary>
        public virtual PsDocHdrExt PsDocHdrExt { get; set; } // PS_DOC_HDR_EXT.FK_PS_DOC_HDR_EXT_PS_DOC_HDR

        /// <summary>
        /// Parent (One-to-One) PsDocHdr pointed by [PS_DOC_HDR_HOLD_QUOT].[DOC_ID] (FK_PS_DOC_HDR_HOLD_QUOT_PS_DOC_HDR)
        /// </summary>
        public virtual PsDocHdrHoldQuot PsDocHdrHoldQuot { get; set; } // PS_DOC_HDR_HOLD_QUOT.FK_PS_DOC_HDR_HOLD_QUOT_PS_DOC_HDR

        /// <summary>
        /// Parent (One-to-One) PsDocHdr pointed by [PS_DOC_HDR_LOY_PGM].[DOC_ID] (FK_PS_DOC_HDR_LOY_PGM_PS_DOC_HDR)
        /// </summary>
        public virtual PsDocHdrLoyPgm PsDocHdrLoyPgm { get; set; } // PS_DOC_HDR_LOY_PGM.FK_PS_DOC_HDR_LOY_PGM_PS_DOC_HDR

        /// <summary>
        /// Parent (One-to-One) PsDocHdr pointed by [PS_DOC_HDR_PAY_IOA].[DOC_ID] (FK_PS_DOC_HDR_PAY_IOA_PS_DOC_HDR)
        /// </summary>
        public virtual PsDocHdrPayIoa PsDocHdrPayIoa { get; set; } // PS_DOC_HDR_PAY_IOA.FK_PS_DOC_HDR_PAY_IOA_PS_DOC_HDR

        /// <summary>
        /// Parent (One-to-One) PsDocHdr pointed by [PS_DOC_HDR_PROF].[DOC_ID] (FK_PS_DOC_HDR_PROF_PS_DOC_HDR)
        /// </summary>
        public virtual PsDocHdrProf PsDocHdrProf { get; set; } // PS_DOC_HDR_PROF.FK_PS_DOC_HDR_PROF_PS_DOC_HDR

        // Foreign keys

        /// <summary>
        /// Parent PsSta pointed by [PS_DOC_HDR].([StrId], [StaId]) (FK_PS_DOC_HDR_PS_STA)
        /// </summary>
        public virtual PsSta PsSta { get; set; } // FK_PS_DOC_HDR_PS_STA
    }

}
// </auto-generated>

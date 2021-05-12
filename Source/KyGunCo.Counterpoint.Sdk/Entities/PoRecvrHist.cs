// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PO_RECVR_HIST
    public class PoRecvrHist
    {
        public string RecvrNo { get; set; } // RECVR_NO (Primary key) (length: 15)
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string BatId { get; set; } // BAT_ID (length: 10)
        public string VendNo { get; set; } // VEND_NO (length: 15)
        public string VendFstNam { get; set; } // VEND_FST_NAM (length: 15)
        public string VendFstNamUpr { get; set; } // VEND_FST_NAM_UPR (length: 15)
        public string VendLstNam { get; set; } // VEND_LST_NAM (length: 25)
        public string VendLstNamUpr { get; set; } // VEND_LST_NAM_UPR (length: 25)
        public string VendNam { get; set; } // VEND_NAM (length: 40)
        public string VendNamUpr { get; set; } // VEND_NAM_UPR (length: 40)
        public decimal RecvrMiscAmt1 { get; set; } = 0m; // RECVR_MISC_AMT_1
        public decimal RecvrMiscAmt2 { get; set; } = 0m; // RECVR_MISC_AMT_2
        public decimal RecvrMiscAmt3 { get; set; } = 0m; // RECVR_MISC_AMT_3
        public decimal RecvrMiscAmt4 { get; set; } = 0m; // RECVR_MISC_AMT_4
        public decimal RecvrMiscAmt5 { get; set; } = 0m; // RECVR_MISC_AMT_5
        public decimal RecvrTotMisc { get; set; } = 0m; // RECVR_TOT_MISC
        public decimal RecvrSubTot { get; set; } = 0m; // RECVR_SUB_TOT
        public decimal RecvrTot { get; set; } = 0m; // RECVR_TOT
        public DateTime RecvrDat { get; set; } = DateTime.Now; // RECVR_DAT
        public string RecvrShipViaCod { get; set; } // RECVR_SHIP_VIA_COD (length: 10)
        public string RecvrLocId { get; set; } // RECVR_LOC_ID (length: 10)
        public int TotSelLins { get; set; } = 0; // TOT_SEL_LINS
        public decimal TotQtyToRecv { get; set; } = 0m; // TOT_QTY_TO_RECV
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string VchrStat { get; set; } = "!"; // VCHR_STAT (length: 1)
        public string Ref { get; set; } // REF (length: 50)
        public string Commnt1 { get; set; } // COMMNT_1 (length: 50)
        public string Commnt2 { get; set; } // COMMNT_2 (length: 50)
        public string Commnt3 { get; set; } // COMMNT_3 (length: 50)
        public string IsAlloc { get; set; } = "N"; // IS_ALLOC (length: 1)
        public string AllocLocGrp { get; set; } // ALLOC_LOC_GRP (length: 10)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string XfersCreatd { get; set; } = "N"; // XFERS_CREATD (length: 1)
        public int AdjCnt { get; set; } = 0; // ADJ_CNT
        public string LstAdjEventNo { get; set; } // LST_ADJ_EVENT_NO (length: 15)
        public DateTime? LstAdjDat { get; set; } // LST_ADJ_DAT
        public decimal AdjMiscAmt1 { get; set; } = 0m; // ADJ_MISC_AMT_1
        public decimal AdjMiscAmt2 { get; set; } = 0m; // ADJ_MISC_AMT_2
        public decimal AdjMiscAmt3 { get; set; } = 0m; // ADJ_MISC_AMT_3
        public decimal AdjMiscAmt4 { get; set; } = 0m; // ADJ_MISC_AMT_4
        public decimal AdjMiscAmt5 { get; set; } = 0m; // ADJ_MISC_AMT_5
        public decimal AdjTotMisc { get; set; } = 0m; // ADJ_TOT_MISC
        public decimal AdjSubTot { get; set; } = 0m; // ADJ_SUB_TOT
        public decimal AdjTot { get; set; } = 0m; // ADJ_TOT
        public decimal? RecvrTotWeight { get; set; } // RECVR_TOT_WEIGHT
        public decimal? RecvrTotCube { get; set; } // RECVR_TOT_CUBE
        public decimal? TotQtyRecvdInStkUnits { get; set; } // TOT_QTY_RECVD_IN_STK_UNITS
        public string AllocMisc1By { get; set; } = "!"; // ALLOC_MISC_1_BY (length: 1)
        public string AllocMisc2By { get; set; } = "!"; // ALLOC_MISC_2_BY (length: 1)
        public string AllocMisc3By { get; set; } = "!"; // ALLOC_MISC_3_BY (length: 1)
        public string AllocMisc4By { get; set; } = "!"; // ALLOC_MISC_4_BY (length: 1)
        public string AllocMisc5By { get; set; } = "!"; // ALLOC_MISC_5_BY (length: 1)
        public string IsDropshipRecvr { get; set; } = "N"; // IS_DROPSHIP_RECVR (length: 1)
        public Guid DocGuid { get; set; } // DOC_GUID
        public string CurncyCod { get; set; } = "HOME"; // CURNCY_COD (length: 10)
        public string Misc1CurncyCod { get; set; } = "HOME"; // MISC_1_CURNCY_COD (length: 10)
        public string Misc2CurncyCod { get; set; } = "HOME"; // MISC_2_CURNCY_COD (length: 10)
        public string Misc3CurncyCod { get; set; } = "HOME"; // MISC_3_CURNCY_COD (length: 10)
        public string Misc4CurncyCod { get; set; } = "HOME"; // MISC_4_CURNCY_COD (length: 10)
        public string Misc5CurncyCod { get; set; } = "HOME"; // MISC_5_CURNCY_COD (length: 10)
        public decimal RecvrExchRateNumer { get; set; } = 1m; // RECVR_EXCH_RATE_NUMER
        public decimal RecvrExchRateDenom { get; set; } = 1m; // RECVR_EXCH_RATE_DENOM
        public decimal RecvrMisc1ExchRateNumer { get; set; } = 1m; // RECVR_MISC_1_EXCH_RATE_NUMER
        public decimal RecvrMisc1ExchRateDenom { get; set; } = 1m; // RECVR_MISC_1_EXCH_RATE_DENOM
        public decimal RecvrMisc2ExchRateNumer { get; set; } = 1m; // RECVR_MISC_2_EXCH_RATE_NUMER
        public decimal RecvrMisc2ExchRateDenom { get; set; } = 1m; // RECVR_MISC_2_EXCH_RATE_DENOM
        public decimal RecvrMisc3ExchRateNumer { get; set; } = 1m; // RECVR_MISC_3_EXCH_RATE_NUMER
        public decimal RecvrMisc3ExchRateDenom { get; set; } = 1m; // RECVR_MISC_3_EXCH_RATE_DENOM
        public decimal RecvrMisc4ExchRateNumer { get; set; } = 1m; // RECVR_MISC_4_EXCH_RATE_NUMER
        public decimal RecvrMisc4ExchRateDenom { get; set; } = 1m; // RECVR_MISC_4_EXCH_RATE_DENOM
        public decimal RecvrMisc5ExchRateNumer { get; set; } = 1m; // RECVR_MISC_5_EXCH_RATE_NUMER
        public decimal RecvrMisc5ExchRateDenom { get; set; } = 1m; // RECVR_MISC_5_EXCH_RATE_DENOM
        public decimal? RecvrSubTotHome { get; private set; } // RECVR_SUB_TOT_HOME
        public decimal? RecvrMiscAmt1Home { get; private set; } // RECVR_MISC_AMT_1_HOME
        public decimal? RecvrMiscAmt2Home { get; private set; } // RECVR_MISC_AMT_2_HOME
        public decimal? RecvrMiscAmt3Home { get; private set; } // RECVR_MISC_AMT_3_HOME
        public decimal? RecvrMiscAmt4Home { get; private set; } // RECVR_MISC_AMT_4_HOME
        public decimal? RecvrMiscAmt5Home { get; private set; } // RECVR_MISC_AMT_5_HOME
        public decimal? RecvrTotMiscHome { get; private set; } // RECVR_TOT_MISC_HOME
        public decimal? RecvrTotHome { get; private set; } // RECVR_TOT_HOME
        public decimal AdjExchRateNumer { get; set; } = 1m; // ADJ_EXCH_RATE_NUMER
        public decimal AdjExchRateDenom { get; set; } = 1m; // ADJ_EXCH_RATE_DENOM
        public decimal AdjMisc1ExchRateNumer { get; set; } = 1m; // ADJ_MISC_1_EXCH_RATE_NUMER
        public decimal AdjMisc1ExchRateDenom { get; set; } = 1m; // ADJ_MISC_1_EXCH_RATE_DENOM
        public decimal AdjMisc2ExchRateNumer { get; set; } = 1m; // ADJ_MISC_2_EXCH_RATE_NUMER
        public decimal AdjMisc2ExchRateDenom { get; set; } = 1m; // ADJ_MISC_2_EXCH_RATE_DENOM
        public decimal AdjMisc3ExchRateNumer { get; set; } = 1m; // ADJ_MISC_3_EXCH_RATE_NUMER
        public decimal AdjMisc3ExchRateDenom { get; set; } = 1m; // ADJ_MISC_3_EXCH_RATE_DENOM
        public decimal AdjMisc4ExchRateNumer { get; set; } = 1m; // ADJ_MISC_4_EXCH_RATE_NUMER
        public decimal AdjMisc4ExchRateDenom { get; set; } = 1m; // ADJ_MISC_4_EXCH_RATE_DENOM
        public decimal AdjMisc5ExchRateNumer { get; set; } = 1m; // ADJ_MISC_5_EXCH_RATE_NUMER
        public decimal AdjMisc5ExchRateDenom { get; set; } = 1m; // ADJ_MISC_5_EXCH_RATE_DENOM
        public decimal? AdjSubTotHome { get; private set; } // ADJ_SUB_TOT_HOME
        public decimal? AdjMiscAmt1Home { get; private set; } // ADJ_MISC_AMT_1_HOME
        public decimal? AdjMiscAmt2Home { get; private set; } // ADJ_MISC_AMT_2_HOME
        public decimal? AdjMiscAmt3Home { get; private set; } // ADJ_MISC_AMT_3_HOME
        public decimal? AdjMiscAmt4Home { get; private set; } // ADJ_MISC_AMT_4_HOME
        public decimal? AdjMiscAmt5Home { get; private set; } // ADJ_MISC_AMT_5_HOME
        public decimal? AdjTotMiscHome { get; private set; } // ADJ_TOT_MISC_HOME
        public decimal? AdjTotHome { get; private set; } // ADJ_TOT_HOME
        public string YourTaxIdNo { get; set; } // YOUR_TAX_ID_NO (length: 30)
        public string VendTaxIdNo { get; set; } // VEND_TAX_ID_NO (length: 30)
        public string TaxCodNorm { get; set; } // TAX_COD_NORM (length: 10)
        public string TaxCod { get; set; } // TAX_COD (length: 10)
        public string TaxCodChngd { get; private set; } // TAX_COD_CHNGD (length: 1)
        public decimal RecvrTaxAmtNormHome { get; set; } = 0m; // RECVR_TAX_AMT_NORM_HOME
        public decimal? RecvrTaxAmtNorm { get; private set; } // RECVR_TAX_AMT_NORM
        public string RecvrHasTaxOvrd { get; set; } = "!"; // RECVR_HAS_TAX_OVRD (length: 1)
        public decimal RecvrTaxAmtHome { get; set; } = 0m; // RECVR_TAX_AMT_HOME
        public decimal? RecvrTaxAmt { get; private set; } // RECVR_TAX_AMT
        public decimal AdjTaxAmtNormHome { get; set; } = 0m; // ADJ_TAX_AMT_NORM_HOME
        public decimal? AdjTaxAmtNorm { get; private set; } // ADJ_TAX_AMT_NORM
        public string AdjHasTaxOvrd { get; set; } = "!"; // ADJ_HAS_TAX_OVRD (length: 1)
        public decimal AdjTaxAmtHome { get; set; } = 0m; // ADJ_TAX_AMT_HOME
        public decimal? AdjTaxAmt { get; private set; } // ADJ_TAX_AMT
        public string UserTradeinBuybackCustFstNam { get; set; } // USER_TRADEIN_BUYBACK_CUST_FST_NAM (length: 15)
        public string UserTradeinBuybackCustState { get; set; } // USER_TRADEIN_BUYBACK_CUST_STATE (length: 10)
        public string UserTradeinBuybackCustFfl { get; set; } // USER_TRADEIN_BUYBACK_CUST_FFL (length: 40)
        public string UserTradeinBuybackCustMidNam { get; set; } // USER_TRADEIN_BUYBACK_CUST_MID_NAM (length: 50)
        public string UserTradeinBuybackCustZip { get; set; } // USER_TRADEIN_BUYBACK_CUST_ZIP (length: 15)
        public string UserTradeinBuybackCustAdrs1 { get; set; } // USER_TRADEIN_BUYBACK_CUST_ADRS_1 (length: 40)
        public string UserTradeinBuybackCustNo { get; set; } // USER_TRADEIN_BUYBACK_CUST_NO (length: 15)
        public string UserTradeinBuybackCustAdrs3 { get; set; } // USER_TRADEIN_BUYBACK_CUST_ADRS_3 (length: 40)
        public string UserTradeinBuybackCustCity { get; set; } // USER_TRADEIN_BUYBACK_CUST_CITY (length: 20)
        public string UserConsigned { get; set; } = "N"; // USER_CONSIGNED (length: 1)
        public string UserTradeinBuybackCustAdrs2 { get; set; } // USER_TRADEIN_BUYBACK_CUST_ADRS_2 (length: 40)
        public string UserTradeinBuybackCustLstNam { get; set; } // USER_TRADEIN_BUYBACK_CUST_LST_NAM (length: 25)

        // Reverse navigation

        /// <summary>
        /// Child PoRecvrHistLins where [PO_RECVR_HIST_LIN].[RECVR_NO] point to this entity (FK_PO_RECVR_HIST_LIN_PO_RECVR_HIST)
        /// </summary>
        public virtual IList<PoRecvrHistLin> PoRecvrHistLins { get; set; } = new List<PoRecvrHistLin>(); // PO_RECVR_HIST_LIN.FK_PO_RECVR_HIST_LIN_PO_RECVR_HIST

        /// <summary>
        /// Child PoRecvrHistNotes where [PO_RECVR_HIST_NOTE].[RECVR_NO] point to this entity (FK_PO_RECVR_HIST_NOTE_PO_RECVR_HIST)
        /// </summary>
        public virtual IList<PoRecvrHistNote> PoRecvrHistNotes { get; set; } = new List<PoRecvrHistNote>(); // PO_RECVR_HIST_NOTE.FK_PO_RECVR_HIST_NOTE_PO_RECVR_HIST

        /// <summary>
        /// Child PoRecvrHistTaxes where [PO_RECVR_HIST_TAX].[RECVR_NO] point to this entity (FK_PO_RECVR_HIST_TAX_PO_RECVR_HIST)
        /// </summary>
        public virtual IList<PoRecvrHistTax> PoRecvrHistTaxes { get; set; } = new List<PoRecvrHistTax>(); // PO_RECVR_HIST_TAX.FK_PO_RECVR_HIST_TAX_PO_RECVR_HIST

        /// <summary>
        /// Child PoRecvrHistVchrActivs where [PO_RECVR_HIST_VCHR_ACTIV].[RECVR_NO] point to this entity (FK_PO_RECVR_HIST_VCHR_ACTIV_PO_RECVR_HIST)
        /// </summary>
        public virtual IList<PoRecvrHistVchrActiv> PoRecvrHistVchrActivs { get; set; } = new List<PoRecvrHistVchrActiv>(); // PO_RECVR_HIST_VCHR_ACTIV.FK_PO_RECVR_HIST_VCHR_ACTIV_PO_RECVR_HIST

        // Foreign keys

        /// <summary>
        /// Parent ImLocHist pointed by [PO_RECVR_HIST].([RecvrLocId]) (FK_PO_RECVR_HIST_IM_LOC_HIST)
        /// </summary>
        public virtual ImLocHist ImLocHist { get; set; } // FK_PO_RECVR_HIST_IM_LOC_HIST
    }

}
// </auto-generated>

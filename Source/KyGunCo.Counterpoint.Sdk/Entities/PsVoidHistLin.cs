// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_VOID_HIST_LIN
    public class PsVoidHistLin
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int LinSeqNo { get; set; } // LIN_SEQ_NO (Primary key)
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public Guid LinGuid { get; set; } // LIN_GUID
        public Guid? LinkLinGuid { get; set; } // LINK_LIN_GUID
        public string LinTyp { get; set; } // LIN_TYP (length: 1)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string Barcod { get; set; } // BARCOD (length: 20)
        public string RndmWeightBarcod { get; set; } // RNDM_WEIGHT_BARCOD (length: 20)
        public string StkLocId { get; set; } // STK_LOC_ID (length: 10)
        public string PrcLocId { get; set; } // PRC_LOC_ID (length: 10)
        public string PftCtr { get; set; } // PFT_CTR (length: 20)
        public string Descr { get; set; } // DESCR (length: 50)
        public string CategCod { get; set; } // CATEG_COD (length: 10)
        public string SubcatCod { get; set; } // SUBCAT_COD (length: 10)
        public string ItemVendNo { get; set; } // ITEM_VEND_NO (length: 15)
        public string ItemTyp { get; set; } = "I"; // ITEM_TYP (length: 1)
        public string TrkMeth { get; set; } = "N"; // TRK_METH (length: 1)
        public string NormTaxCateg { get; set; } // NORM_TAX_CATEG (length: 10)
        public string TaxCateg { get; set; } // TAX_CATEG (length: 10)
        public string NormIsTxbl { get; set; } = "Y"; // NORM_IS_TXBL (length: 1)
        public string IsTxbl { get; set; } = "Y"; // IS_TXBL (length: 1)
        public string IsFoodStmpElig { get; set; } = "N"; // IS_FOOD_STMP_ELIG (length: 1)
        public string SlsRep { get; set; } // SLS_REP (length: 10)
        public string RetReas { get; set; } // RET_REAS (length: 10)
        public string Ref { get; set; } // REF (length: 50)
        public decimal QtySold { get; set; } // QTY_SOLD
        public decimal QtyNumer { get; set; } = 1m; // QTY_NUMER
        public decimal QtyDenom { get; set; } = 1m; // QTY_DENOM
        public string QtyUnit { get; set; } // QTY_UNIT (length: 15)
        public string SellUnit { get; set; } = "0"; // SELL_UNIT (length: 1)
        public decimal? UnitWeight { get; set; } // UNIT_WEIGHT
        public decimal? UnitCube { get; set; } // UNIT_CUBE
        public decimal? UnitCost { get; set; } // UNIT_COST
        public decimal? Prc1 { get; set; } // PRC_1
        public decimal? CalcPrc { get; set; } // CALC_PRC
        public decimal? RegPrc { get; set; } // REG_PRC
        public decimal? Prc { get; set; } // PRC
        public decimal? ExtCost { get; set; } // EXT_COST
        public decimal ExtPrc { get; set; } // EXT_PRC
        public decimal? UnitRetlVal { get; set; } // UNIT_RETL_VAL
        public decimal? UnitRetlAtPost { get; set; } // UNIT_RETL_AT_POST
        public decimal? TotCostCorr { get; set; } // TOT_COST_CORR
        public string CellDescr { get; set; } // CELL_DESCR (length: 50)
        public string IsSingleCell { get; set; } = "N"; // IS_SINGLE_CELL (length: 1)
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public string SerNo { get; set; } // SER_NO (length: 30)
        public int? NoOfSersEntd { get; set; } // NO_OF_SERS_ENTD
        public string TareCod { get; set; } // TARE_COD (length: 10)
        public int? TareCodIdx { get; set; } // TARE_COD_IDX
        public decimal? TareWeight { get; set; } // TARE_WEIGHT
        public int? EcSeqNo { get; set; } // EC_SEQ_NO
        public long? GftRgstryId { get; set; } // GFT_RGSTRY_ID
        public string HasPrcOvrd { get; set; } = "N"; // HAS_PRC_OVRD (length: 1)
        public string PrcOvrdReas { get; set; } // PRC_OVRD_REAS (length: 10)
        public decimal? CostEntd { get; set; } // COST_ENTD
        public decimal? PresumedCost { get; set; } // PRESUMED_COST
        public decimal? StdCost { get; set; } // STD_COST
        public string MixMatchCod { get; set; } // MIX_MATCH_COD (length: 10)
        public decimal? MixMatchContrib { get; set; } // MIX_MATCH_CONTRIB
        public string MixMatchPrcBasedOn { get; set; } = "!"; // MIX_MATCH_PRC_BASED_ON (length: 1)
        public string UsrEntdPrc { get; set; } = "N"; // USR_ENTD_PRC (length: 1)
        public decimal GrossExtPrc { get; set; } // GROSS_EXT_PRC
        public Guid? ParLinGuid { get; set; } // PAR_LIN_GUID
        public string IsKitPar { get; set; } = "N"; // IS_KIT_PAR (length: 1)
        public decimal? GrossDispExtPrc { get; set; } // GROSS_DISP_EXT_PRC
        public decimal? DispExtPrc { get; set; } // DISP_EXT_PRC
        public string IsDiscntbl { get; set; } = "Y"; // IS_DISCNTBL (length: 1)
        public decimal CalcExtPrc { get; set; } // CALC_EXT_PRC
        public Guid? LinGrpGuid { get; set; } // LIN_GRP_GUID
        public decimal TaxAmtAlloc { get; set; } = 0m; // TAX_AMT_ALLOC
        public decimal NormTaxAmtAlloc { get; set; } = 0m; // NORM_TAX_AMT_ALLOC
        public string IsManEntdWght { get; set; } = "N"; // IS_MAN_ENTD_WGHT (length: 1)
        public string IsWeighed { get; set; } = "N"; // IS_WEIGHED (length: 1)

        // Reverse navigation

        /// <summary>
        /// Child PsVoidHistDiscs where [PS_VOID_HIST_DISC].([BUS_DAT], [DOC_ID], [LIN_SEQ_NO]) point to this entity (FK_PS_VOID_HIST_DISC_PS_VOID_HIST_LIN)
        /// </summary>
        public virtual IList<PsVoidHistDisc> PsVoidHistDiscs { get; set; } = new List<PsVoidHistDisc>(); // PS_VOID_HIST_DISC.FK_PS_VOID_HIST_DISC_PS_VOID_HIST_LIN

        /// <summary>
        /// Child PsVoidHistLinCells where [PS_VOID_HIST_LIN_CELL].([BUS_DAT], [DOC_ID], [LIN_SEQ_NO]) point to this entity (FK_PS_VOID_HIST_LIN_CELL_PS_VOID_HIST_LIN)
        /// </summary>
        public virtual IList<PsVoidHistLinCell> PsVoidHistLinCells { get; set; } = new List<PsVoidHistLinCell>(); // PS_VOID_HIST_LIN_CELL.FK_PS_VOID_HIST_LIN_CELL_PS_VOID_HIST_LIN

        /// <summary>
        /// Child PsVoidHistLinPrices where [PS_VOID_HIST_LIN_PRICE].([BUS_DAT], [DOC_ID], [LIN_SEQ_NO]) point to this entity (FK_PS_VOID_HIST_LIN_PRICE_PS_VOID_HIST_LIN)
        /// </summary>
        public virtual IList<PsVoidHistLinPrice> PsVoidHistLinPrices { get; set; } = new List<PsVoidHistLinPrice>(); // PS_VOID_HIST_LIN_PRICE.FK_PS_VOID_HIST_LIN_PRICE_PS_VOID_HIST_LIN

        /// <summary>
        /// Child PsVoidHistLinPrompts where [PS_VOID_HIST_LIN_PROMPT].([BUS_DAT], [DOC_ID], [LIN_SEQ_NO]) point to this entity (FK_PS_VOID_HIST_LIN_PROMPT_PS_VOID_HIST_LIN)
        /// </summary>
        public virtual IList<PsVoidHistLinPrompt> PsVoidHistLinPrompts { get; set; } = new List<PsVoidHistLinPrompt>(); // PS_VOID_HIST_LIN_PROMPT.FK_PS_VOID_HIST_LIN_PROMPT_PS_VOID_HIST_LIN

        /// <summary>
        /// Child PsVoidHistLinSers where [PS_VOID_HIST_LIN_SER].([BUS_DAT], [DOC_ID], [LIN_SEQ_NO]) point to this entity (FK_PS_VOID_HIST_LIN_SER_PS_VOID_HIST_LIN)
        /// </summary>
        public virtual IList<PsVoidHistLinSer> PsVoidHistLinSers { get; set; } = new List<PsVoidHistLinSer>(); // PS_VOID_HIST_LIN_SER.FK_PS_VOID_HIST_LIN_SER_PS_VOID_HIST_LIN

        /// <summary>
        /// Parent (One-to-One) PsVoidHistLin pointed by [PS_VOID_HIST_LIN_EXT].([BUS_DAT_EXT], [DOC_ID_EXT], [LIN_SEQ_NO_EXT]) (FK_PS_VOID_HIST_LIN_EXT_PS_VOID_HIST_LIN)
        /// </summary>
        public virtual PsVoidHistLinExt PsVoidHistLinExt { get; set; } // PS_VOID_HIST_LIN_EXT.FK_PS_VOID_HIST_LIN_EXT_PS_VOID_HIST_LIN

        /// <summary>
        /// Parent (One-to-One) PsVoidHistLin pointed by [PS_VOID_HIST_LIN_KIT].([BUS_DAT], [DOC_ID], [LIN_SEQ_NO]) (FK_PS_VOID_HIST_LIN_KIT_PS_VOID_HIST_LIN)
        /// </summary>
        public virtual PsVoidHistLinKit PsVoidHistLinKit { get; set; } // PS_VOID_HIST_LIN_KIT.FK_PS_VOID_HIST_LIN_KIT_PS_VOID_HIST_LIN

        /// <summary>
        /// Parent (One-to-One) PsVoidHistLin pointed by [PS_VOID_HIST_LIN_LOY].([BUS_DAT], [DOC_ID], [LIN_SEQ_NO]) (FK_PS_VOID_HIST_LIN_LOY_PS_VOID_HIST_LIN)
        /// </summary>
        public virtual PsVoidHistLinLoy PsVoidHistLinLoy { get; set; } // PS_VOID_HIST_LIN_LOY.FK_PS_VOID_HIST_LIN_LOY_PS_VOID_HIST_LIN

        /// <summary>
        /// Parent (One-to-One) PsVoidHistLin pointed by [PS_VOID_HIST_LIN_PO].([BUS_DAT], [DOC_ID], [LIN_SEQ_NO]) (FK_PS_VOID_HIST_LIN_PO_PS_VOID_HIST_LIN)
        /// </summary>
        public virtual PsVoidHistLinPo PsVoidHistLinPo { get; set; } // PS_VOID_HIST_LIN_PO.FK_PS_VOID_HIST_LIN_PO_PS_VOID_HIST_LIN

        // Foreign keys

        /// <summary>
        /// Parent PsVoidHist pointed by [PS_VOID_HIST_LIN].([BusDat], [DocId]) (FK_PS_VOID_HIST_LIN_PS_VOID_HIST)
        /// </summary>
        public virtual PsVoidHist PsVoidHist { get; set; } // FK_PS_VOID_HIST_LIN_PS_VOID_HIST
    }

}
// </auto-generated>

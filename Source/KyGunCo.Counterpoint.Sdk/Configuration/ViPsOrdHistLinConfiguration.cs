// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_ORD_HIST_LIN
    public class ViPsOrdHistLinConfiguration : IEntityTypeConfiguration<ViPsOrdHistLin>
    {
        public void Configure(EntityTypeBuilder<ViPsOrdHistLin> builder)
        {
            builder.ToView("VI_PS_ORD_HIST_LIN", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LinGuid).HasColumnName(@"LIN_GUID").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.LinTyp).HasColumnName(@"LIN_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LinkLinGuid).HasColumnName(@"LINK_LIN_GUID").HasColumnType("uniqueidentifier").IsRequired(false);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.SlsRep).HasColumnName(@"SLS_REP").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PostDat).HasColumnName(@"POST_DAT").HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.TktDat).HasColumnName(@"TKT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.IsDiscntbl).HasColumnName(@"IS_DISCNTBL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.IsManEntdWght).HasColumnName(@"IS_MAN_ENTD_WGHT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.IsWeighed).HasColumnName(@"IS_WEIGHED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.IsKitPar).HasColumnName(@"IS_KIT_PAR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ParLinGuid).HasColumnName(@"PAR_LIN_GUID").HasColumnType("uniqueidentifier").IsRequired(false);
            builder.Property(x => x.ParItemNo).HasColumnName(@"PAR_ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.KitCompQty).HasColumnName(@"KIT_COMP_QTY").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.KitCompQtyUnitFlg).HasColumnName(@"KIT_COMP_QTY_UNIT_FLG").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.KitCompUpcharge).HasColumnName(@"KIT_COMP_UPCHARGE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.KitCompItemNo).HasColumnName(@"KIT_COMP_ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.KitCompDim1Upr).HasColumnName(@"KIT_COMP_DIM_1_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.KitCompDim2Upr).HasColumnName(@"KIT_COMP_DIM_2_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.KitCompDim3Upr).HasColumnName(@"KIT_COMP_DIM_3_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.KitSubsTyp).HasColumnName(@"KIT_SUBS_TYP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.KitPrcAdjTyp).HasColumnName(@"KIT_PRC_ADJ_TYP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.KitAdjPrcLvl).HasColumnName(@"KIT_ADJ_PRC_LVL").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.StkLocId).HasColumnName(@"STK_LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PrcLocId).HasColumnName(@"PRC_LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PftCtr).HasColumnName(@"PFT_CTR").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Barcod).HasColumnName(@"BARCOD").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RndmWeightBarcod).HasColumnName(@"RNDM_WEIGHT_BARCOD").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.CategCod).HasColumnName(@"CATEG_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SubcatCod).HasColumnName(@"SUBCAT_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ItemVendNo).HasColumnName(@"ITEM_VEND_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ItemTyp).HasColumnName(@"ITEM_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TrkMeth).HasColumnName(@"TRK_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TareCod).HasColumnName(@"TARE_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TareWeight).HasColumnName(@"TARE_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.TareCodIdx).HasColumnName(@"TARE_COD_IDX").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.UnitWeight).HasColumnName(@"UNIT_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.UnitCube).HasColumnName(@"UNIT_CUBE").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.NormIsTxbl).HasColumnName(@"NORM_IS_TXBL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.IsTxbl).HasColumnName(@"IS_TXBL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.HasTaxOvrd).HasColumnName(@"HAS_TAX_OVRD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.NormTaxCateg).HasColumnName(@"NORM_TAX_CATEG").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCateg).HasColumnName(@"TAX_CATEG").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxAmtAlloc).HasColumnName(@"TAX_AMT_ALLOC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.NormTaxAmtAlloc).HasColumnName(@"NORM_TAX_AMT_ALLOC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TaxCategChngd).HasColumnName(@"TAX_CATEG_CHNGD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.QtySold).HasColumnName(@"QTY_SOLD").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyNumer).HasColumnName(@"QTY_NUMER").HasColumnType("decimal(11,0)").IsRequired();
            builder.Property(x => x.QtyDenom).HasColumnName(@"QTY_DENOM").HasColumnType("decimal(11,0)").IsRequired();
            builder.Property(x => x.QtyUnit).HasColumnName(@"QTY_UNIT").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.SellUnit).HasColumnName(@"SELL_UNIT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrigQty).HasColumnName(@"ORIG_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyShipped).HasColumnName(@"QTY_SHIPPED").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.Prc1).HasColumnName(@"PRC_1").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.Prc1Disc).HasColumnName(@"PRC_1_DISC").HasColumnType("numeric(20,4)").IsRequired(false);
            builder.Property(x => x.Prc1DiscPct).HasColumnName(@"PRC_1_DISC_PCT").HasColumnType("numeric(38,14)").IsRequired(false);
            builder.Property(x => x.UnitRetlVal).HasColumnName(@"UNIT_RETL_VAL").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.UnitRetlValDisc).HasColumnName(@"UNIT_RETL_VAL_DISC").HasColumnType("numeric(20,4)").IsRequired(false);
            builder.Property(x => x.UnitRetlValDiscPct).HasColumnName(@"UNIT_RETL_VAL_DISC_PCT").HasColumnType("numeric(38,14)").IsRequired(false);
            builder.Property(x => x.UnitRetlAtPost).HasColumnName(@"UNIT_RETL_AT_POST").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.RegPrc).HasColumnName(@"REG_PRC").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.RegPrcDisc).HasColumnName(@"REG_PRC_DISC").HasColumnType("numeric(20,4)").IsRequired(false);
            builder.Property(x => x.RegPrcDiscPct).HasColumnName(@"REG_PRC_DISC_PCT").HasColumnType("numeric(38,14)").IsRequired(false);
            builder.Property(x => x.CalcPrc).HasColumnName(@"CALC_PRC").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.CalcPrcDisc).HasColumnName(@"CALC_PRC_DISC").HasColumnType("numeric(20,4)").IsRequired(false);
            builder.Property(x => x.CalcPrcDiscPct).HasColumnName(@"CALC_PRC_DISC_PCT").HasColumnType("numeric(38,14)").IsRequired(false);
            builder.Property(x => x.MixMatchCod).HasColumnName(@"MIX_MATCH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.MixMatchContrib).HasColumnName(@"MIX_MATCH_CONTRIB").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.MixMatchPrcBasedOn).HasColumnName(@"MIX_MATCH_PRC_BASED_ON").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Prc).HasColumnName(@"PRC").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.UsrEntdPrc).HasColumnName(@"USR_ENTD_PRC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.HasPrcOvrd).HasColumnName(@"HAS_PRC_OVRD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PrcOvrdReas).HasColumnName(@"PRC_OVRD_REAS").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PresumedCost).HasColumnName(@"PRESUMED_COST").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.CostEntd).HasColumnName(@"COST_ENTD").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.UseCostEntd).HasColumnName(@"USE_COST_ENTD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Cost).HasColumnName(@"COST").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.StdCost).HasColumnName(@"STD_COST").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.TotCostCorr).HasColumnName(@"TOT_COST_CORR").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ExtWeight).HasColumnName(@"EXT_WEIGHT").HasColumnType("decimal(31,8)").IsRequired(false);
            builder.Property(x => x.ExtCube).HasColumnName(@"EXT_CUBE").HasColumnType("decimal(35,8)").IsRequired(false);
            builder.Property(x => x.ExtCost).HasColumnName(@"EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.EstExtCost).HasColumnName(@"EST_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.GrossExtPrc).HasColumnName(@"GROSS_EXT_PRC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.DiscntdExtPrc).HasColumnName(@"DISCNTD_EXT_PRC").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.ExtPrc).HasColumnName(@"EXT_PRC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.CalcExtPrc).HasColumnName(@"CALC_EXT_PRC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.GrossDispExtPrc).HasColumnName(@"GROSS_DISP_EXT_PRC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DiscntdDispExtPrc).HasColumnName(@"DISCNTD_DISP_EXT_PRC").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.DispExtPrc).HasColumnName(@"DISP_EXT_PRC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LinDiscAmt).HasColumnName(@"LIN_DISC_AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.HdrDiscAmt).HasColumnName(@"HDR_DISC_AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.IsSingleCell).HasColumnName(@"IS_SINGLE_CELL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CellDescr).HasColumnName(@"CELL_DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.NoOfSersEntd).HasColumnName(@"NO_OF_SERS_ENTD").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.SerDescr).HasColumnName(@"SER_DESCR").HasColumnType("varchar(53)").IsRequired(false).IsUnicode(false).HasMaxLength(53);
            builder.Property(x => x.EcSeqNo).HasColumnName(@"EC_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.GftRgstryId).HasColumnName(@"GFT_RGSTRY_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.PoPreqNo).HasColumnName(@"PO_PREQ_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PoOrdNo).HasColumnName(@"PO_ORD_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.PoLinSeqNo).HasColumnName(@"PO_LIN_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.PoRecvrNo).HasColumnName(@"PO_RECVR_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PoRecvrLinSeqNo).HasColumnName(@"PO_RECVR_LIN_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.PoQtyExpectd).HasColumnName(@"PO_QTY_EXPECTD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.PoTotQtyRecvd).HasColumnName(@"PO_TOT_QTY_RECVD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.PoRecvrCnt).HasColumnName(@"PO_RECVR_CNT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.PoOrdDescr).HasColumnName(@"PO_ORD_DESCR").HasColumnType("varchar(89)").IsRequired(false).IsUnicode(false).HasMaxLength(89);
            builder.Property(x => x.PoRecvStat).HasColumnName(@"PO_RECV_STAT").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PromptNo1).HasColumnName(@"PROMPT_NO_1").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.PromptCod1).HasColumnName(@"PROMPT_COD_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PromptAlpha1).HasColumnName(@"PROMPT_ALPHA_1").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptDat1).HasColumnName(@"PROMPT_DAT_1").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Prompt1Str).HasColumnName(@"PROMPT_1_STR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptNo2).HasColumnName(@"PROMPT_NO_2").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.PromptCod2).HasColumnName(@"PROMPT_COD_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PromptAlpha2).HasColumnName(@"PROMPT_ALPHA_2").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptDat2).HasColumnName(@"PROMPT_DAT_2").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Prompt2Str).HasColumnName(@"PROMPT_2_STR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptNo3).HasColumnName(@"PROMPT_NO_3").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.PromptCod3).HasColumnName(@"PROMPT_COD_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PromptAlpha3).HasColumnName(@"PROMPT_ALPHA_3").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PromptDat3).HasColumnName(@"PROMPT_DAT_3").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Prompt3Str).HasColumnName(@"PROMPT_3_STR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.BusDatExt).HasColumnName(@"BUS_DAT_EXT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.DocIdExt).HasColumnName(@"DOC_ID_EXT").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.LinSeqNoExt).HasColumnName(@"LIN_SEQ_NO_EXT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.UserBuybackPrc).HasColumnName(@"USER_BUYBACK_PRC").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.UserBuybackTradeinItemNo).HasColumnName(@"USER_BUYBACK_TRADEIN_ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.UserBuybackTradeinDescr).HasColumnName(@"USER_BUYBACK_TRADEIN_DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserBuybackTradeinSerNo).HasColumnName(@"USER_BUYBACK_TRADEIN_SER_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserBuybackTradeinItemNote).HasColumnName(@"USER_BUYBACK_TRADEIN_ITEM_NOTE").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.UserTradeinBuybackExtCost).HasColumnName(@"USER_TRADEIN_BUYBACK_EXT_COST").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.UserBuybackTradeinTrxType).HasColumnName(@"USER_BUYBACK_TRADEIN_TRX_TYPE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserBuybackTradeinConsideration).HasColumnName(@"USER_BUYBACK_TRADEIN_CONSIDERATION").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.UserBuybackTradeinRecvrNo).HasColumnName(@"USER_BUYBACK_TRADEIN_RECVR_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserBuybackTradeinRecvrLinSeqNo).HasColumnName(@"USER_BUYBACK_TRADEIN_RECVR_LIN_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.UserTradeinBuybackProcessed).HasColumnName(@"USER_TRADEIN_BUYBACK_PROCESSED").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserTradeInProcessed).HasColumnName(@"USER_TRADE_IN_PROCESSED").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserConsignmentItemNo).HasColumnName(@"USER_CONSIGNMENT_ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.UserConsignmentDescr).HasColumnName(@"USER_CONSIGNMENT_DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserConsignmentSerNo).HasColumnName(@"USER_CONSIGNMENT_SER_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserConsignmentItemNote).HasColumnName(@"USER_CONSIGNMENT_ITEM_NOTE").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.UserConsignmentExtCost).HasColumnName(@"USER_CONSIGNMENT_EXT_COST").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.UserConsignmentTrxType).HasColumnName(@"USER_CONSIGNMENT_TRX_TYPE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserConsignmentConsideration).HasColumnName(@"USER_CONSIGNMENT_CONSIDERATION").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.UserConsignmentRecvrNo).HasColumnName(@"USER_CONSIGNMENT_RECVR_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserConsignmentRecvrLinSeqNo).HasColumnName(@"USER_CONSIGNMENT_RECVR_LIN_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.UserConsignmentProcessed).HasColumnName(@"USER_CONSIGNMENT_PROCESSED").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserConsignmentPayoutItemNo).HasColumnName(@"USER_CONSIGNMENT_PAYOUT_ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.UserConsignmentPayoutLocId).HasColumnName(@"USER_CONSIGNMENT_PAYOUT_LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserConsignmentPayoutSerNo).HasColumnName(@"USER_CONSIGNMENT_PAYOUT_SER_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserConsignmentPayoutRecvdDt).HasColumnName(@"USER_CONSIGNMENT_PAYOUT_RECVD_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.UserRentalAmmoCount).HasColumnName(@"USER_RENTAL_AMMO_COUNT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.UserIntakeType).HasColumnName(@"USER_INTAKE_TYPE").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserIntakeDocNo).HasColumnName(@"USER_INTAKE_DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
        }
    }

}
// </auto-generated>

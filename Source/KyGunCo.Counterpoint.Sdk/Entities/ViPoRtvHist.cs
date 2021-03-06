// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PO_RTV_HIST
    public class ViPoRtvHist
    {
        public string RtvNo { get; set; } // RTV_NO (length: 15)
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string BatId { get; set; } // BAT_ID (length: 10)
        public string VendNo { get; set; } // VEND_NO (length: 15)
        public string VendFstNam { get; set; } // VEND_FST_NAM (length: 15)
        public string VendFstNamUpr { get; set; } // VEND_FST_NAM_UPR (length: 15)
        public string VendLstNam { get; set; } // VEND_LST_NAM (length: 25)
        public string VendLstNamUpr { get; set; } // VEND_LST_NAM_UPR (length: 25)
        public string VendNam { get; set; } // VEND_NAM (length: 40)
        public string VendNamUpr { get; set; } // VEND_NAM_UPR (length: 40)
        public string VendSalutation { get; set; } // VEND_SALUTATION (length: 10)
        public string VendAdrs1 { get; set; } // VEND_ADRS_1 (length: 40)
        public string VendAdrs2 { get; set; } // VEND_ADRS_2 (length: 40)
        public string VendAdrs3 { get; set; } // VEND_ADRS_3 (length: 40)
        public string VendCity { get; set; } // VEND_CITY (length: 20)
        public string VendState { get; set; } // VEND_STATE (length: 10)
        public string VendZipCod { get; set; } // VEND_ZIP_COD (length: 15)
        public string VendCntry { get; set; } // VEND_CNTRY (length: 20)
        public string VendPhone { get; set; } // VEND_PHONE (length: 25)
        public string VendFax { get; set; } // VEND_FAX (length: 25)
        public string VendContct1 { get; set; } // VEND_CONTCT_1 (length: 40)
        public string VendContct2 { get; set; } // VEND_CONTCT_2 (length: 40)
        public decimal RtvMiscAmt1 { get; set; } // RTV_MISC_AMT_1
        public decimal RtvMiscAmt2 { get; set; } // RTV_MISC_AMT_2
        public decimal RtvMiscAmt3 { get; set; } // RTV_MISC_AMT_3
        public decimal RtvMiscAmt4 { get; set; } // RTV_MISC_AMT_4
        public decimal RtvMiscAmt5 { get; set; } // RTV_MISC_AMT_5
        public decimal RtvTotMisc { get; set; } // RTV_TOT_MISC
        public decimal RtvSubTot { get; set; } // RTV_SUB_TOT
        public decimal RtvTot { get; set; } // RTV_TOT
        public DateTime RtvDat { get; set; } // RTV_DAT
        public string RtvShipViaCod { get; set; } // RTV_SHIP_VIA_COD (length: 10)
        public string RtvLocId { get; set; } // RTV_LOC_ID (length: 10)
        public decimal TotQtyToRetn { get; set; } // TOT_QTY_TO_RETN
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string VchrStat { get; set; } // VCHR_STAT (length: 1)
        public string Ref { get; set; } // REF (length: 50)
        public string Commnt1 { get; set; } // COMMNT_1 (length: 50)
        public string Commnt2 { get; set; } // COMMNT_2 (length: 50)
        public string Commnt3 { get; set; } // COMMNT_3 (length: 50)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string RmaNo { get; set; } // RMA_NO (length: 15)
        public decimal TotExtCost { get; set; } // TOT_EXT_COST
        public decimal? RtvTotWeight { get; set; } // RTV_TOT_WEIGHT
        public decimal? RtvTotCube { get; set; } // RTV_TOT_CUBE
        public decimal? TotQtyRetdInStkUnits { get; set; } // TOT_QTY_RETD_IN_STK_UNITS
        public string CurncyCod { get; set; } // CURNCY_COD (length: 10)
        public string Misc1CurncyCod { get; set; } // MISC_1_CURNCY_COD (length: 10)
        public string Misc2CurncyCod { get; set; } // MISC_2_CURNCY_COD (length: 10)
        public string Misc3CurncyCod { get; set; } // MISC_3_CURNCY_COD (length: 10)
        public string Misc4CurncyCod { get; set; } // MISC_4_CURNCY_COD (length: 10)
        public string Misc5CurncyCod { get; set; } // MISC_5_CURNCY_COD (length: 10)
        public decimal RtvExchRateNumer { get; set; } // RTV_EXCH_RATE_NUMER
        public decimal RtvExchRateDenom { get; set; } // RTV_EXCH_RATE_DENOM
        public decimal RtvMisc1ExchRateNumer { get; set; } // RTV_MISC_1_EXCH_RATE_NUMER
        public decimal RtvMisc1ExchRateDenom { get; set; } // RTV_MISC_1_EXCH_RATE_DENOM
        public decimal RtvMisc2ExchRateNumer { get; set; } // RTV_MISC_2_EXCH_RATE_NUMER
        public decimal RtvMisc2ExchRateDenom { get; set; } // RTV_MISC_2_EXCH_RATE_DENOM
        public decimal RtvMisc3ExchRateNumer { get; set; } // RTV_MISC_3_EXCH_RATE_NUMER
        public decimal RtvMisc3ExchRateDenom { get; set; } // RTV_MISC_3_EXCH_RATE_DENOM
        public decimal RtvMisc4ExchRateNumer { get; set; } // RTV_MISC_4_EXCH_RATE_NUMER
        public decimal RtvMisc4ExchRateDenom { get; set; } // RTV_MISC_4_EXCH_RATE_DENOM
        public decimal RtvMisc5ExchRateNumer { get; set; } // RTV_MISC_5_EXCH_RATE_NUMER
        public decimal RtvMisc5ExchRateDenom { get; set; } // RTV_MISC_5_EXCH_RATE_DENOM
        public decimal? RtvSubTotHome { get; set; } // RTV_SUB_TOT_HOME
        public decimal? RtvMiscAmt1Home { get; set; } // RTV_MISC_AMT_1_HOME
        public decimal? RtvMiscAmt2Home { get; set; } // RTV_MISC_AMT_2_HOME
        public decimal? RtvMiscAmt3Home { get; set; } // RTV_MISC_AMT_3_HOME
        public decimal? RtvMiscAmt4Home { get; set; } // RTV_MISC_AMT_4_HOME
        public decimal? RtvMiscAmt5Home { get; set; } // RTV_MISC_AMT_5_HOME
        public decimal? RtvTotMiscHome { get; set; } // RTV_TOT_MISC_HOME
        public decimal? TotRtvAdjustAmt { get; set; } // TOT_RTV_ADJUST_AMT
        public string YourTaxIdNo { get; set; } // YOUR_TAX_ID_NO (length: 30)
        public string VendTaxIdNo { get; set; } // VEND_TAX_ID_NO (length: 30)
        public string TaxCodNorm { get; set; } // TAX_COD_NORM (length: 10)
        public string TaxCod { get; set; } // TAX_COD (length: 10)
        public string TaxCodChngd { get; set; } // TAX_COD_CHNGD (length: 1)
        public decimal RtvTaxAmtNormHome { get; set; } // RTV_TAX_AMT_NORM_HOME
        public decimal? RtvTaxAmtNorm { get; set; } // RTV_TAX_AMT_NORM
        public string RtvHasTaxOvrd { get; set; } // RTV_HAS_TAX_OVRD (length: 1)
        public decimal RtvTaxAmtHome { get; set; } // RTV_TAX_AMT_HOME
        public decimal? RtvTaxAmt { get; set; } // RTV_TAX_AMT
        public decimal? RtvTotHome { get; set; } // RTV_TOT_HOME
        public decimal? VchrSubTot { get; set; } // VCHR_SUB_TOT
        public decimal? VchrMiscAmt1 { get; set; } // VCHR_MISC_AMT_1
        public decimal? VchrMiscAmt2 { get; set; } // VCHR_MISC_AMT_2
        public decimal? VchrMiscAmt3 { get; set; } // VCHR_MISC_AMT_3
        public decimal? VchrMiscAmt4 { get; set; } // VCHR_MISC_AMT_4
        public decimal? VchrMiscAmt5 { get; set; } // VCHR_MISC_AMT_5
        public decimal? VchrTotMisc { get; set; } // VCHR_TOT_MISC
        public decimal? VchrTaxAmt { get; set; } // VCHR_TAX_AMT
        public decimal? VchrTot { get; set; } // VCHR_TOT
        public decimal? BalSubTot { get; set; } // BAL_SUB_TOT
        public decimal? BalMiscAmt1 { get; set; } // BAL_MISC_AMT_1
        public decimal? BalMiscAmt2 { get; set; } // BAL_MISC_AMT_2
        public decimal? BalMiscAmt3 { get; set; } // BAL_MISC_AMT_3
        public decimal? BalMiscAmt4 { get; set; } // BAL_MISC_AMT_4
        public decimal? BalMiscAmt5 { get; set; } // BAL_MISC_AMT_5
        public decimal? BalTaxAmt { get; set; } // BAL_TAX_AMT
        public decimal? BalTaxAmtHome { get; set; } // BAL_TAX_AMT_HOME
        public decimal? VchrSubTotHome { get; set; } // VCHR_SUB_TOT_HOME
        public decimal? VchrMiscAmt1Home { get; set; } // VCHR_MISC_AMT_1_HOME
        public decimal? VchrMiscAmt2Home { get; set; } // VCHR_MISC_AMT_2_HOME
        public decimal? VchrMiscAmt3Home { get; set; } // VCHR_MISC_AMT_3_HOME
        public decimal? VchrMiscAmt4Home { get; set; } // VCHR_MISC_AMT_4_HOME
        public decimal? VchrMiscAmt5Home { get; set; } // VCHR_MISC_AMT_5_HOME
        public decimal? VchrTotMiscHome { get; set; } // VCHR_TOT_MISC_HOME
        public decimal? VchrTaxAmtHome { get; set; } // VCHR_TAX_AMT_HOME
        public decimal? VchrTotHome { get; set; } // VCHR_TOT_HOME
        public decimal? VchrSubTotGainLossHome { get; set; } // VCHR_SUB_TOT_GAIN_LOSS_HOME
        public decimal? VchrMisc1GainLossHome { get; set; } // VCHR_MISC_1_GAIN_LOSS_HOME
        public decimal? VchrMisc2GainLossHome { get; set; } // VCHR_MISC_2_GAIN_LOSS_HOME
        public decimal? VchrMisc3GainLossHome { get; set; } // VCHR_MISC_3_GAIN_LOSS_HOME
        public decimal? VchrMisc4GainLossHome { get; set; } // VCHR_MISC_4_GAIN_LOSS_HOME
        public decimal? VchrMisc5GainLossHome { get; set; } // VCHR_MISC_5_GAIN_LOSS_HOME
        public decimal? VchrTaxGainLossHome { get; set; } // VCHR_TAX_GAIN_LOSS_HOME
        public decimal? VchrTotGainLossHome { get; set; } // VCHR_TOT_GAIN_LOSS_HOME
        public decimal? VchrTotWithGainLossHome { get; set; } // VCHR_TOT_WITH_GAIN_LOSS_HOME
        public string VchrNo { get; set; } // VCHR_NO (length: 20)
        public string VchrVendNo { get; set; } // VCHR_VEND_NO (length: 15)
        public DateTime? VchrDat { get; set; } // VCHR_DAT
        public DateTime? VchrTim { get; set; } // VCHR_TIM
        public string VchrBy { get; set; } // VCHR_BY (length: 10)
        public string VchrInvcNo { get; set; } // VCHR_INVC_NO (length: 20)
        public DateTime? VchrInvcDat { get; set; } // VCHR_INVC_DAT
        public DateTime? VchrDistDat { get; set; } // VCHR_DIST_DAT
        public string VchrRef { get; set; } // VCHR_REF (length: 50)
        public decimal? BalSubTotHome { get; set; } // BAL_SUB_TOT_HOME
        public decimal? BalMiscAmt1Home { get; set; } // BAL_MISC_AMT_1_HOME
        public decimal? BalMiscAmt2Home { get; set; } // BAL_MISC_AMT_2_HOME
        public decimal? BalMiscAmt3Home { get; set; } // BAL_MISC_AMT_3_HOME
        public decimal? BalMiscAmt4Home { get; set; } // BAL_MISC_AMT_4_HOME
        public decimal? BalMiscAmt5Home { get; set; } // BAL_MISC_AMT_5_HOME
        public decimal? BalTotMiscHome { get; set; } // BAL_TOT_MISC_HOME
        public decimal? BalTotHome { get; set; } // BAL_TOT_HOME
        public decimal? BalTotMisc { get; set; } // BAL_TOT_MISC
        public decimal? BalTot { get; set; } // BAL_TOT
    }

}
// </auto-generated>

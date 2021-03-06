// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PO_RTV_HIST
    public class ViPoRtvHistConfiguration : IEntityTypeConfiguration<ViPoRtvHist>
    {
        public void Configure(EntityTypeBuilder<ViPoRtvHist> builder)
        {
            builder.ToView("VI_PO_RTV_HIST", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.RtvNo).HasColumnName(@"RTV_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.VendNo).HasColumnName(@"VEND_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VendFstNam).HasColumnName(@"VEND_FST_NAM").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VendFstNamUpr).HasColumnName(@"VEND_FST_NAM_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VendLstNam).HasColumnName(@"VEND_LST_NAM").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.VendLstNamUpr).HasColumnName(@"VEND_LST_NAM_UPR").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.VendNam).HasColumnName(@"VEND_NAM").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.VendNamUpr).HasColumnName(@"VEND_NAM_UPR").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.VendSalutation).HasColumnName(@"VEND_SALUTATION").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.VendAdrs1).HasColumnName(@"VEND_ADRS_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.VendAdrs2).HasColumnName(@"VEND_ADRS_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.VendAdrs3).HasColumnName(@"VEND_ADRS_3").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.VendCity).HasColumnName(@"VEND_CITY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.VendState).HasColumnName(@"VEND_STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.VendZipCod).HasColumnName(@"VEND_ZIP_COD").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VendCntry).HasColumnName(@"VEND_CNTRY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.VendPhone).HasColumnName(@"VEND_PHONE").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.VendFax).HasColumnName(@"VEND_FAX").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.VendContct1).HasColumnName(@"VEND_CONTCT_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.VendContct2).HasColumnName(@"VEND_CONTCT_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.RtvMiscAmt1).HasColumnName(@"RTV_MISC_AMT_1").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvMiscAmt2).HasColumnName(@"RTV_MISC_AMT_2").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvMiscAmt3).HasColumnName(@"RTV_MISC_AMT_3").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvMiscAmt4).HasColumnName(@"RTV_MISC_AMT_4").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvMiscAmt5).HasColumnName(@"RTV_MISC_AMT_5").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvTotMisc).HasColumnName(@"RTV_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvSubTot).HasColumnName(@"RTV_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvTot).HasColumnName(@"RTV_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvDat).HasColumnName(@"RTV_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.RtvShipViaCod).HasColumnName(@"RTV_SHIP_VIA_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RtvLocId).HasColumnName(@"RTV_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TotQtyToRetn).HasColumnName(@"TOT_QTY_TO_RETN").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.VchrStat).HasColumnName(@"VCHR_STAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt1).HasColumnName(@"COMMNT_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt2).HasColumnName(@"COMMNT_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt3).HasColumnName(@"COMMNT_3").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RmaNo).HasColumnName(@"RMA_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.TotExtCost).HasColumnName(@"TOT_EXT_COST").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvTotWeight).HasColumnName(@"RTV_TOT_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.RtvTotCube).HasColumnName(@"RTV_TOT_CUBE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.TotQtyRetdInStkUnits).HasColumnName(@"TOT_QTY_RETD_IN_STK_UNITS").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CurncyCod).HasColumnName(@"CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc1CurncyCod).HasColumnName(@"MISC_1_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc2CurncyCod).HasColumnName(@"MISC_2_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc3CurncyCod).HasColumnName(@"MISC_3_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc4CurncyCod).HasColumnName(@"MISC_4_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc5CurncyCod).HasColumnName(@"MISC_5_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RtvExchRateNumer).HasColumnName(@"RTV_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvExchRateDenom).HasColumnName(@"RTV_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvMisc1ExchRateNumer).HasColumnName(@"RTV_MISC_1_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvMisc1ExchRateDenom).HasColumnName(@"RTV_MISC_1_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvMisc2ExchRateNumer).HasColumnName(@"RTV_MISC_2_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvMisc2ExchRateDenom).HasColumnName(@"RTV_MISC_2_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvMisc3ExchRateNumer).HasColumnName(@"RTV_MISC_3_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvMisc3ExchRateDenom).HasColumnName(@"RTV_MISC_3_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvMisc4ExchRateNumer).HasColumnName(@"RTV_MISC_4_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvMisc4ExchRateDenom).HasColumnName(@"RTV_MISC_4_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvMisc5ExchRateNumer).HasColumnName(@"RTV_MISC_5_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvMisc5ExchRateDenom).HasColumnName(@"RTV_MISC_5_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RtvSubTotHome).HasColumnName(@"RTV_SUB_TOT_HOME").HasColumnType("decimal(38,9)").IsRequired(false);
            builder.Property(x => x.RtvMiscAmt1Home).HasColumnName(@"RTV_MISC_AMT_1_HOME").HasColumnType("decimal(38,9)").IsRequired(false);
            builder.Property(x => x.RtvMiscAmt2Home).HasColumnName(@"RTV_MISC_AMT_2_HOME").HasColumnType("decimal(38,9)").IsRequired(false);
            builder.Property(x => x.RtvMiscAmt3Home).HasColumnName(@"RTV_MISC_AMT_3_HOME").HasColumnType("decimal(38,9)").IsRequired(false);
            builder.Property(x => x.RtvMiscAmt4Home).HasColumnName(@"RTV_MISC_AMT_4_HOME").HasColumnType("decimal(38,9)").IsRequired(false);
            builder.Property(x => x.RtvMiscAmt5Home).HasColumnName(@"RTV_MISC_AMT_5_HOME").HasColumnType("decimal(38,9)").IsRequired(false);
            builder.Property(x => x.RtvTotMiscHome).HasColumnName(@"RTV_TOT_MISC_HOME").HasColumnType("decimal(38,9)").IsRequired(false);
            builder.Property(x => x.TotRtvAdjustAmt).HasColumnName(@"TOT_RTV_ADJUST_AMT").HasColumnType("decimal(21,2)").IsRequired(false);
            builder.Property(x => x.YourTaxIdNo).HasColumnName(@"YOUR_TAX_ID_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.VendTaxIdNo).HasColumnName(@"VEND_TAX_ID_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.TaxCodNorm).HasColumnName(@"TAX_COD_NORM").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCod).HasColumnName(@"TAX_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCodChngd).HasColumnName(@"TAX_COD_CHNGD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RtvTaxAmtNormHome).HasColumnName(@"RTV_TAX_AMT_NORM_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvTaxAmtNorm).HasColumnName(@"RTV_TAX_AMT_NORM").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.RtvHasTaxOvrd).HasColumnName(@"RTV_HAS_TAX_OVRD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RtvTaxAmtHome).HasColumnName(@"RTV_TAX_AMT_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvTaxAmt).HasColumnName(@"RTV_TAX_AMT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.RtvTotHome).HasColumnName(@"RTV_TOT_HOME").HasColumnType("decimal(38,9)").IsRequired(false);
            builder.Property(x => x.VchrSubTot).HasColumnName(@"VCHR_SUB_TOT").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt1).HasColumnName(@"VCHR_MISC_AMT_1").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt2).HasColumnName(@"VCHR_MISC_AMT_2").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt3).HasColumnName(@"VCHR_MISC_AMT_3").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt4).HasColumnName(@"VCHR_MISC_AMT_4").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt5).HasColumnName(@"VCHR_MISC_AMT_5").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrTotMisc).HasColumnName(@"VCHR_TOT_MISC").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrTaxAmt).HasColumnName(@"VCHR_TAX_AMT").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrTot).HasColumnName(@"VCHR_TOT").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.BalSubTot).HasColumnName(@"BAL_SUB_TOT").HasColumnType("decimal(21,2)").IsRequired(false);
            builder.Property(x => x.BalMiscAmt1).HasColumnName(@"BAL_MISC_AMT_1").HasColumnType("decimal(21,2)").IsRequired(false);
            builder.Property(x => x.BalMiscAmt2).HasColumnName(@"BAL_MISC_AMT_2").HasColumnType("decimal(21,2)").IsRequired(false);
            builder.Property(x => x.BalMiscAmt3).HasColumnName(@"BAL_MISC_AMT_3").HasColumnType("decimal(21,2)").IsRequired(false);
            builder.Property(x => x.BalMiscAmt4).HasColumnName(@"BAL_MISC_AMT_4").HasColumnType("decimal(21,2)").IsRequired(false);
            builder.Property(x => x.BalMiscAmt5).HasColumnName(@"BAL_MISC_AMT_5").HasColumnType("decimal(21,2)").IsRequired(false);
            builder.Property(x => x.BalTaxAmt).HasColumnName(@"BAL_TAX_AMT").HasColumnType("decimal(23,4)").IsRequired(false);
            builder.Property(x => x.BalTaxAmtHome).HasColumnName(@"BAL_TAX_AMT_HOME").HasColumnType("decimal(23,4)").IsRequired(false);
            builder.Property(x => x.VchrSubTotHome).HasColumnName(@"VCHR_SUB_TOT_HOME").HasColumnType("decimal(22,4)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt1Home).HasColumnName(@"VCHR_MISC_AMT_1_HOME").HasColumnType("decimal(22,4)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt2Home).HasColumnName(@"VCHR_MISC_AMT_2_HOME").HasColumnType("decimal(22,4)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt3Home).HasColumnName(@"VCHR_MISC_AMT_3_HOME").HasColumnType("decimal(22,4)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt4Home).HasColumnName(@"VCHR_MISC_AMT_4_HOME").HasColumnType("decimal(22,4)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt5Home).HasColumnName(@"VCHR_MISC_AMT_5_HOME").HasColumnType("decimal(22,4)").IsRequired(false);
            builder.Property(x => x.VchrTotMiscHome).HasColumnName(@"VCHR_TOT_MISC_HOME").HasColumnType("decimal(22,4)").IsRequired(false);
            builder.Property(x => x.VchrTaxAmtHome).HasColumnName(@"VCHR_TAX_AMT_HOME").HasColumnType("decimal(22,4)").IsRequired(false);
            builder.Property(x => x.VchrTotHome).HasColumnName(@"VCHR_TOT_HOME").HasColumnType("decimal(22,4)").IsRequired(false);
            builder.Property(x => x.VchrSubTotGainLossHome).HasColumnName(@"VCHR_SUB_TOT_GAIN_LOSS_HOME").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrMisc1GainLossHome).HasColumnName(@"VCHR_MISC_1_GAIN_LOSS_HOME").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrMisc2GainLossHome).HasColumnName(@"VCHR_MISC_2_GAIN_LOSS_HOME").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrMisc3GainLossHome).HasColumnName(@"VCHR_MISC_3_GAIN_LOSS_HOME").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrMisc4GainLossHome).HasColumnName(@"VCHR_MISC_4_GAIN_LOSS_HOME").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrMisc5GainLossHome).HasColumnName(@"VCHR_MISC_5_GAIN_LOSS_HOME").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrTaxGainLossHome).HasColumnName(@"VCHR_TAX_GAIN_LOSS_HOME").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrTotGainLossHome).HasColumnName(@"VCHR_TOT_GAIN_LOSS_HOME").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.VchrTotWithGainLossHome).HasColumnName(@"VCHR_TOT_WITH_GAIN_LOSS_HOME").HasColumnType("decimal(22,4)").IsRequired(false);
            builder.Property(x => x.VchrNo).HasColumnName(@"VCHR_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.VchrVendNo).HasColumnName(@"VCHR_VEND_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VchrDat).HasColumnName(@"VCHR_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.VchrTim).HasColumnName(@"VCHR_TIM").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.VchrBy).HasColumnName(@"VCHR_BY").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.VchrInvcNo).HasColumnName(@"VCHR_INVC_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.VchrInvcDat).HasColumnName(@"VCHR_INVC_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.VchrDistDat).HasColumnName(@"VCHR_DIST_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.VchrRef).HasColumnName(@"VCHR_REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.BalSubTotHome).HasColumnName(@"BAL_SUB_TOT_HOME").HasColumnType("decimal(38,6)").IsRequired(false);
            builder.Property(x => x.BalMiscAmt1Home).HasColumnName(@"BAL_MISC_AMT_1_HOME").HasColumnType("decimal(38,6)").IsRequired(false);
            builder.Property(x => x.BalMiscAmt2Home).HasColumnName(@"BAL_MISC_AMT_2_HOME").HasColumnType("decimal(38,6)").IsRequired(false);
            builder.Property(x => x.BalMiscAmt3Home).HasColumnName(@"BAL_MISC_AMT_3_HOME").HasColumnType("decimal(38,6)").IsRequired(false);
            builder.Property(x => x.BalMiscAmt4Home).HasColumnName(@"BAL_MISC_AMT_4_HOME").HasColumnType("decimal(38,6)").IsRequired(false);
            builder.Property(x => x.BalMiscAmt5Home).HasColumnName(@"BAL_MISC_AMT_5_HOME").HasColumnType("decimal(38,6)").IsRequired(false);
            builder.Property(x => x.BalTotMiscHome).HasColumnName(@"BAL_TOT_MISC_HOME").HasColumnType("decimal(38,6)").IsRequired(false);
            builder.Property(x => x.BalTotHome).HasColumnName(@"BAL_TOT_HOME").HasColumnType("decimal(38,6)").IsRequired(false);
            builder.Property(x => x.BalTotMisc).HasColumnName(@"BAL_TOT_MISC").HasColumnType("decimal(24,2)").IsRequired(false);
            builder.Property(x => x.BalTot).HasColumnName(@"BAL_TOT").HasColumnType("decimal(24,2)").IsRequired(false);
        }
    }

}
// </auto-generated>

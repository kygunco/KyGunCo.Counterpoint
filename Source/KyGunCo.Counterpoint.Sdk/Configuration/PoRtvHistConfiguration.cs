// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_RTV_HIST
    public class PoRtvHistConfiguration : IEntityTypeConfiguration<PoRtvHist>
    {
        public void Configure(EntityTypeBuilder<PoRtvHist> builder)
        {
            builder.ToTable("PO_RTV_HIST", "dbo");
            builder.HasKey(x => x.RtvNo).HasName("PK_PO_RTV_HIST").IsClustered();

            builder.Property(x => x.RtvNo).HasColumnName(@"RTV_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
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
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
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
            builder.Property(x => x.RtvSubTotHome).HasColumnName(@"RTV_SUB_TOT_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RtvMiscAmt1Home).HasColumnName(@"RTV_MISC_AMT_1_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RtvMiscAmt2Home).HasColumnName(@"RTV_MISC_AMT_2_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RtvMiscAmt3Home).HasColumnName(@"RTV_MISC_AMT_3_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RtvMiscAmt4Home).HasColumnName(@"RTV_MISC_AMT_4_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RtvMiscAmt5Home).HasColumnName(@"RTV_MISC_AMT_5_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RtvTotMiscHome).HasColumnName(@"RTV_TOT_MISC_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.TotRtvAdjustAmt).HasColumnName(@"TOT_RTV_ADJUST_AMT").HasColumnType("decimal(21,2)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.YourTaxIdNo).HasColumnName(@"YOUR_TAX_ID_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.VendTaxIdNo).HasColumnName(@"VEND_TAX_ID_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.TaxCodNorm).HasColumnName(@"TAX_COD_NORM").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCod).HasColumnName(@"TAX_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCodChngd).HasColumnName(@"TAX_COD_CHNGD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RtvTaxAmtNormHome).HasColumnName(@"RTV_TAX_AMT_NORM_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvTaxAmtNorm).HasColumnName(@"RTV_TAX_AMT_NORM").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RtvHasTaxOvrd).HasColumnName(@"RTV_HAS_TAX_OVRD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RtvTaxAmtHome).HasColumnName(@"RTV_TAX_AMT_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RtvTaxAmt).HasColumnName(@"RTV_TAX_AMT").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RtvTotHome).HasColumnName(@"RTV_TOT_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImLocHist).WithMany(b => b.PoRtvHists).HasForeignKey(c => c.RtvLocId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_RTV_HIST_IM_LOC_HIST");

            builder.HasIndex(x => new { x.VendNo, x.RtvNo }).HasDatabaseName("PO_RTV_HIST_X1");
            builder.HasIndex(x => new { x.UsrId, x.RtvNo }).HasDatabaseName("PO_RTV_HIST_X2");
            builder.HasIndex(x => new { x.RtvLocId, x.RtvNo }).HasDatabaseName("PO_RTV_HIST_X3");
            builder.HasIndex(x => new { x.EventNo, x.RtvNo }).HasDatabaseName("PO_RTV_HIST_X4");
            builder.HasIndex(x => new { x.VendNamUpr, x.RtvNo }).HasDatabaseName("PO_RTV_HIST_X5");
            builder.HasIndex(x => new { x.VendFstNamUpr, x.RtvNo }).HasDatabaseName("PO_RTV_HIST_X6");
            builder.HasIndex(x => new { x.VendLstNamUpr, x.RtvNo }).HasDatabaseName("PO_RTV_HIST_X7");
            builder.HasIndex(x => new { x.RtvDat, x.RtvNo }).HasDatabaseName("PO_RTV_HIST_X8");
        }
    }

}
// </auto-generated>
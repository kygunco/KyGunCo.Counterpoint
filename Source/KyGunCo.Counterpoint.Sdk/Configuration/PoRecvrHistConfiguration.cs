// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_RECVR_HIST
    public class PoRecvrHistConfiguration : IEntityTypeConfiguration<PoRecvrHist>
    {
        public void Configure(EntityTypeBuilder<PoRecvrHist> builder)
        {
            builder.ToTable("PO_RECVR_HIST", "dbo");
            builder.HasKey(x => x.RecvrNo).HasName("PK_PO_RECVR_HIST").IsClustered();

            builder.Property(x => x.RecvrNo).HasColumnName(@"RECVR_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.VendNo).HasColumnName(@"VEND_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VendFstNam).HasColumnName(@"VEND_FST_NAM").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VendFstNamUpr).HasColumnName(@"VEND_FST_NAM_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VendLstNam).HasColumnName(@"VEND_LST_NAM").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.VendLstNamUpr).HasColumnName(@"VEND_LST_NAM_UPR").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.VendNam).HasColumnName(@"VEND_NAM").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.VendNamUpr).HasColumnName(@"VEND_NAM_UPR").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.RecvrMiscAmt1).HasColumnName(@"RECVR_MISC_AMT_1").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvrMiscAmt2).HasColumnName(@"RECVR_MISC_AMT_2").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvrMiscAmt3).HasColumnName(@"RECVR_MISC_AMT_3").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvrMiscAmt4).HasColumnName(@"RECVR_MISC_AMT_4").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvrMiscAmt5).HasColumnName(@"RECVR_MISC_AMT_5").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvrTotMisc).HasColumnName(@"RECVR_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvrSubTot).HasColumnName(@"RECVR_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvrTot).HasColumnName(@"RECVR_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvrDat).HasColumnName(@"RECVR_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.RecvrShipViaCod).HasColumnName(@"RECVR_SHIP_VIA_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RecvrLocId).HasColumnName(@"RECVR_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TotSelLins).HasColumnName(@"TOT_SEL_LINS").HasColumnType("int").IsRequired();
            builder.Property(x => x.TotQtyToRecv).HasColumnName(@"TOT_QTY_TO_RECV").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.VchrStat).HasColumnName(@"VCHR_STAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt1).HasColumnName(@"COMMNT_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt2).HasColumnName(@"COMMNT_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt3).HasColumnName(@"COMMNT_3").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.IsAlloc).HasColumnName(@"IS_ALLOC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllocLocGrp).HasColumnName(@"ALLOC_LOC_GRP").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.XfersCreatd).HasColumnName(@"XFERS_CREATD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AdjCnt).HasColumnName(@"ADJ_CNT").HasColumnType("int").IsRequired();
            builder.Property(x => x.LstAdjEventNo).HasColumnName(@"LST_ADJ_EVENT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LstAdjDat).HasColumnName(@"LST_ADJ_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.AdjMiscAmt1).HasColumnName(@"ADJ_MISC_AMT_1").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjMiscAmt2).HasColumnName(@"ADJ_MISC_AMT_2").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjMiscAmt3).HasColumnName(@"ADJ_MISC_AMT_3").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjMiscAmt4).HasColumnName(@"ADJ_MISC_AMT_4").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjMiscAmt5).HasColumnName(@"ADJ_MISC_AMT_5").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjTotMisc).HasColumnName(@"ADJ_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjSubTot).HasColumnName(@"ADJ_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjTot).HasColumnName(@"ADJ_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvrTotWeight).HasColumnName(@"RECVR_TOT_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.RecvrTotCube).HasColumnName(@"RECVR_TOT_CUBE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.TotQtyRecvdInStkUnits).HasColumnName(@"TOT_QTY_RECVD_IN_STK_UNITS").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.AllocMisc1By).HasColumnName(@"ALLOC_MISC_1_BY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllocMisc2By).HasColumnName(@"ALLOC_MISC_2_BY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllocMisc3By).HasColumnName(@"ALLOC_MISC_3_BY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllocMisc4By).HasColumnName(@"ALLOC_MISC_4_BY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllocMisc5By).HasColumnName(@"ALLOC_MISC_5_BY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.IsDropshipRecvr).HasColumnName(@"IS_DROPSHIP_RECVR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DocGuid).HasColumnName(@"DOC_GUID").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.CurncyCod).HasColumnName(@"CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc1CurncyCod).HasColumnName(@"MISC_1_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc2CurncyCod).HasColumnName(@"MISC_2_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc3CurncyCod).HasColumnName(@"MISC_3_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc4CurncyCod).HasColumnName(@"MISC_4_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc5CurncyCod).HasColumnName(@"MISC_5_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RecvrExchRateNumer).HasColumnName(@"RECVR_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrExchRateDenom).HasColumnName(@"RECVR_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrMisc1ExchRateNumer).HasColumnName(@"RECVR_MISC_1_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrMisc1ExchRateDenom).HasColumnName(@"RECVR_MISC_1_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrMisc2ExchRateNumer).HasColumnName(@"RECVR_MISC_2_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrMisc2ExchRateDenom).HasColumnName(@"RECVR_MISC_2_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrMisc3ExchRateNumer).HasColumnName(@"RECVR_MISC_3_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrMisc3ExchRateDenom).HasColumnName(@"RECVR_MISC_3_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrMisc4ExchRateNumer).HasColumnName(@"RECVR_MISC_4_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrMisc4ExchRateDenom).HasColumnName(@"RECVR_MISC_4_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrMisc5ExchRateNumer).HasColumnName(@"RECVR_MISC_5_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrMisc5ExchRateDenom).HasColumnName(@"RECVR_MISC_5_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.RecvrSubTotHome).HasColumnName(@"RECVR_SUB_TOT_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RecvrMiscAmt1Home).HasColumnName(@"RECVR_MISC_AMT_1_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RecvrMiscAmt2Home).HasColumnName(@"RECVR_MISC_AMT_2_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RecvrMiscAmt3Home).HasColumnName(@"RECVR_MISC_AMT_3_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RecvrMiscAmt4Home).HasColumnName(@"RECVR_MISC_AMT_4_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RecvrMiscAmt5Home).HasColumnName(@"RECVR_MISC_AMT_5_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RecvrTotMiscHome).HasColumnName(@"RECVR_TOT_MISC_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RecvrTotHome).HasColumnName(@"RECVR_TOT_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.AdjExchRateNumer).HasColumnName(@"ADJ_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjExchRateDenom).HasColumnName(@"ADJ_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjMisc1ExchRateNumer).HasColumnName(@"ADJ_MISC_1_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjMisc1ExchRateDenom).HasColumnName(@"ADJ_MISC_1_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjMisc2ExchRateNumer).HasColumnName(@"ADJ_MISC_2_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjMisc2ExchRateDenom).HasColumnName(@"ADJ_MISC_2_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjMisc3ExchRateNumer).HasColumnName(@"ADJ_MISC_3_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjMisc3ExchRateDenom).HasColumnName(@"ADJ_MISC_3_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjMisc4ExchRateNumer).HasColumnName(@"ADJ_MISC_4_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjMisc4ExchRateDenom).HasColumnName(@"ADJ_MISC_4_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjMisc5ExchRateNumer).HasColumnName(@"ADJ_MISC_5_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjMisc5ExchRateDenom).HasColumnName(@"ADJ_MISC_5_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjSubTotHome).HasColumnName(@"ADJ_SUB_TOT_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.AdjMiscAmt1Home).HasColumnName(@"ADJ_MISC_AMT_1_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.AdjMiscAmt2Home).HasColumnName(@"ADJ_MISC_AMT_2_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.AdjMiscAmt3Home).HasColumnName(@"ADJ_MISC_AMT_3_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.AdjMiscAmt4Home).HasColumnName(@"ADJ_MISC_AMT_4_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.AdjMiscAmt5Home).HasColumnName(@"ADJ_MISC_AMT_5_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.AdjTotMiscHome).HasColumnName(@"ADJ_TOT_MISC_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.AdjTotHome).HasColumnName(@"ADJ_TOT_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.YourTaxIdNo).HasColumnName(@"YOUR_TAX_ID_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.VendTaxIdNo).HasColumnName(@"VEND_TAX_ID_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.TaxCodNorm).HasColumnName(@"TAX_COD_NORM").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCod).HasColumnName(@"TAX_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCodChngd).HasColumnName(@"TAX_COD_CHNGD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RecvrTaxAmtNormHome).HasColumnName(@"RECVR_TAX_AMT_NORM_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvrTaxAmtNorm).HasColumnName(@"RECVR_TAX_AMT_NORM").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RecvrHasTaxOvrd).HasColumnName(@"RECVR_HAS_TAX_OVRD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RecvrTaxAmtHome).HasColumnName(@"RECVR_TAX_AMT_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvrTaxAmt).HasColumnName(@"RECVR_TAX_AMT").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.AdjTaxAmtNormHome).HasColumnName(@"ADJ_TAX_AMT_NORM_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjTaxAmtNorm).HasColumnName(@"ADJ_TAX_AMT_NORM").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.AdjHasTaxOvrd).HasColumnName(@"ADJ_HAS_TAX_OVRD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AdjTaxAmtHome).HasColumnName(@"ADJ_TAX_AMT_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjTaxAmt).HasColumnName(@"ADJ_TAX_AMT").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.UserTradeinBuybackCustFstNam).HasColumnName(@"USER_TRADEIN_BUYBACK_CUST_FST_NAM").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserTradeinBuybackCustState).HasColumnName(@"USER_TRADEIN_BUYBACK_CUST_STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserTradeinBuybackCustFfl).HasColumnName(@"USER_TRADEIN_BUYBACK_CUST_FFL").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.UserTradeinBuybackCustMidNam).HasColumnName(@"USER_TRADEIN_BUYBACK_CUST_MID_NAM").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.UserTradeinBuybackCustZip).HasColumnName(@"USER_TRADEIN_BUYBACK_CUST_ZIP").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserTradeinBuybackCustAdrs1).HasColumnName(@"USER_TRADEIN_BUYBACK_CUST_ADRS_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.UserTradeinBuybackCustNo).HasColumnName(@"USER_TRADEIN_BUYBACK_CUST_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserTradeinBuybackCustAdrs3).HasColumnName(@"USER_TRADEIN_BUYBACK_CUST_ADRS_3").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.UserTradeinBuybackCustCity).HasColumnName(@"USER_TRADEIN_BUYBACK_CUST_CITY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.UserConsigned).HasColumnName(@"USER_CONSIGNED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserTradeinBuybackCustAdrs2).HasColumnName(@"USER_TRADEIN_BUYBACK_CUST_ADRS_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.UserTradeinBuybackCustLstNam).HasColumnName(@"USER_TRADEIN_BUYBACK_CUST_LST_NAM").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);

            // Foreign keys
            builder.HasOne(a => a.ImLocHist).WithMany(b => b.PoRecvrHists).HasForeignKey(c => c.RecvrLocId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_RECVR_HIST_IM_LOC_HIST");

            builder.HasIndex(x => new { x.VendNo, x.RecvrNo }).HasDatabaseName("PO_RECVR_HIST_X1");
            builder.HasIndex(x => new { x.UsrId, x.RecvrNo }).HasDatabaseName("PO_RECVR_HIST_X2");
            builder.HasIndex(x => new { x.RecvrLocId, x.RecvrNo }).HasDatabaseName("PO_RECVR_HIST_X3");
            builder.HasIndex(x => new { x.EventNo, x.RecvrNo }).HasDatabaseName("PO_RECVR_HIST_X4");
            builder.HasIndex(x => new { x.VendNamUpr, x.RecvrNo }).HasDatabaseName("PO_RECVR_HIST_X5");
            builder.HasIndex(x => new { x.VendFstNam, x.RecvrNo }).HasDatabaseName("PO_RECVR_HIST_X6");
            builder.HasIndex(x => new { x.VendLstNamUpr, x.RecvrNo }).HasDatabaseName("PO_RECVR_HIST_X7");
            builder.HasIndex(x => new { x.RecvrDat, x.RecvrNo }).HasDatabaseName("PO_RECVR_HIST_X8");
            builder.HasIndex(x => x.VchrStat).HasDatabaseName("PO_RECVR_HIST_X9");
        }
    }

}
// </auto-generated>

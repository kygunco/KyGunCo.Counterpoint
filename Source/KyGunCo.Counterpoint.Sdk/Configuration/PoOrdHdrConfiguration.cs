// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_ORD_HDR
    public class PoOrdHdrConfiguration : IEntityTypeConfiguration<PoOrdHdr>
    {
        public void Configure(EntityTypeBuilder<PoOrdHdr> builder)
        {
            builder.ToTable("PO_ORD_HDR", "dbo");
            builder.HasKey(x => x.PoNo).HasName("PK_PO_ORD_HDR").IsClustered();

            builder.Property(x => x.PoNo).HasColumnName(@"PO_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.PreqNo).HasColumnName(@"PREQ_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VendNo).HasColumnName(@"VEND_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.VendNam).HasColumnName(@"VEND_NAM").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.VendNamUpr).HasColumnName(@"VEND_NAM_UPR").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.VendFstNam).HasColumnName(@"VEND_FST_NAM").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VendFstNamUpr).HasColumnName(@"VEND_FST_NAM_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VendLstNam).HasColumnName(@"VEND_LST_NAM").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.VendLstNamUpr).HasColumnName(@"VEND_LST_NAM_UPR").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
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
            builder.Property(x => x.OrdDat).HasColumnName(@"ORD_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DelivDat).HasColumnName(@"DELIV_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.CancelDat).HasColumnName(@"CANCEL_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Buyer).HasColumnName(@"BUYER").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Fob).HasColumnName(@"FOB").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrdSubTot).HasColumnName(@"ORD_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OrdMiscAmt1).HasColumnName(@"ORD_MISC_AMT_1").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OrdMiscAmt2).HasColumnName(@"ORD_MISC_AMT_2").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OrdMiscAmt3).HasColumnName(@"ORD_MISC_AMT_3").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OrdMiscAmt4).HasColumnName(@"ORD_MISC_AMT_4").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OrdMiscAmt5).HasColumnName(@"ORD_MISC_AMT_5").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OrdTotMisc).HasColumnName(@"ORD_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OrdTot).HasColumnName(@"ORD_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.ShipViaCod).HasColumnName(@"SHIP_VIA_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TermsCod).HasColumnName(@"TERMS_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ShipNam).HasColumnName(@"SHIP_NAM").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipNamUpr).HasColumnName(@"SHIP_NAM_UPR").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipAdrs1).HasColumnName(@"SHIP_ADRS_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipAdrs2).HasColumnName(@"SHIP_ADRS_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipAdrs3).HasColumnName(@"SHIP_ADRS_3").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipCity).HasColumnName(@"SHIP_CITY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ShipState).HasColumnName(@"SHIP_STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ShipZipCod).HasColumnName(@"SHIP_ZIP_COD").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ShipCntry).HasColumnName(@"SHIP_CNTRY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ShipPhone).HasColumnName(@"SHIP_PHONE").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.ShipFax).HasColumnName(@"SHIP_FAX").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.ShipContct1).HasColumnName(@"SHIP_CONTCT_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipContct2).HasColumnName(@"SHIP_CONTCT_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.Commnt1).HasColumnName(@"COMMNT_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt2).HasColumnName(@"COMMNT_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt3).HasColumnName(@"COMMNT_3").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.RecvdTotMisc1).HasColumnName(@"RECVD_TOT_MISC_1").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotMisc2).HasColumnName(@"RECVD_TOT_MISC_2").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotMisc3).HasColumnName(@"RECVD_TOT_MISC_3").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotMisc4).HasColumnName(@"RECVD_TOT_MISC_4").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotMisc5).HasColumnName(@"RECVD_TOT_MISC_5").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotMisc).HasColumnName(@"RECVD_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdSubTot).HasColumnName(@"RECVD_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTot).HasColumnName(@"RECVD_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OpnLinCnt).HasColumnName(@"OPN_LIN_CNT").HasColumnType("int").IsRequired();
            builder.Property(x => x.IsAlloc).HasColumnName(@"IS_ALLOC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllocLocGrp).HasColumnName(@"ALLOC_LOC_GRP").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.CancelledBy).HasColumnName(@"CANCELLED_BY").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CancelledOn).HasColumnName(@"CANCELLED_ON").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.IsReissueOfPoNo).HasColumnName(@"IS_REISSUE_OF_PO_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ReissuedOnPreqNo).HasColumnName(@"REISSUED_ON_PREQ_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ReissuedOnPoNo).HasColumnName(@"REISSUED_ON_PO_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.OpnPoTot).HasColumnName(@"OPN_PO_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotWeight).HasColumnName(@"ORD_TOT_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.OrdTotCube).HasColumnName(@"ORD_TOT_CUBE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.OrdQtyInStkUnits).HasColumnName(@"ORD_QTY_IN_STK_UNITS").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.OrigBasePoNo).HasColumnName(@"ORIG_BASE_PO_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.LinCnt).HasColumnName(@"LIN_CNT").HasColumnType("int").IsRequired();
            builder.Property(x => x.IsDropshipPo).HasColumnName(@"IS_DROPSHIP_PO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DocGuid).HasColumnName(@"DOC_GUID").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.PoStat).HasColumnName(@"PO_STAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.CurncyCod).HasColumnName(@"CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc1CurncyCod).HasColumnName(@"MISC_1_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc2CurncyCod).HasColumnName(@"MISC_2_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc3CurncyCod).HasColumnName(@"MISC_3_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc4CurncyCod).HasColumnName(@"MISC_4_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Misc5CurncyCod).HasColumnName(@"MISC_5_CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.OrdExchRateNumer).HasColumnName(@"ORD_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdExchRateDenom).HasColumnName(@"ORD_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdMisc1ExchRateNumer).HasColumnName(@"ORD_MISC_1_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdMisc1ExchRateDenom).HasColumnName(@"ORD_MISC_1_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdMisc2ExchRateNumer).HasColumnName(@"ORD_MISC_2_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdMisc2ExchRateDenom).HasColumnName(@"ORD_MISC_2_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdMisc3ExchRateNumer).HasColumnName(@"ORD_MISC_3_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdMisc3ExchRateDenom).HasColumnName(@"ORD_MISC_3_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdMisc4ExchRateNumer).HasColumnName(@"ORD_MISC_4_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdMisc4ExchRateDenom).HasColumnName(@"ORD_MISC_4_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdMisc5ExchRateNumer).HasColumnName(@"ORD_MISC_5_EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdMisc5ExchRateDenom).HasColumnName(@"ORD_MISC_5_EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.OrdSubTotHome).HasColumnName(@"ORD_SUB_TOT_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.OrdMiscAmt1Home).HasColumnName(@"ORD_MISC_AMT_1_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.OrdMiscAmt2Home).HasColumnName(@"ORD_MISC_AMT_2_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.OrdMiscAmt3Home).HasColumnName(@"ORD_MISC_AMT_3_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.OrdMiscAmt4Home).HasColumnName(@"ORD_MISC_AMT_4_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.OrdMiscAmt5Home).HasColumnName(@"ORD_MISC_AMT_5_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.OrdTotMiscHome).HasColumnName(@"ORD_TOT_MISC_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.OrdTotHome).HasColumnName(@"ORD_TOT_HOME").HasColumnType("decimal(38,9)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RecvdSubTotHome).HasColumnName(@"RECVD_SUB_TOT_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotMisc1Home).HasColumnName(@"RECVD_TOT_MISC_1_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotMisc2Home).HasColumnName(@"RECVD_TOT_MISC_2_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotMisc3Home).HasColumnName(@"RECVD_TOT_MISC_3_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotMisc4Home).HasColumnName(@"RECVD_TOT_MISC_4_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotMisc5Home).HasColumnName(@"RECVD_TOT_MISC_5_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotMiscHome).HasColumnName(@"RECVD_TOT_MISC_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTotHome).HasColumnName(@"RECVD_TOT_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.YourTaxIdNo).HasColumnName(@"YOUR_TAX_ID_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.VendTaxIdNo).HasColumnName(@"VEND_TAX_ID_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.TaxCodNorm).HasColumnName(@"TAX_COD_NORM").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCod).HasColumnName(@"TAX_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCodChngd).HasColumnName(@"TAX_COD_CHNGD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.OrdTaxAmtNormHome).HasColumnName(@"ORD_TAX_AMT_NORM_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OrdTaxAmtNorm).HasColumnName(@"ORD_TAX_AMT_NORM").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.OrdHasTaxOvrd).HasColumnName(@"ORD_HAS_TAX_OVRD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrdTaxAmtHome).HasColumnName(@"ORD_TAX_AMT_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OrdTaxAmt).HasColumnName(@"ORD_TAX_AMT").HasColumnType("decimal(15,4)").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.RecvdTaxAmtHome).HasColumnName(@"RECVD_TAX_AMT_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RecvdTaxAmt).HasColumnName(@"RECVD_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.UserAutoEmailed).HasColumnName(@"USER_AUTO_EMAILED").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserKgcVendOrdNo).HasColumnName(@"USER_KGC_VEND_ORD_NO").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.UserKgcProcess).HasColumnName(@"USER_KGC_PROCESS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);

            // Foreign keys
            builder.HasOne(a => a.ImLoc).WithMany(b => b.PoOrdHdrs).HasForeignKey(c => c.LocId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_ORD_HDR_IM_LOC");

            builder.HasIndex(x => x.OpnLinCnt).HasDatabaseName("IX_PO_ORD_HDR_OPN_LIN_CNT");
            builder.HasIndex(x => new { x.Buyer, x.PoNo }).HasDatabaseName("PO_ORD_HDR_X1");
            builder.HasIndex(x => new { x.EventNo, x.PoNo }).HasDatabaseName("PO_ORD_HDR_X10");
            builder.HasIndex(x => new { x.VendNo, x.PoNo }).HasDatabaseName("PO_ORD_HDR_X2");
            builder.HasIndex(x => new { x.VendNamUpr, x.PoNo }).HasDatabaseName("PO_ORD_HDR_X3");
            builder.HasIndex(x => new { x.VendFstNamUpr, x.PoNo }).HasDatabaseName("PO_ORD_HDR_X4");
            builder.HasIndex(x => new { x.VendLstNamUpr, x.PoNo }).HasDatabaseName("PO_ORD_HDR_X5");
            builder.HasIndex(x => new { x.DelivDat, x.PoNo }).HasDatabaseName("PO_ORD_HDR_X6");
            builder.HasIndex(x => new { x.LocId, x.PoNo }).HasDatabaseName("PO_ORD_HDR_X7");
            builder.HasIndex(x => new { x.PreqNo, x.PoNo }).HasDatabaseName("PO_ORD_HDR_X8");
            builder.HasIndex(x => new { x.ShipNamUpr, x.PoNo }).HasDatabaseName("PO_ORD_HDR_X9");
        }
    }

}
// </auto-generated>

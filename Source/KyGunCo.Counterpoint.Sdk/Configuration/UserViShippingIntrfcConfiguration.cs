// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_VI_SHIPPING_INTRFC
    public class UserViShippingIntrfcConfiguration : IEntityTypeConfiguration<UserViShippingIntrfc>
    {
        public void Configure(EntityTypeBuilder<UserViShippingIntrfc> builder)
        {
            builder.ToView("USER_VI_SHIPPING_INTRFC", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DocGuid).HasColumnName(@"DOC_GUID").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.TktDt).HasColumnName(@"TKT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.DocTyp).HasColumnName(@"DOC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TktTyp).HasColumnName(@"TKT_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SlsRep).HasColumnName(@"SLS_REP").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StkLocId).HasColumnName(@"STK_LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PrcLocId).HasColumnName(@"PRC_LOC_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.BillToContactId).HasColumnName(@"BILL_TO_CONTACT_ID").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.ShipToContactId).HasColumnName(@"SHIP_TO_CONTACT_ID").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.ShipViaCod).HasColumnName(@"SHIP_VIA_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ShipZoneCod).HasColumnName(@"SHIP_ZONE_COD").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ShipDat).HasColumnName(@"SHIP_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.NormTaxCod).HasColumnName(@"NORM_TAX_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCod).HasColumnName(@"TAX_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCodChngd).HasColumnName(@"TAX_COD_CHNGD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxExemptNo).HasColumnName(@"TAX_EXEMPT_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.TaxOvrdReas).HasColumnName(@"TAX_OVRD_REAS").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CustPoNo).HasColumnName(@"CUST_PO_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.SalLins).HasColumnName(@"SAL_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SalLinTot).HasColumnName(@"SAL_LIN_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RetLins).HasColumnName(@"RET_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.RetLinTot).HasColumnName(@"RET_LIN_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.GfcLins).HasColumnName(@"GFC_LINS").HasColumnType("int").IsRequired();
            builder.Property(x => x.SvcLins).HasColumnName(@"SVC_LINS").HasColumnType("int").IsRequired();
            builder.Property(x => x.SalHasTaxOvrd).HasColumnName(@"SAL_HAS_TAX_OVRD").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SalTaxOvrdLins).HasColumnName(@"SAL_TAX_OVRD_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SalGrossSubTot).HasColumnName(@"SAL_GROSS_SUB_TOT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.SalSubTot).HasColumnName(@"SAL_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotHdrDiscntblAmt).HasColumnName(@"SAL_TOT_HDR_DISCNTBL_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotHdrDisc).HasColumnName(@"SAL_TOT_HDR_DISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotLinDisc).HasColumnName(@"SAL_TOT_LIN_DISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotDisc).HasColumnName(@"SAL_TOT_DISC").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.SalTotEstCost).HasColumnName(@"SAL_TOT_EST_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotExtCost).HasColumnName(@"SAL_TOT_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotWeight).HasColumnName(@"SAL_TOT_WEIGHT").HasColumnType("numeric(19,4)").IsRequired(false);
            builder.Property(x => x.SalTotCube).HasColumnName(@"SAL_TOT_CUBE").HasColumnType("numeric(19,4)").IsRequired(false);
            builder.Property(x => x.SalTotGfcAmt).HasColumnName(@"SAL_TOT_GFC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotSvcAmt).HasColumnName(@"SAL_TOT_SVC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotMisc).HasColumnName(@"SAL_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalNormTaxAmt).HasColumnName(@"SAL_NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTaxAmt).HasColumnName(@"SAL_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotTnd).HasColumnName(@"SAL_TOT_TND").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalTotChng).HasColumnName(@"SAL_TOT_CHNG").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalNetTnd).HasColumnName(@"SAL_NET_TND").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.SalTot).HasColumnName(@"SAL_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalAmtDue).HasColumnName(@"SAL_AMT_DUE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdLins).HasColumnName(@"ORD_LINS").HasColumnType("int").IsRequired();
            builder.Property(x => x.BoLins).HasColumnName(@"BO_LINS").HasColumnType("int").IsRequired();
            builder.Property(x => x.SoLins).HasColumnName(@"SO_LINS").HasColumnType("int").IsRequired();
            builder.Property(x => x.DsLins).HasColumnName(@"DS_LINS").HasColumnType("int").IsRequired();
            builder.Property(x => x.HasEntdLins).HasColumnName(@"HAS_ENTD_LINS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.HasPckdLins).HasColumnName(@"HAS_PCKD_LINS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.HasPckvrfdLins).HasColumnName(@"HAS_PCKVRFD_LINS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.HasInvcdLins).HasColumnName(@"HAS_INVCD_LINS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.HasRlsdLins).HasColumnName(@"HAS_RLSD_LINS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrdHasTaxOvrd).HasColumnName(@"ORD_HAS_TAX_OVRD").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrdTaxOvrdLins).HasColumnName(@"ORD_TAX_OVRD_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.OrdGrossSubTot).HasColumnName(@"ORD_GROSS_SUB_TOT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.OrdSubTot).HasColumnName(@"ORD_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotHdrDiscntblAmt).HasColumnName(@"ORD_TOT_HDR_DISCNTBL_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotHdrDisc).HasColumnName(@"ORD_TOT_HDR_DISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotLinDisc).HasColumnName(@"ORD_TOT_LIN_DISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotDisc).HasColumnName(@"ORD_TOT_DISC").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.OrdTotEstCost).HasColumnName(@"ORD_TOT_EST_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotExtCost).HasColumnName(@"ORD_TOT_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotWeight).HasColumnName(@"ORD_TOT_WEIGHT").HasColumnType("numeric(19,4)").IsRequired(false);
            builder.Property(x => x.OrdTotCube).HasColumnName(@"ORD_TOT_CUBE").HasColumnType("numeric(19,4)").IsRequired(false);
            builder.Property(x => x.OrdTotMisc).HasColumnName(@"ORD_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdNormTaxAmt).HasColumnName(@"ORD_NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTaxAmt).HasColumnName(@"ORD_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTaxAmtShipped).HasColumnName(@"ORD_TAX_AMT_SHIPPED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTot).HasColumnName(@"ORD_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdInitialMinDue).HasColumnName(@"ORD_INITIAL_MIN_DUE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotTnd).HasColumnName(@"ORD_TOT_TND").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdTotChng).HasColumnName(@"ORD_TOT_CHNG").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdNetTnd).HasColumnName(@"ORD_NET_TND").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.OrdAmtDue).HasColumnName(@"ORD_AMT_DUE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToRelGrossSubTot).HasColumnName(@"TO_REL_GROSS_SUB_TOT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.ToRelSubTot).HasColumnName(@"TO_REL_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToRelTotHdrDiscntblAmt).HasColumnName(@"TO_REL_TOT_HDR_DISCNTBL_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToRelTotHdrDisc).HasColumnName(@"TO_REL_TOT_HDR_DISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToRelTotLinDisc).HasColumnName(@"TO_REL_TOT_LIN_DISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToRelTotDisc).HasColumnName(@"TO_REL_TOT_DISC").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.ToRelTotEstCost).HasColumnName(@"TO_REL_TOT_EST_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToRelTotWeight).HasColumnName(@"TO_REL_TOT_WEIGHT").HasColumnType("numeric(19,4)").IsRequired(false);
            builder.Property(x => x.ToRelTotCube).HasColumnName(@"TO_REL_TOT_CUBE").HasColumnType("numeric(19,4)").IsRequired(false);
            builder.Property(x => x.ToRelTotMisc).HasColumnName(@"TO_REL_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToRelNormTaxAmt).HasColumnName(@"TO_REL_NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToRelTaxAmt).HasColumnName(@"TO_REL_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToRelTaxAmtShipped).HasColumnName(@"TO_REL_TAX_AMT_SHIPPED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToRelTot).HasColumnName(@"TO_REL_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveGrossSubTot).HasColumnName(@"TO_LEAVE_GROSS_SUB_TOT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveSubTot).HasColumnName(@"TO_LEAVE_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveTotHdrDiscntblAmt).HasColumnName(@"TO_LEAVE_TOT_HDR_DISCNTBL_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveTotHdrDisc).HasColumnName(@"TO_LEAVE_TOT_HDR_DISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveTotLinDisc).HasColumnName(@"TO_LEAVE_TOT_LIN_DISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveTotDisc).HasColumnName(@"TO_LEAVE_TOT_DISC").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveTotEstCost).HasColumnName(@"TO_LEAVE_TOT_EST_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveTotWeight).HasColumnName(@"TO_LEAVE_TOT_WEIGHT").HasColumnType("numeric(19,4)").IsRequired(false);
            builder.Property(x => x.ToLeaveTotCube).HasColumnName(@"TO_LEAVE_TOT_CUBE").HasColumnType("numeric(19,4)").IsRequired(false);
            builder.Property(x => x.ToLeaveTotMisc).HasColumnName(@"TO_LEAVE_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveNormTaxAmt).HasColumnName(@"TO_LEAVE_NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveTaxAmt).HasColumnName(@"TO_LEAVE_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveTaxAmtShipped).HasColumnName(@"TO_LEAVE_TAX_AMT_SHIPPED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ToLeaveTot).HasColumnName(@"TO_LEAVE_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdMiscTyp1).HasColumnName(@"ORD_MISC_TYP_1").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrdMiscAmt1).HasColumnName(@"ORD_MISC_AMT_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdMiscPct1).HasColumnName(@"ORD_MISC_PCT_1").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.OrdMiscAmt1Shipped).HasColumnName(@"ORD_MISC_AMT_1_SHIPPED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdMiscTyp2).HasColumnName(@"ORD_MISC_TYP_2").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrdMiscAmt2).HasColumnName(@"ORD_MISC_AMT_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdMiscPct2).HasColumnName(@"ORD_MISC_PCT_2").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.OrdMiscAmt2Shipped).HasColumnName(@"ORD_MISC_AMT_2_SHIPPED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdMiscTyp3).HasColumnName(@"ORD_MISC_TYP_3").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrdMiscAmt3).HasColumnName(@"ORD_MISC_AMT_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdMiscPct3).HasColumnName(@"ORD_MISC_PCT_3").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.OrdMiscAmt3Shipped).HasColumnName(@"ORD_MISC_AMT_3_SHIPPED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdMiscTyp4).HasColumnName(@"ORD_MISC_TYP_4").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrdMiscAmt4).HasColumnName(@"ORD_MISC_AMT_4").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdMiscPct4).HasColumnName(@"ORD_MISC_PCT_4").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.OrdMiscAmt4Shipped).HasColumnName(@"ORD_MISC_AMT_4_SHIPPED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdMiscTyp5).HasColumnName(@"ORD_MISC_TYP_5").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrdMiscAmt5).HasColumnName(@"ORD_MISC_AMT_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdMiscPct5).HasColumnName(@"ORD_MISC_PCT_5").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.OrdMiscAmt5Shipped).HasColumnName(@"ORD_MISC_AMT_5_SHIPPED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.Lins).HasColumnName(@"LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.TaxOvrdLins).HasColumnName(@"TAX_OVRD_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.GrossSubTot).HasColumnName(@"GROSS_SUB_TOT").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.SubTot).HasColumnName(@"SUB_TOT").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotHdrDiscntblAmt).HasColumnName(@"TOT_HDR_DISCNTBL_AMT").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotHdrDisc).HasColumnName(@"TOT_HDR_DISC").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotLinDisc).HasColumnName(@"TOT_LIN_DISC").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotDisc).HasColumnName(@"TOT_DISC").HasColumnType("decimal(20,2)").IsRequired(false);
            builder.Property(x => x.TotEstCost).HasColumnName(@"TOT_EST_COST").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotExtCost).HasColumnName(@"TOT_EXT_COST").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotWeight).HasColumnName(@"TOT_WEIGHT").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.TotCube).HasColumnName(@"TOT_CUBE").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.TotMisc).HasColumnName(@"TOT_MISC").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.NormTaxAmt).HasColumnName(@"NORM_TAX_AMT").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TaxAmt).HasColumnName(@"TAX_AMT").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.Tot).HasColumnName(@"TOT").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotTnd).HasColumnName(@"TOT_TND").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.TotChng).HasColumnName(@"TOT_CHNG").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.NetTnd).HasColumnName(@"NET_TND").HasColumnType("decimal(18,2)").IsRequired(false);
            builder.Property(x => x.AmtDue).HasColumnName(@"AMT_DUE").HasColumnType("decimal(17,2)").IsRequired(false);
            builder.Property(x => x.LstOrdActiv).HasColumnName(@"LST_ORD_ACTIV").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstLwyActiv).HasColumnName(@"LST_LWY_ACTIV").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DocAsTktSeqNo).HasColumnName(@"DOC_AS_TKT_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DocStat).HasColumnName(@"DOC_STAT").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DocCancelDepRefund).HasColumnName(@"DOC_CANCEL_DEP_REFUND").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocCancelDepForf).HasColumnName(@"DOC_CANCEL_DEP_FORF").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocCancelDepTot).HasColumnName(@"DOC_CANCEL_DEP_TOT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.DocDepReceived).HasColumnName(@"DOC_DEP_RECEIVED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocDepApplied).HasColumnName(@"DOC_DEP_APPLIED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocDepRefunded).HasColumnName(@"DOC_DEP_REFUNDED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DocDepForfeit).HasColumnName(@"DOC_DEP_FORFEIT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstDocEditDt).HasColumnName(@"LST_DOC_EDIT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocEditUsrId).HasColumnName(@"LST_DOC_EDIT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstDocPrtDt).HasColumnName(@"LST_DOC_PRT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocPrtUsrId).HasColumnName(@"LST_DOC_PRT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstDocPickDt).HasColumnName(@"LST_DOC_PICK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocInvcdDt).HasColumnName(@"LST_DOC_INVCD_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocInvcdUsrId).HasColumnName(@"LST_DOC_INVCD_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstDocPckvrfdDt).HasColumnName(@"LST_DOC_PCKVRFD_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocPckvrfdUsrId).HasColumnName(@"LST_DOC_PCKVRFD_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.IsPicked).HasColumnName(@"IS_PICKED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstDocRelDt).HasColumnName(@"LST_DOC_REL_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocRelUsrId).HasColumnName(@"LST_DOC_REL_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.IsSuspended).HasColumnName(@"IS_SUSPENDED").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstDocSuspendedDt).HasColumnName(@"LST_DOC_SUSPENDED_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstDocSuspendedUsrId).HasColumnName(@"LST_DOC_SUSPENDED_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BillNam).HasColumnName(@"BILL_NAM").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.BillNamUpr).HasColumnName(@"BILL_NAM_UPR").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.BillFstNam).HasColumnName(@"BILL_FST_NAM").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.BillFstNamUpr).HasColumnName(@"BILL_FST_NAM_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.BillLstNam).HasColumnName(@"BILL_LST_NAM").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.BillLstNamUpr).HasColumnName(@"BILL_LST_NAM_UPR").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.BillSalutation).HasColumnName(@"BILL_SALUTATION").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BillAdrs1).HasColumnName(@"BILL_ADRS_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.BillAdrs2).HasColumnName(@"BILL_ADRS_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.BillAdrs3).HasColumnName(@"BILL_ADRS_3").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.BillCity).HasColumnName(@"BILL_CITY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.BillState).HasColumnName(@"BILL_STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BillZipCod).HasColumnName(@"BILL_ZIP_COD").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.BillCntry).HasColumnName(@"BILL_CNTRY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.BillPhone1).HasColumnName(@"BILL_PHONE_1").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.BillPhone2).HasColumnName(@"BILL_PHONE_2").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.BillNamTyp).HasColumnName(@"BILL_NAM_TYP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.BillEmailAdrs1).HasColumnName(@"BILL_EMAIL_ADRS_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.BillEmailAdrs2).HasColumnName(@"BILL_EMAIL_ADRS_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.BillContct1).HasColumnName(@"BILL_CONTCT_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.BillContct2).HasColumnName(@"BILL_CONTCT_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.BillFax1).HasColumnName(@"BILL_FAX_1").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.BillFax2).HasColumnName(@"BILL_FAX_2").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.BillFstLstNam).HasColumnName(@"BILL_FST_LST_NAM").HasColumnType("varchar(42)").IsRequired(false).IsUnicode(false).HasMaxLength(42);
            builder.Property(x => x.ShipNam).HasColumnName(@"SHIP_NAM").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipFstNam).HasColumnName(@"SHIP_FST_NAM").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ShipLstNam).HasColumnName(@"SHIP_LST_NAM").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.ShipSalutation).HasColumnName(@"SHIP_SALUTATION").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ShipAdrs1).HasColumnName(@"SHIP_ADRS_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipAdrs2).HasColumnName(@"SHIP_ADRS_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipAdrs3).HasColumnName(@"SHIP_ADRS_3").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipCity).HasColumnName(@"SHIP_CITY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ShipState).HasColumnName(@"SHIP_STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ShipZipCod).HasColumnName(@"SHIP_ZIP_COD").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ShipCntry).HasColumnName(@"SHIP_CNTRY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ShipPhone1).HasColumnName(@"SHIP_PHONE_1").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.ShipPhone2).HasColumnName(@"SHIP_PHONE_2").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.ShipAdrsId).HasColumnName(@"SHIP_ADRS_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ShipNamTyp).HasColumnName(@"SHIP_NAM_TYP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ShipEmailAdrs1).HasColumnName(@"SHIP_EMAIL_ADRS_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ShipEmailAdrs2).HasColumnName(@"SHIP_EMAIL_ADRS_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ShipContct1).HasColumnName(@"SHIP_CONTCT_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipContct2).HasColumnName(@"SHIP_CONTCT_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.ShipFax1).HasColumnName(@"SHIP_FAX_1").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.ShipFax2).HasColumnName(@"SHIP_FAX_2").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.ShipFstLstNam).HasColumnName(@"SHIP_FST_LST_NAM").HasColumnType("varchar(42)").IsRequired(false).IsUnicode(false).HasMaxLength(42);
            builder.Property(x => x.ProfCod1).HasColumnName(@"PROF_COD_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod2).HasColumnName(@"PROF_COD_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod3).HasColumnName(@"PROF_COD_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod4).HasColumnName(@"PROF_COD_4").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod5).HasColumnName(@"PROF_COD_5").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfNo1).HasColumnName(@"PROF_NO_1").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.ProfNo2).HasColumnName(@"PROF_NO_2").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.ProfNo3).HasColumnName(@"PROF_NO_3").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.ProfNo4).HasColumnName(@"PROF_NO_4").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.ProfNo5).HasColumnName(@"PROF_NO_5").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.ProfAlpha1).HasColumnName(@"PROF_ALPHA_1").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha2).HasColumnName(@"PROF_ALPHA_2").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha3).HasColumnName(@"PROF_ALPHA_3").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha4).HasColumnName(@"PROF_ALPHA_4").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha5).HasColumnName(@"PROF_ALPHA_5").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfDat1).HasColumnName(@"PROF_DAT_1").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat2).HasColumnName(@"PROF_DAT_2").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat3).HasColumnName(@"PROF_DAT_3").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat4).HasColumnName(@"PROF_DAT_4").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat5).HasColumnName(@"PROF_DAT_5").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.IsOrder).HasColumnName(@"IS_ORDER").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DocIdExt).HasColumnName(@"DOC_ID_EXT").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.UserIntrfacdToShip).HasColumnName(@"USER_INTRFACD_TO_SHIP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserShipResp).HasColumnName(@"USER_SHIP_RESP").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.UserShipRespStat).HasColumnName(@"USER_SHIP_RESP_STAT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.RelTot).HasColumnName(@"REL_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RelTaxAmt).HasColumnName(@"REL_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.RelTotMisc).HasColumnName(@"REL_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
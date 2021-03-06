// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PS_ORD_HIST
    public class ViPsOrdHist
    {
        public DateTime BusDat { get; set; } // BUS_DAT
        public long DocId { get; set; } // DOC_ID
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public Guid DocGuid { get; set; } // DOC_GUID
        public DateTime? TktDat { get; set; } // TKT_DAT
        public DateTime? TktTim { get; set; } // TKT_TIM
        public DateTime? TktDt { get; set; } // TKT_DT
        public DateTime PostDat { get; set; } // POST_DAT
        public string DocTyp { get; set; } // DOC_TYP (length: 1)
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string SlsRep { get; set; } // SLS_REP (length: 10)
        public string StkLocId { get; set; } // STK_LOC_ID (length: 10)
        public string PrcLocId { get; set; } // PRC_LOC_ID (length: 10)
        public string PftCtr { get; set; } // PFT_CTR (length: 20)
        public string CustNo { get; set; } // CUST_NO (length: 15)
        public byte? BillToContactId { get; set; } // BILL_TO_CONTACT_ID
        public byte? ShipToContactId { get; set; } // SHIP_TO_CONTACT_ID
        public string TermsCod { get; set; } // TERMS_COD (length: 10)
        public string ShipViaCod { get; set; } // SHIP_VIA_COD (length: 10)
        public string ShipZoneCod { get; set; } // SHIP_ZONE_COD (length: 30)
        public DateTime? ShipDat { get; set; } // SHIP_DAT
        public string NormTaxCod { get; set; } // NORM_TAX_COD (length: 10)
        public string TaxCod { get; set; } // TAX_COD (length: 10)
        public string TaxCodChngd { get; set; } // TAX_COD_CHNGD (length: 1)
        public string TaxExemptNo { get; set; } // TAX_EXEMPT_NO (length: 30)
        public string TaxOvrdReas { get; set; } // TAX_OVRD_REAS (length: 10)
        public string CustPoNo { get; set; } // CUST_PO_NO (length: 20)
        public string LstFrmGrpPrtd { get; set; } // LST_FRM_GRP_PRTD (length: 10)
        public string LstFrmPrtd { get; set; } // LST_FRM_PRTD (length: 100)
        public int? TimesPrtd { get; set; } // TIMES_PRTD
        public string Ref { get; set; } // REF (length: 50)
        public int? HdrDiscs { get; set; } // HDR_DISCS
        public string HdrDiscCod { get; set; } // HDR_DISC_COD (length: 10)
        public int OrdLins { get; set; } // ORD_LINS
        public int BoLins { get; set; } // BO_LINS
        public int SoLins { get; set; } // SO_LINS
        public int DsLins { get; set; } // DS_LINS
        public string OrdHasTaxOvrd { get; set; } // ORD_HAS_TAX_OVRD (length: 1)
        public int OrdTaxOvrdLins { get; set; } // ORD_TAX_OVRD_LINS
        public decimal? OrdGrossSubTot { get; set; } // ORD_GROSS_SUB_TOT
        public decimal OrdSubTot { get; set; } // ORD_SUB_TOT
        public decimal OrdTotHdrDisc { get; set; } // ORD_TOT_HDR_DISC
        public decimal OrdTotLinDisc { get; set; } // ORD_TOT_LIN_DISC
        public decimal? OrdTotDisc { get; set; } // ORD_TOT_DISC
        public decimal? OrdTotEstCost { get; set; } // ORD_TOT_EST_COST
        public decimal OrdTotWeight { get; set; } // ORD_TOT_WEIGHT
        public decimal OrdTotCube { get; set; } // ORD_TOT_CUBE
        public decimal OrdTotMisc { get; set; } // ORD_TOT_MISC
        public decimal OrdNormTaxAmt { get; set; } // ORD_NORM_TAX_AMT
        public decimal OrdTaxAmt { get; set; } // ORD_TAX_AMT
        public decimal OrdTaxAmtShipped { get; set; } // ORD_TAX_AMT_SHIPPED
        public decimal OrdTot { get; set; } // ORD_TOT
        public decimal OrdInitialMinDue { get; set; } // ORD_INITIAL_MIN_DUE
        public decimal OrdTotTnd { get; set; } // ORD_TOT_TND
        public decimal OrdTotChng { get; set; } // ORD_TOT_CHNG
        public decimal? OrdNetTnd { get; set; } // ORD_NET_TND
        public decimal OrdAmtDue { get; set; } // ORD_AMT_DUE
        public string OrdMiscTyp1 { get; set; } // ORD_MISC_TYP_1 (length: 1)
        public decimal? OrdMiscAmt1 { get; set; } // ORD_MISC_AMT_1
        public decimal? OrdMiscPct1 { get; set; } // ORD_MISC_PCT_1
        public decimal? OrdMiscAmt1Shipped { get; set; } // ORD_MISC_AMT_1_SHIPPED
        public string OrdMiscTyp2 { get; set; } // ORD_MISC_TYP_2 (length: 1)
        public decimal? OrdMiscAmt2 { get; set; } // ORD_MISC_AMT_2
        public decimal? OrdMiscPct2 { get; set; } // ORD_MISC_PCT_2
        public decimal? OrdMiscAmt2Shipped { get; set; } // ORD_MISC_AMT_2_SHIPPED
        public string OrdMiscTyp3 { get; set; } // ORD_MISC_TYP_3 (length: 1)
        public decimal? OrdMiscAmt3 { get; set; } // ORD_MISC_AMT_3
        public decimal? OrdMiscPct3 { get; set; } // ORD_MISC_PCT_3
        public decimal? OrdMiscAmt3Shipped { get; set; } // ORD_MISC_AMT_3_SHIPPED
        public string OrdMiscTyp4 { get; set; } // ORD_MISC_TYP_4 (length: 1)
        public decimal? OrdMiscAmt4 { get; set; } // ORD_MISC_AMT_4
        public decimal? OrdMiscPct4 { get; set; } // ORD_MISC_PCT_4
        public decimal? OrdMiscAmt4Shipped { get; set; } // ORD_MISC_AMT_4_SHIPPED
        public string OrdMiscTyp5 { get; set; } // ORD_MISC_TYP_5 (length: 1)
        public decimal? OrdMiscAmt5 { get; set; } // ORD_MISC_AMT_5
        public decimal? OrdMiscPct5 { get; set; } // ORD_MISC_PCT_5
        public decimal? OrdMiscAmt5Shipped { get; set; } // ORD_MISC_AMT_5_SHIPPED
        public decimal? OrdMiscTaxAmtAlloc1 { get; set; } // ORD_MISC_TAX_AMT_ALLOC_1
        public decimal? OrdMiscNormTaxAmtAlloc1 { get; set; } // ORD_MISC_NORM_TAX_AMT_ALLOC_1
        public decimal? OrdMiscTaxAmtAlloc2 { get; set; } // ORD_MISC_TAX_AMT_ALLOC_2
        public decimal? OrdMiscNormTaxAmtAlloc2 { get; set; } // ORD_MISC_NORM_TAX_AMT_ALLOC_2
        public decimal? OrdMiscTaxAmtAlloc3 { get; set; } // ORD_MISC_TAX_AMT_ALLOC_3
        public decimal? OrdMiscNormTaxAmtAlloc3 { get; set; } // ORD_MISC_NORM_TAX_AMT_ALLOC_3
        public decimal? OrdMiscTaxAmtAlloc4 { get; set; } // ORD_MISC_TAX_AMT_ALLOC_4
        public decimal? OrdMiscNormTaxAmtAlloc4 { get; set; } // ORD_MISC_NORM_TAX_AMT_ALLOC_4
        public decimal? OrdMiscTaxAmtAlloc5 { get; set; } // ORD_MISC_TAX_AMT_ALLOC_5
        public decimal? OrdMiscNormTaxAmtAlloc5 { get; set; } // ORD_MISC_NORM_TAX_AMT_ALLOC_5
        public int? Lins { get; set; } // LINS
        public int TaxOvrdLins { get; set; } // TAX_OVRD_LINS
        public decimal? GrossSubTot { get; set; } // GROSS_SUB_TOT
        public decimal SubTot { get; set; } // SUB_TOT
        public decimal TotHdrDisc { get; set; } // TOT_HDR_DISC
        public decimal TotLinDisc { get; set; } // TOT_LIN_DISC
        public decimal? TotDisc { get; set; } // TOT_DISC
        public decimal? TotEstCost { get; set; } // TOT_EST_COST
        public decimal TotWeight { get; set; } // TOT_WEIGHT
        public decimal TotCube { get; set; } // TOT_CUBE
        public decimal TotMisc { get; set; } // TOT_MISC
        public decimal NormTaxAmt { get; set; } // NORM_TAX_AMT
        public decimal TaxAmt { get; set; } // TAX_AMT
        public decimal TotTnd { get; set; } // TOT_TND
        public decimal TotChng { get; set; } // TOT_CHNG
        public decimal? NetTnd { get; set; } // NET_TND
        public decimal Tot { get; set; } // TOT
        public decimal AmtDue { get; set; } // AMT_DUE
        public decimal? MiscAmt1 { get; set; } // MISC_AMT_1
        public decimal? MiscAmt2 { get; set; } // MISC_AMT_2
        public decimal? MiscAmt3 { get; set; } // MISC_AMT_3
        public decimal? MiscAmt4 { get; set; } // MISC_AMT_4
        public decimal? MiscAmt5 { get; set; } // MISC_AMT_5
        public decimal? MiscPct1 { get; set; } // MISC_PCT_1
        public decimal? MiscPct2 { get; set; } // MISC_PCT_2
        public decimal? MiscPct3 { get; set; } // MISC_PCT_3
        public decimal? MiscPct4 { get; set; } // MISC_PCT_4
        public decimal? MiscPct5 { get; set; } // MISC_PCT_5
        public decimal? MiscTaxAmtAlloc1 { get; set; } // MISC_TAX_AMT_ALLOC_1
        public decimal? MiscNormTaxAmtAlloc1 { get; set; } // MISC_NORM_TAX_AMT_ALLOC_1
        public decimal? MiscTaxAmtAlloc2 { get; set; } // MISC_TAX_AMT_ALLOC_2
        public decimal? MiscNormTaxAmtAlloc2 { get; set; } // MISC_NORM_TAX_AMT_ALLOC_2
        public decimal? MiscTaxAmtAlloc3 { get; set; } // MISC_TAX_AMT_ALLOC_3
        public decimal? MiscNormTaxAmtAlloc3 { get; set; } // MISC_NORM_TAX_AMT_ALLOC_3
        public decimal? MiscTaxAmtAlloc4 { get; set; } // MISC_TAX_AMT_ALLOC_4
        public decimal? MiscNormTaxAmtAlloc4 { get; set; } // MISC_NORM_TAX_AMT_ALLOC_4
        public decimal? MiscTaxAmtAlloc5 { get; set; } // MISC_TAX_AMT_ALLOC_5
        public decimal? MiscNormTaxAmtAlloc5 { get; set; } // MISC_NORM_TAX_AMT_ALLOC_5
        public string LstOrdActiv { get; set; } // LST_ORD_ACTIV (length: 1)
        public int? DocAsTktSeqNo { get; set; } // DOC_AS_TKT_SEQ_NO
        public string DocStat { get; set; } // DOC_STAT (length: 1)
        public decimal? DocCancelDepRefund { get; set; } // DOC_CANCEL_DEP_REFUND
        public decimal? DocCancelDepForf { get; set; } // DOC_CANCEL_DEP_FORF
        public decimal? DocCancelDepTot { get; set; } // DOC_CANCEL_DEP_TOT
        public decimal? DocDepReceived { get; set; } // DOC_DEP_RECEIVED
        public decimal? DocDepApplied { get; set; } // DOC_DEP_APPLIED
        public decimal? DocDepRefunded { get; set; } // DOC_DEP_REFUNDED
        public decimal? DocDepForfeit { get; set; } // DOC_DEP_FORFEIT
        public DateTime? LstDocEditDt { get; set; } // LST_DOC_EDIT_DT
        public string LstDocEditUsrId { get; set; } // LST_DOC_EDIT_USR_ID (length: 10)
        public DateTime? LstDocPrtDt { get; set; } // LST_DOC_PRT_DT
        public string LstDocPrtUsrId { get; set; } // LST_DOC_PRT_USR_ID (length: 10)
        public DateTime? LstDocPickDt { get; set; } // LST_DOC_PICK_DT
        public string LstDocPickUsrId { get; set; } // LST_DOC_PICK_USR_ID (length: 10)
        public DateTime? LstDocRelDt { get; set; } // LST_DOC_REL_DT
        public string LstDocRelUsrId { get; set; } // LST_DOC_REL_USR_ID (length: 10)
        public string IsSuspended { get; set; } // IS_SUSPENDED (length: 1)
        public DateTime? LstDocSuspendedDt { get; set; } // LST_DOC_SUSPENDED_DT
        public string LstDocSuspendedUsrId { get; set; } // LST_DOC_SUSPENDED_USR_ID (length: 10)
        public string PreqWrkgrpId { get; set; } // PREQ_WRKGRP_ID (length: 15)
        public string OrigQuotStrId { get; set; } // ORIG_QUOT_STR_ID (length: 10)
        public string OrigQuotStaId { get; set; } // ORIG_QUOT_STA_ID (length: 10)
        public string OrigQuotNo { get; set; } // ORIG_QUOT_NO (length: 15)
        public string OrigHoldStrId { get; set; } // ORIG_HOLD_STR_ID (length: 10)
        public string OrigHoldStaId { get; set; } // ORIG_HOLD_STA_ID (length: 10)
        public string OrigHoldNo { get; set; } // ORIG_HOLD_NO (length: 15)
        public int? EcStrId { get; set; } // EC_STR_ID
        public string EcImpEventNo { get; set; } // EC_IMP_EVENT_NO (length: 15)
        public DateTime? EcLstPubDt { get; set; } // EC_LST_PUB_DT
        public string EcLstPubEventNo { get; set; } // EC_LST_PUB_EVENT_NO (length: 15)
        public string EcOrdNo { get; set; } // EC_ORD_NO (length: 9)
        public string EcBatId { get; set; } // EC_BAT_ID (length: 6)
        public string EcCustNo { get; set; } // EC_CUST_NO (length: 10)
        public string EcAffilCod { get; set; } // EC_AFFIL_COD (length: 10)
        public decimal? EcOrdTot { get; set; } // EC_ORD_TOT
        public string BillNam { get; set; } // BILL_NAM (length: 40)
        public string BillNamUpr { get; set; } // BILL_NAM_UPR (length: 40)
        public string BillFstNam { get; set; } // BILL_FST_NAM (length: 15)
        public string BillFstNamUpr { get; set; } // BILL_FST_NAM_UPR (length: 15)
        public string BillLstNam { get; set; } // BILL_LST_NAM (length: 25)
        public string BillLstNamUpr { get; set; } // BILL_LST_NAM_UPR (length: 25)
        public string BillSalutation { get; set; } // BILL_SALUTATION (length: 10)
        public string BillAdrs1 { get; set; } // BILL_ADRS_1 (length: 40)
        public string BillAdrs2 { get; set; } // BILL_ADRS_2 (length: 40)
        public string BillAdrs3 { get; set; } // BILL_ADRS_3 (length: 40)
        public string BillCity { get; set; } // BILL_CITY (length: 20)
        public string BillState { get; set; } // BILL_STATE (length: 10)
        public string BillZipCod { get; set; } // BILL_ZIP_COD (length: 15)
        public string BillCntry { get; set; } // BILL_CNTRY (length: 20)
        public string BillPhone1 { get; set; } // BILL_PHONE_1 (length: 25)
        public string BillPhone2 { get; set; } // BILL_PHONE_2 (length: 25)
        public string BillNamTyp { get; set; } // BILL_NAM_TYP (length: 1)
        public string BillEmailAdrs1 { get; set; } // BILL_EMAIL_ADRS_1 (length: 50)
        public string BillEmailAdrs2 { get; set; } // BILL_EMAIL_ADRS_2 (length: 50)
        public string BillContct1 { get; set; } // BILL_CONTCT_1 (length: 40)
        public string BillContct2 { get; set; } // BILL_CONTCT_2 (length: 40)
        public string BillFax1 { get; set; } // BILL_FAX_1 (length: 25)
        public string BillFax2 { get; set; } // BILL_FAX_2 (length: 25)
        public string BillFstLstNam { get; set; } // BILL_FST_LST_NAM (length: 42)
        public string ShipNam { get; set; } // SHIP_NAM (length: 40)
        public string ShipFstNam { get; set; } // SHIP_FST_NAM (length: 15)
        public string ShipLstNam { get; set; } // SHIP_LST_NAM (length: 25)
        public string ShipSalutation { get; set; } // SHIP_SALUTATION (length: 10)
        public string ShipAdrs1 { get; set; } // SHIP_ADRS_1 (length: 40)
        public string ShipAdrs2 { get; set; } // SHIP_ADRS_2 (length: 40)
        public string ShipAdrs3 { get; set; } // SHIP_ADRS_3 (length: 40)
        public string ShipCity { get; set; } // SHIP_CITY (length: 20)
        public string ShipState { get; set; } // SHIP_STATE (length: 10)
        public string ShipZipCod { get; set; } // SHIP_ZIP_COD (length: 15)
        public string ShipCntry { get; set; } // SHIP_CNTRY (length: 20)
        public string ShipPhone1 { get; set; } // SHIP_PHONE_1 (length: 25)
        public string ShipPhone2 { get; set; } // SHIP_PHONE_2 (length: 25)
        public string ShipAdrsId { get; set; } // SHIP_ADRS_ID (length: 10)
        public string ShipNamTyp { get; set; } // SHIP_NAM_TYP (length: 1)
        public string ShipEmailAdrs1 { get; set; } // SHIP_EMAIL_ADRS_1 (length: 50)
        public string ShipEmailAdrs2 { get; set; } // SHIP_EMAIL_ADRS_2 (length: 50)
        public string ShipContct1 { get; set; } // SHIP_CONTCT_1 (length: 40)
        public string ShipContct2 { get; set; } // SHIP_CONTCT_2 (length: 40)
        public string ShipFax1 { get; set; } // SHIP_FAX_1 (length: 25)
        public string ShipFax2 { get; set; } // SHIP_FAX_2 (length: 25)
        public string ShipFstLstNam { get; set; } // SHIP_FST_LST_NAM (length: 42)
        public string ProfCod1 { get; set; } // PROF_COD_1 (length: 10)
        public string ProfCod2 { get; set; } // PROF_COD_2 (length: 10)
        public string ProfCod3 { get; set; } // PROF_COD_3 (length: 10)
        public string ProfCod4 { get; set; } // PROF_COD_4 (length: 10)
        public string ProfCod5 { get; set; } // PROF_COD_5 (length: 10)
        public decimal? ProfNo1 { get; set; } // PROF_NO_1
        public decimal? ProfNo2 { get; set; } // PROF_NO_2
        public decimal? ProfNo3 { get; set; } // PROF_NO_3
        public decimal? ProfNo4 { get; set; } // PROF_NO_4
        public decimal? ProfNo5 { get; set; } // PROF_NO_5
        public string ProfAlpha1 { get; set; } // PROF_ALPHA_1 (length: 30)
        public string ProfAlpha2 { get; set; } // PROF_ALPHA_2 (length: 30)
        public string ProfAlpha3 { get; set; } // PROF_ALPHA_3 (length: 30)
        public string ProfAlpha4 { get; set; } // PROF_ALPHA_4 (length: 30)
        public string ProfAlpha5 { get; set; } // PROF_ALPHA_5 (length: 30)
        public DateTime? ProfDat1 { get; set; } // PROF_DAT_1
        public DateTime? ProfDat2 { get; set; } // PROF_DAT_2
        public DateTime? ProfDat3 { get; set; } // PROF_DAT_3
        public DateTime? ProfDat4 { get; set; } // PROF_DAT_4
        public DateTime? ProfDat5 { get; set; } // PROF_DAT_5
        public DateTime? BusDatExt { get; set; } // BUS_DAT_EXT
        public long? DocIdExt { get; set; } // DOC_ID_EXT
        public string UserNicsDros { get; set; } // USER_NICS_DROS (length: 30)
        public string User4473 { get; set; } // USER_4473 (length: 30)
        public string UserFfl { get; set; } // USER_FFL (length: 30)
        public string UserIntrfacdToShip { get; set; } // USER_INTRFACD_TO_SHIP (length: 1)
        public int? UserShipRespStat { get; set; } // USER_SHIP_RESP_STAT
        public string UserShipResp { get; set; } // USER_SHIP_RESP (length: 2147483647)
        public string UserEcommAuthCode { get; set; } // USER_ECOMM_AUTH_CODE (length: 10)
        public string UserEcommOrdNo { get; set; } // USER_ECOMM_ORD_NO (length: 15)
        public string UserEcommReceiptNo { get; set; } // USER_ECOMM_RECEIPT_NO (length: 10)
        public string UserDlData2D { get; set; } // USER_DL_DATA_2D (length: 2147483647)
        public int? E4473SeqNo { get; set; } // E4473_SEQ_NO
        public string E4473FirstName { get; set; } // E4473_FIRST_NAME (length: 256)
        public string E4473MiddleName { get; set; } // E4473_MIDDLE_NAME (length: 256)
        public string E4473LastName { get; set; } // E4473_LAST_NAME (length: 256)
        public string E4473Addrs1 { get; set; } // E4473_ADDRS_1 (length: 256)
        public string E4473Addrs2 { get; set; } // E4473_ADDRS_2 (length: 256)
        public string E4473City { get; set; } // E4473_CITY (length: 256)
        public string E4473County { get; set; } // E4473_COUNTY (length: 256)
        public string E4473State { get; set; } // E4473_STATE (length: 256)
        public string E4473ZipCod { get; set; } // E4473_ZIP_COD (length: 256)
        public string E4473ActivDutyAddrs1 { get; set; } // E4473_ACTIV_DUTY_ADDRS_1 (length: 256)
        public string E4473ActivDutyAddrs2 { get; set; } // E4473_ACTIV_DUTY_ADDRS_2 (length: 256)
        public string E4473ActivDutyCity { get; set; } // E4473_ACTIV_DUTY_CITY (length: 256)
        public string E4473ActivDutyCounty { get; set; } // E4473_ACTIV_DUTY_COUNTY (length: 256)
        public string E4473ActivDutyState { get; set; } // E4473_ACTIV_DUTY_STATE (length: 256)
        public string E4473ActivDutyZipCod { get; set; } // E4473_ACTIV_DUTY_ZIP_COD (length: 256)
        public string E4473Alien { get; set; } // E4473_ALIEN (length: 256)
        public string E4473AlienNum { get; set; } // E4473_ALIEN_NUM (length: 256)
        public string E4473Birthdate { get; set; } // E4473_BIRTHDATE (length: 256)
        public string E4473Citizenship { get; set; } // E4473_CITIZENSHIP (length: 256)
        public string E4473Ethnicity { get; set; } // E4473_ETHNICITY (length: 256)
        public string E4473Gender { get; set; } // E4473_GENDER (length: 256)
        public string E4473HeightFt { get; set; } // E4473_HEIGHT_FT (length: 256)
        public string E4473HeightIn { get; set; } // E4473_HEIGHT_IN (length: 256)
        public string E4473PlaceOfBirthCity { get; set; } // E4473_PLACE_OF_BIRTH_CITY (length: 256)
        public string E4473PlaceOfBirthForeign { get; set; } // E4473_PLACE_OF_BIRTH_FOREIGN (length: 256)
        public string E4473PlaceOfBirthState { get; set; } // E4473_PLACE_OF_BIRTH_STATE (length: 256)
        public string E4473Race { get; set; } // E4473_RACE (length: 256)
        public string E4473ResidenceState { get; set; } // E4473_RESIDENCE_STATE (length: 256)
        public string E4473SocSecNum { get; set; } // E4473_SOC_SEC_NUM (length: 256)
        public string E4473Weight { get; set; } // E4473_WEIGHT (length: 256)
        public string E4473Upin { get; set; } // E4473_UPIN (length: 256)
        public string E4473C11A { get; set; } // E4473_C11A (length: 256)
        public string E4473C11B { get; set; } // E4473_C11B (length: 256)
        public string E4473C11C { get; set; } // E4473_C11C (length: 256)
        public string E4473C11D { get; set; } // E4473_C11D (length: 256)
        public string E4473C11E { get; set; } // E4473_C11E (length: 256)
        public string E4473C11F { get; set; } // E4473_C11F (length: 256)
        public string E4473C11G { get; set; } // E4473_C11G (length: 256)
        public string E4473C11H { get; set; } // E4473_C11H (length: 256)
        public string E4473C11I { get; set; } // E4473_C11I (length: 256)
        public string E4473C11J { get; set; } // E4473_C11J (length: 256)
        public string E4473C11K { get; set; } // E4473_C11K (length: 256)
        public string E4473C11L { get; set; } // E4473_C11L (length: 256)
        public string E4473C12B { get; set; } // E4473_C12B (length: 256)
        public string E4473C12C { get; set; } // E4473_C12C (length: 256)
        public string E4473C12D1 { get; set; } // E4473_C12D1 (length: 256)
        public string E4473C12D2 { get; set; } // E4473_C12D2 (length: 256)
        public byte? UserShippingEasyStat { get; set; } // USER_SHIPPING_EASY_STAT
        public string UserShippingEasyResponse { get; set; } // USER_SHIPPING_EASY_RESPONSE (length: 1000)
        public int? UserShippingEasyId { get; set; } // USER_SHIPPING_EASY_ID
    }

}
// </auto-generated>

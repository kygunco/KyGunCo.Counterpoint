// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_AR_CUST_WITH_ADDRESS
    public class ViArCustWithAddressConfiguration : IEntityTypeConfiguration<ViArCustWithAddress>
    {
        public void Configure(EntityTypeBuilder<ViArCustWithAddress> builder)
        {
            builder.ToView("VI_AR_CUST_WITH_ADDRESS", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Nam).HasColumnName(@"NAM").HasColumnType("varchar(40)").IsRequired().IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.NamUpr).HasColumnName(@"NAM_UPR").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.FstNam).HasColumnName(@"FST_NAM").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.FstNamUpr).HasColumnName(@"FST_NAM_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LstNam).HasColumnName(@"LST_NAM").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.LstNamUpr).HasColumnName(@"LST_NAM_UPR").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.Salutation).HasColumnName(@"SALUTATION").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CustTyp).HasColumnName(@"CUST_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Adrs1).HasColumnName(@"ADRS_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.Adrs2).HasColumnName(@"ADRS_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.Adrs3).HasColumnName(@"ADRS_3").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.City).HasColumnName(@"CITY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.State).HasColumnName(@"STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ZipCod).HasColumnName(@"ZIP_COD").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Cntry).HasColumnName(@"CNTRY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Phone1).HasColumnName(@"PHONE_1").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.Phone2).HasColumnName(@"PHONE_2").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.Fax1).HasColumnName(@"FAX_1").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.Fax2).HasColumnName(@"FAX_2").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.Contct1).HasColumnName(@"CONTCT_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.Contct2).HasColumnName(@"CONTCT_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.EmailAdrs1).HasColumnName(@"EMAIL_ADRS_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.EmailAdrs2).HasColumnName(@"EMAIL_ADRS_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Url1).HasColumnName(@"URL_1").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.Url2).HasColumnName(@"URL_2").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.PromptNamAdrs).HasColumnName(@"PROMPT_NAM_ADRS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SlsRep).HasColumnName(@"SLS_REP").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CategCod).HasColumnName(@"CATEG_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ShipViaCod).HasColumnName(@"SHIP_VIA_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ShipZoneCod).HasColumnName(@"SHIP_ZONE_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StmntCod).HasColumnName(@"STMNT_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCod).HasColumnName(@"TAX_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TermsCod).HasColumnName(@"TERMS_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Commnt).HasColumnName(@"COMMNT").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.TaxExemptNo).HasColumnName(@"TAX_EXEMPT_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.TaxExemptDat).HasColumnName(@"TAX_EXEMPT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.AllowArChrg).HasColumnName(@"ALLOW_AR_CHRG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowTkts).HasColumnName(@"ALLOW_TKTS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.NoCrLim).HasColumnName(@"NO_CR_LIM").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CrLim).HasColumnName(@"CR_LIM").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.CrRate).HasColumnName(@"CR_RATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.NoMaxChkAmt).HasColumnName(@"NO_MAX_CHK_AMT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MaxChkAmt).HasColumnName(@"MAX_CHK_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.UnpstdBal).HasColumnName(@"UNPSTD_BAL").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.BalMeth).HasColumnName(@"BAL_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ArAcctNo).HasColumnName(@"AR_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Bal).HasColumnName(@"BAL").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OrdBal).HasColumnName(@"ORD_BAL").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.NoOfOrds).HasColumnName(@"NO_OF_ORDS").HasColumnType("int").IsRequired();
            builder.Property(x => x.UseOrdShipTo).HasColumnName(@"USE_ORD_SHIP_TO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowOrds).HasColumnName(@"ALLOW_ORDS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstAgeDat).HasColumnName(@"LST_AGE_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstAgeBal).HasColumnName(@"LST_AGE_BAL").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstAgeBal1).HasColumnName(@"LST_AGE_BAL_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstAgeBal2).HasColumnName(@"LST_AGE_BAL_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstAgeBal3).HasColumnName(@"LST_AGE_BAL_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstAgeBal4).HasColumnName(@"LST_AGE_BAL_4").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstAgeBal5).HasColumnName(@"LST_AGE_BAL_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstAgeBal25).HasColumnName(@"LST_AGE_BAL_2_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstAgeBal35).HasColumnName(@"LST_AGE_BAL_3_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstAgeBal45).HasColumnName(@"LST_AGE_BAL_4_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstAgeBalOpn).HasColumnName(@"LST_AGE_BAL_OPN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstAgeFutrDocs).HasColumnName(@"LST_AGE_FUTR_DOCS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstAgeMeth).HasColumnName(@"LST_AGE_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstAgeAsOfDat).HasColumnName(@"LST_AGE_AS_OF_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstAgeCutoffDat).HasColumnName(@"LST_AGE_CUTOFF_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstAgeMaxPrd1).HasColumnName(@"LST_AGE_MAX_PRD_1").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstAgeMaxPrd2).HasColumnName(@"LST_AGE_MAX_PRD_2").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstAgeMaxPrd3).HasColumnName(@"LST_AGE_MAX_PRD_3").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstAgeMaxPrd4).HasColumnName(@"LST_AGE_MAX_PRD_4").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstAgeNoOfPrds).HasColumnName(@"LST_AGE_NO_OF_PRDS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstAgeEventNo).HasColumnName(@"LST_AGE_EVENT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LstAgeNoCutoff).HasColumnName(@"LST_AGE_NO_CUTOFF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstAgePastCutoff).HasColumnName(@"LST_AGE_PAST_CUTOFF").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstAgeNonStd).HasColumnName(@"LST_AGE_NON_STD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstStmntDat).HasColumnName(@"LST_STMNT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstStmntBal).HasColumnName(@"LST_STMNT_BAL").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstStmntBal1).HasColumnName(@"LST_STMNT_BAL_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstStmntBal2).HasColumnName(@"LST_STMNT_BAL_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstStmntBal3).HasColumnName(@"LST_STMNT_BAL_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstStmntBal4).HasColumnName(@"LST_STMNT_BAL_4").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstStmntBal5).HasColumnName(@"LST_STMNT_BAL_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstStmntBal25).HasColumnName(@"LST_STMNT_BAL_2_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstStmntBal35).HasColumnName(@"LST_STMNT_BAL_3_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstStmntBal45).HasColumnName(@"LST_STMNT_BAL_4_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstStmntBalOpn).HasColumnName(@"LST_STMNT_BAL_OPN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstStmntMeth).HasColumnName(@"LST_STMNT_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstStmntBegDat).HasColumnName(@"LST_STMNT_BEG_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstStmntEndDat).HasColumnName(@"LST_STMNT_END_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstStmntMaxPrd1).HasColumnName(@"LST_STMNT_MAX_PRD_1").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstStmntMaxPrd2).HasColumnName(@"LST_STMNT_MAX_PRD_2").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstStmntMaxPrd3).HasColumnName(@"LST_STMNT_MAX_PRD_3").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstStmntMaxPrd4).HasColumnName(@"LST_STMNT_MAX_PRD_4").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstStmntNoOfPrds).HasColumnName(@"LST_STMNT_NO_OF_PRDS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstStmntPastCtoff).HasColumnName(@"LST_STMNT_PAST_CTOFF").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.FstSalDat).HasColumnName(@"FST_SAL_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstSalDat).HasColumnName(@"LST_SAL_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstSalAmt).HasColumnName(@"LST_SAL_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstPmtDat).HasColumnName(@"LST_PMT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstPmtAmt).HasColumnName(@"LST_PMT_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ProfAlpha1).HasColumnName(@"PROF_ALPHA_1").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha2).HasColumnName(@"PROF_ALPHA_2").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha3).HasColumnName(@"PROF_ALPHA_3").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha4).HasColumnName(@"PROF_ALPHA_4").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfAlpha5).HasColumnName(@"PROF_ALPHA_5").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ProfCod1).HasColumnName(@"PROF_COD_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod2).HasColumnName(@"PROF_COD_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod3).HasColumnName(@"PROF_COD_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod4).HasColumnName(@"PROF_COD_4").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfCod5).HasColumnName(@"PROF_COD_5").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ProfDat1).HasColumnName(@"PROF_DAT_1").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat2).HasColumnName(@"PROF_DAT_2").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat3).HasColumnName(@"PROF_DAT_3").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat4).HasColumnName(@"PROF_DAT_4").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfDat5).HasColumnName(@"PROF_DAT_5").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProfNo1).HasColumnName(@"PROF_NO_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.ProfNo2).HasColumnName(@"PROF_NO_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.ProfNo3).HasColumnName(@"PROF_NO_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.ProfNo4).HasColumnName(@"PROF_NO_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.ProfNo5).HasColumnName(@"PROF_NO_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.WrkStmntActiv).HasColumnName(@"WRK_STMNT_ACTIV").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LwyBal).HasColumnName(@"LWY_BAL").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.NoOfLwys).HasColumnName(@"NO_OF_LWYS").HasColumnType("int").IsRequired();
            builder.Property(x => x.UseLwyShipTo).HasColumnName(@"USE_LWY_SHIP_TO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowLwys).HasColumnName(@"ALLOW_LWYS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.IsEcommCust).HasColumnName(@"IS_ECOMM_CUST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommCustNo).HasColumnName(@"ECOMM_CUST_NO").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.EcommAffilCod).HasColumnName(@"ECOMM_AFFIL_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DiscPct).HasColumnName(@"DISC_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.EcommInitPwd).HasColumnName(@"ECOMM_INIT_PWD").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.EcommNxtPubUpdt).HasColumnName(@"ECOMM_NXT_PUB_UPDT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommNxtPubFull).HasColumnName(@"ECOMM_NXT_PUB_FULL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommLstPubDt).HasColumnName(@"ECOMM_LST_PUB_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EcommLstPubTyp).HasColumnName(@"ECOMM_LST_PUB_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommLstImpDt).HasColumnName(@"ECOMM_LST_IMP_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EcommCreatedCust).HasColumnName(@"ECOMM_CREATED_CUST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommLstOrdNo).HasColumnName(@"ECOMM_LST_ORD_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.EcommLstOrdDt).HasColumnName(@"ECOMM_LST_ORD_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EcommLstImpTyp).HasColumnName(@"ECOMM_LST_IMP_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EcommLstImpEventNo).HasColumnName(@"ECOMM_LST_IMP_EVENT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PromptForCustomFlds).HasColumnName(@"PROMPT_FOR_CUSTOM_FLDS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LoyPgmCod).HasColumnName(@"LOY_PGM_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LoyPtsBal).HasColumnName(@"LOY_PTS_BAL").HasColumnType("int").IsRequired();
            builder.Property(x => x.TotLoyPtsEarnd).HasColumnName(@"TOT_LOY_PTS_EARND").HasColumnType("int").IsRequired();
            builder.Property(x => x.TotLoyPtsRdm).HasColumnName(@"TOT_LOY_PTS_RDM").HasColumnType("int").IsRequired();
            builder.Property(x => x.TotLoyPtsAdj).HasColumnName(@"TOT_LOY_PTS_ADJ").HasColumnType("int").IsRequired();
            builder.Property(x => x.LstLoyEarnTktDat).HasColumnName(@"LST_LOY_EARN_TKT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstLoyEarnTktTim).HasColumnName(@"LST_LOY_EARN_TKT_TIM").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstLoyPtsEarn).HasColumnName(@"LST_LOY_PTS_EARN").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstLoyEarnTktNo).HasColumnName(@"LST_LOY_EARN_TKT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LstLoyRdmTktDat).HasColumnName(@"LST_LOY_RDM_TKT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstLoyRdmTktTim).HasColumnName(@"LST_LOY_RDM_TKT_TIM").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstLoyPtsRdm).HasColumnName(@"LST_LOY_PTS_RDM").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstLoyRdmTktNo).HasColumnName(@"LST_LOY_RDM_TKT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LstLoyAdjDat).HasColumnName(@"LST_LOY_ADJ_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstLoyPtsAdj).HasColumnName(@"LST_LOY_PTS_ADJ").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstLoyAdjDocNo).HasColumnName(@"LST_LOY_ADJ_DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LoyCardNo).HasColumnName(@"LOY_CARD_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.FchCod).HasColumnName(@"FCH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstFchDat).HasColumnName(@"LST_FCH_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstFchAmt).HasColumnName(@"LST_FCH_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstFchPastDueAmt).HasColumnName(@"LST_FCH_PAST_DUE_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LstFchDocNo).HasColumnName(@"LST_FCH_DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ReqPoNo).HasColumnName(@"REQ_PO_NO").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.CustNamTyp).HasColumnName(@"CUST_NAM_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CustFstLstNam).HasColumnName(@"CUST_FST_LST_NAM").HasColumnType("varchar(42)").IsRequired(false).IsUnicode(false).HasMaxLength(42);
            builder.Property(x => x.LstLoyEarnTktDt).HasColumnName(@"LST_LOY_EARN_TKT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstLoyRdmTktDt).HasColumnName(@"LST_LOY_RDM_TKT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.PsHdrCustFldFrmId).HasColumnName(@"PS_HDR_CUST_FLD_FRM_ID").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.EmailStatement).HasColumnName(@"EMAIL_STATEMENT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.IncludeInMarketingMailouts).HasColumnName(@"INCLUDE_IN_MARKETING_MAILOUTS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MarketingMailoutOptInDat).HasColumnName(@"MARKETING_MAILOUT_OPT_IN_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.RptEmail).HasColumnName(@"RPT_EMAIL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MblPhone1).HasColumnName(@"MBL_PHONE_1").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.MblPhone2).HasColumnName(@"MBL_PHONE_2").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.UserDob).HasColumnName(@"USER_DOB").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.UserSex).HasColumnName(@"USER_SEX").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserHeight).HasColumnName(@"USER_HEIGHT").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserWeight).HasColumnName(@"USER_WEIGHT").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserHairColr).HasColumnName(@"USER_HAIR_COLR").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserEyeColr).HasColumnName(@"USER_EYE_COLR").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UserDlNo).HasColumnName(@"USER_DL_NO").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.UserDlExp).HasColumnName(@"USER_DL_EXP").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.UserWaiverDat).HasColumnName(@"USER_WAIVER_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.UserRangeLockoutDate).HasColumnName(@"USER_RANGE_LOCKOUT_DATE").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.UserEthnicity).HasColumnName(@"USER_ETHNICITY").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserRace).HasColumnName(@"USER_RACE").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserPlaceOfBirth).HasColumnName(@"USER_PLACE_OF_BIRTH").HasColumnType("varchar(80)").IsRequired(false).IsUnicode(false).HasMaxLength(80);
            builder.Property(x => x.UserCounty).HasColumnName(@"USER_COUNTY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.UserMidNam).HasColumnName(@"USER_MID_NAM").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.CityStateZipCntry).HasColumnName(@"CITY_STATE_ZIP_CNTRY").HasColumnType("varchar(70)").IsRequired(false).IsUnicode(false).HasMaxLength(70);
            builder.Property(x => x.AdrsMsk).HasColumnName(@"ADRS_MSK").HasColumnType("varchar(4)").IsRequired(false).IsUnicode(false).HasMaxLength(4);
            builder.Property(x => x.LblNumber).HasColumnName(@"LBL_NUMBER").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LblName).HasColumnName(@"LBL_NAME").HasColumnType("varchar(40)").IsRequired().IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.LblAddress1).HasColumnName(@"LBL_ADDRESS_1").HasColumnType("varchar(70)").IsRequired(false).IsUnicode(false).HasMaxLength(70);
            builder.Property(x => x.LblAddress2).HasColumnName(@"LBL_ADDRESS_2").HasColumnType("varchar(70)").IsRequired(false).IsUnicode(false).HasMaxLength(70);
            builder.Property(x => x.LblAddress3).HasColumnName(@"LBL_ADDRESS_3").HasColumnType("varchar(70)").IsRequired(false).IsUnicode(false).HasMaxLength(70);
            builder.Property(x => x.LblAddress4).HasColumnName(@"LBL_ADDRESS_4").HasColumnType("varchar(70)").IsRequired(false).IsUnicode(false).HasMaxLength(70);
        }
    }

}
// </auto-generated>

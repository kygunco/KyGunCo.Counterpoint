// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_COMP
    public class SyCompConfiguration : IEntityTypeConfiguration<SyComp>
    {
        public void Configure(EntityTypeBuilder<SyComp> builder)
        {
            builder.ToTable("SY_COMP", "dbo");
            builder.HasKey(x => x.KeyId).HasName("PK_SY_COMP").IsClustered();

            builder.Property(x => x.KeyId).HasColumnName(@"KEY_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Nam).HasColumnName(@"NAM").HasColumnType("varchar(40)").IsRequired().IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.Adrs1).HasColumnName(@"ADRS_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.Adrs2).HasColumnName(@"ADRS_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.Adrs3).HasColumnName(@"ADRS_3").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.City).HasColumnName(@"CITY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.State).HasColumnName(@"STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ZipCod).HasColumnName(@"ZIP_COD").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Cntry).HasColumnName(@"CNTRY").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Phone1).HasColumnName(@"PHONE_1").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.Phone2).HasColumnName(@"PHONE_2").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.Contct1).HasColumnName(@"CONTCT_1").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.Contct2).HasColumnName(@"CONTCT_2").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.Fax1).HasColumnName(@"FAX_1").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.Fax2).HasColumnName(@"FAX_2").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.EmailAdrs1).HasColumnName(@"EMAIL_ADRS_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.EmailAdrs2).HasColumnName(@"EMAIL_ADRS_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Url1).HasColumnName(@"URL_1").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.Url2).HasColumnName(@"URL_2").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.CurrCalndrId).HasColumnName(@"CURR_CALNDR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CenturyOffset).HasColumnName(@"CENTURY_OFFSET").HasColumnType("int").IsRequired();
            builder.Property(x => x.UsePwds).HasColumnName(@"USE_PWDS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MinPwdLen).HasColumnName(@"MIN_PWD_LEN").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.PwdChngDays).HasColumnName(@"PWD_CHNG_DAYS").HasColumnType("int").IsRequired();
            builder.Property(x => x.MainAcctStart).HasColumnName(@"MAIN_ACCT_START").HasColumnType("int").IsRequired();
            builder.Property(x => x.MainAcctLen).HasColumnName(@"MAIN_ACCT_LEN").HasColumnType("int").IsRequired();
            builder.Property(x => x.PftCtrStart).HasColumnName(@"PFT_CTR_START").HasColumnType("int").IsRequired();
            builder.Property(x => x.PftCtrLen).HasColumnName(@"PFT_CTR_LEN").HasColumnType("int").IsRequired();
            builder.Property(x => x.ArCashDetlDist).HasColumnName(@"AR_CASH_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ArCashDistRef).HasColumnName(@"AR_CASH_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ArAdjDetlDist).HasColumnName(@"AR_ADJ_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ArAdjDistRef).HasColumnName(@"AR_ADJ_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsSlsDetlDist).HasColumnName(@"PS_SLS_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsSlsDistRef).HasColumnName(@"PS_SLS_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsPmtDetlDist).HasColumnName(@"PS_PMT_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsPmtDistRef).HasColumnName(@"PS_PMT_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsMiscDetlDist).HasColumnName(@"PS_MISC_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsMiscDistRef).HasColumnName(@"PS_MISC_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsTaxDetlDist).HasColumnName(@"PS_TAX_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsTaxDistRef).HasColumnName(@"PS_TAX_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImRecvDetlDist).HasColumnName(@"IM_RECV_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImRecvDistRef).HasColumnName(@"IM_RECV_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImSlsDetlDist).HasColumnName(@"IM_SLS_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImSlsDistRef).HasColumnName(@"IM_SLS_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImAdjDetlDist).HasColumnName(@"IM_ADJ_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImAdjDistRef).HasColumnName(@"IM_ADJ_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImCntDetlDist).HasColumnName(@"IM_CNT_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImCntDistRef).HasColumnName(@"IM_CNT_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImXferDetlDist).HasColumnName(@"IM_XFER_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImXferDistRef).HasColumnName(@"IM_XFER_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsGfcDetlDist).HasColumnName(@"PS_GFC_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsGfcDistRef).HasColumnName(@"PS_GFC_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseGfc).HasColumnName(@"USE_GFC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.GfcValMons).HasColumnName(@"GFC_VAL_MONS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.NoGfcExp).HasColumnName(@"NO_GFC_EXP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RoundGfcExpToEom).HasColumnName(@"ROUND_GFC_EXP_TO_EOM").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowOthrStrGfcs).HasColumnName(@"ALLOW_OTHR_STR_GFCS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ClsdGfcJrnlMeth).HasColumnName(@"CLSD_GFC_JRNL_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MinGfcRdmPct).HasColumnName(@"MIN_GFC_RDM_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.PsStcDetlDist).HasColumnName(@"PS_STC_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsStcDistRef).HasColumnName(@"PS_STC_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseStc).HasColumnName(@"USE_STC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.StcValMons).HasColumnName(@"STC_VAL_MONS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.NoStcExp).HasColumnName(@"NO_STC_EXP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RoundStcExpToEom).HasColumnName(@"ROUND_STC_EXP_TO_EOM").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowOthrStrStcs).HasColumnName(@"ALLOW_OTHR_STR_STCS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ClsdStcJrnlMeth).HasColumnName(@"CLSD_STC_JRNL_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.StcLiabAcctNo).HasColumnName(@"STC_LIAB_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.StcLiabMeth).HasColumnName(@"STC_LIAB_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.StcRdmAcctNo).HasColumnName(@"STC_RDM_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.StcRdmMeth).HasColumnName(@"STC_RDM_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.StcForfAcctNo).HasColumnName(@"STC_FORF_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.StcForfMeth).HasColumnName(@"STC_FORF_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MaxLkupRows).HasColumnName(@"MAX_LKUP_ROWS").HasColumnType("int").IsRequired();
            builder.Property(x => x.UseFastOpn).HasColumnName(@"USE_FAST_OPN").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ClsdGfcJrnlDist).HasColumnName(@"CLSD_GFC_JRNL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ClsdStcJrnlDist).HasColumnName(@"CLSD_STC_JRNL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.ImRtvDetlDist).HasColumnName(@"IM_RTV_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImRtvDistRef).HasColumnName(@"IM_RTV_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsPayInOutDetlDist).HasColumnName(@"PS_PAY_IN_OUT_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsPayInOutDistRef).HasColumnName(@"PS_PAY_IN_OUT_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsPayOnAcctDetlDist).HasColumnName(@"PS_PAY_ON_ACCT_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsPayOnAcctDistRef).HasColumnName(@"PS_PAY_ON_ACCT_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MaxTblViewRows).HasColumnName(@"MAX_TBL_VIEW_ROWS").HasColumnType("int").IsRequired();
            builder.Property(x => x.PoAdjDetlDist).HasColumnName(@"PO_ADJ_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoAdjDistRef).HasColumnName(@"PO_ADJ_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ReqComplexPwd).HasColumnName(@"REQ_COMPLEX_PWD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PrevUniquePwds).HasColumnName(@"PREV_UNIQUE_PWDS").HasColumnType("int").IsRequired();
            builder.Property(x => x.LoginAttempts).HasColumnName(@"LOGIN_ATTEMPTS").HasColumnType("int").IsRequired();
            builder.Property(x => x.UseTimcrds).HasColumnName(@"USE_TIMCRDS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.StaleClckInHrs).HasColumnName(@"STALE_CLCK_IN_HRS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.AllowReClckIn).HasColumnName(@"ALLOW_RE_CLCK_IN").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ReClckInMins).HasColumnName(@"RE_CLCK_IN_MINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.AllowOrphanClckOut).HasColumnName(@"ALLOW_ORPHAN_CLCK_OUT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TimcrdDfltUsrId).HasColumnName(@"TIMCRD_DFLT_USR_ID").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ArFchDetlDist).HasColumnName(@"AR_FCH_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ArFchDistRef).HasColumnName(@"AR_FCH_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsSvcDetlDist).HasColumnName(@"PS_SVC_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsSvcDistRef).HasColumnName(@"PS_SVC_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseSvc).HasColumnName(@"USE_SVC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SvcProcessor).HasColumnName(@"SVC_PROCESSOR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SvcMinActivAmt).HasColumnName(@"SVC_MIN_ACTIV_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.SvcMinRechrgAmt).HasColumnName(@"SVC_MIN_RECHRG_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.SvcMaxRfndAmt).HasColumnName(@"SVC_MAX_RFND_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.SvcMaxCashBackAmt).HasColumnName(@"SVC_MAX_CASH_BACK_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.NoSvcMaxCashBackAmt).HasColumnName(@"NO_SVC_MAX_CASH_BACK_AMT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ReqSvcPin).HasColumnName(@"REQ_SVC_PIN").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseWindowsAuth).HasColumnName(@"USE_WINDOWS_AUTH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.WindowsAuthPath).HasColumnName(@"WINDOWS_AUTH_PATH").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.OeSlsDetlDist).HasColumnName(@"OE_SLS_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OeSlsDistRef).HasColumnName(@"OE_SLS_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OePmtDetlDist).HasColumnName(@"OE_PMT_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OePmtDistRef).HasColumnName(@"OE_PMT_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OeMiscDetlDist).HasColumnName(@"OE_MISC_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OeMiscDistRef).HasColumnName(@"OE_MISC_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OeTaxDetlDist).HasColumnName(@"OE_TAX_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OeTaxDistRef).HasColumnName(@"OE_TAX_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OeGfcDetlDist).HasColumnName(@"OE_GFC_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OeGfcDistRef).HasColumnName(@"OE_GFC_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OeStcDetlDist).HasColumnName(@"OE_STC_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OeStcDistRef).HasColumnName(@"OE_STC_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OeSvcDetlDist).HasColumnName(@"OE_SVC_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OeSvcDistRef).HasColumnName(@"OE_SVC_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CopyUsrBat).HasColumnName(@"COPY_USR_BAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PromptForUsrBat).HasColumnName(@"PROMPT_FOR_USR_BAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CopyUsrDrw).HasColumnName(@"COPY_USR_DRW").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PromptForUsrDrw).HasColumnName(@"PROMPT_FOR_USR_DRW").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CopyUsrPref).HasColumnName(@"COPY_USR_PREF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PromptForUsrPref).HasColumnName(@"PROMPT_FOR_USR_PREF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ImBomAssemDetlDist).HasColumnName(@"IM_BOM_ASSEM_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ImBomAssemDistRef).HasColumnName(@"IM_BOM_ASSEM_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseGftRgstry).HasColumnName(@"USE_GFT_RGSTRY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AllowOthrStrGftRgstry).HasColumnName(@"ALLOW_OTHR_STR_GFT_RGSTRY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.GftRgstryValMons).HasColumnName(@"GFT_RGSTRY_VAL_MONS").HasColumnType("int").IsRequired();
            builder.Property(x => x.MailRefrshSecs).HasColumnName(@"MAIL_REFRSH_SECS").HasColumnType("int").IsRequired();
            builder.Property(x => x.MailAutoPurgeDays).HasColumnName(@"MAIL_AUTO_PURGE_DAYS").HasColumnType("int").IsRequired();
            builder.Property(x => x.RestrictToRegisteredWorkstations).HasColumnName(@"RESTRICT_TO_REGISTERED_WORKSTATIONS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseExtEdc).HasColumnName(@"USE_EXT_EDC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.RptEmailBody).HasColumnName(@"RPT_EMAIL_BODY").HasColumnType("varchar(1000)").IsRequired(false).IsUnicode(false).HasMaxLength(1000);
            builder.Property(x => x.SysAdminEmailAdrs).HasColumnName(@"SYS_ADMIN_EMAIL_ADRS").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.UseDropship).HasColumnName(@"USE_DROPSHIP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SecurePaymentDataMode).HasColumnName(@"SECURE_PAYMENT_DATA_MODE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserDojVerifyRequired).HasColumnName(@"USER_DOJ_VERIFY_REQUIRED").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserNicsVerifyRequired).HasColumnName(@"USER_NICS_VERIFY_REQUIRED").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UserCustBuyback).HasColumnName(@"USER_CUST_BUYBACK").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LkupAutoSearchDelayMs).HasColumnName(@"LKUP_AUTO_SEARCH_DELAY_MS").HasColumnType("int").IsRequired();
            builder.Property(x => x.LkupAutoSearchMinKwdLen).HasColumnName(@"LKUP_AUTO_SEARCH_MIN_KWD_LEN").HasColumnType("int").IsRequired();
            builder.Property(x => x.LkupUseNolockTableHint).HasColumnName(@"LKUP_USE_NOLOCK_TABLE_HINT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxIdNo).HasColumnName(@"TAX_ID_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PoTaxDistRef).HasColumnName(@"PO_TAX_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsTipDetlDist).HasColumnName(@"PS_TIP_DETL_DIST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PsTipDistRef).HasColumnName(@"PS_TIP_DIST_REF").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);

            builder.HasIndex(x => x.RsStat).HasDatabaseName("SY_COMP_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("SY_COMP_X_RS_UTC_DT");
        }
    }

}
// </auto-generated>
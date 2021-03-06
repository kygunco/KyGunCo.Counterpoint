// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // SY_TAX_AUTH_RUL
    public class SyTaxAuthRul
    {
        public string AuthCod { get; set; } // AUTH_COD (Primary key) (length: 10)
        public string RulCod { get; set; } // RUL_COD (length: 10)
        public int RulSeqNo { get; set; } = 0; // RUL_SEQ_NO (Primary key)
        public string Descr { get; set; } // DESCR (length: 30)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 30)
        public string StopChrgngTax { get; set; } = "N"; // STOP_CHRGNG_TAX (length: 1)
        public string TaxIsTxbl { get; set; } = "N"; // TAX_IS_TXBL (length: 1)
        public string TaxAcctNo { get; set; } // TAX_ACCT_NO (length: 20)
        public string TaxMeth { get; set; } = "!"; // TAX_METH (length: 1)
        public string TaxCategCod1 { get; set; } // TAX_CATEG_COD_1 (length: 10)
        public string TaxCategCod2 { get; set; } // TAX_CATEG_COD_2 (length: 10)
        public string TaxCategCod3 { get; set; } // TAX_CATEG_COD_3 (length: 10)
        public string TaxCategCod4 { get; set; } // TAX_CATEG_COD_4 (length: 10)
        public string TaxCategCod5 { get; set; } // TAX_CATEG_COD_5 (length: 10)
        public string TaxGfc { get; set; } = "N"; // TAX_GFC (length: 1)
        public string TaxMisc1 { get; set; } = "N"; // TAX_MISC_1 (length: 1)
        public string TaxMisc2 { get; set; } = "N"; // TAX_MISC_2 (length: 1)
        public string TaxMisc3 { get; set; } = "N"; // TAX_MISC_3 (length: 1)
        public string TaxMisc4 { get; set; } = "N"; // TAX_MISC_4 (length: 1)
        public string TaxMisc5 { get; set; } = "N"; // TAX_MISC_5 (length: 1)
        public decimal MinUnitTxblAmt { get; set; } = 0m; // MIN_UNIT_TXBL_AMT
        public decimal? MaxUnitTxblAmt { get; set; } // MAX_UNIT_TXBL_AMT
        public string NoMaxUnitTxblAmt { get; set; } = "Y"; // NO_MAX_UNIT_TXBL_AMT (length: 1)
        public string UnitAmtBelowMinTxbl { get; set; } = "N"; // UNIT_AMT_BELOW_MIN_TXBL (length: 1)
        public decimal? TaxPct1 { get; set; } // TAX_PCT_1
        public decimal? TaxAmtOvr1 { get; set; } // TAX_AMT_OVR_1
        public decimal? TaxPct2 { get; set; } // TAX_PCT_2
        public decimal? TaxAmtOvr2 { get; set; } // TAX_AMT_OVR_2
        public decimal? TaxPct3 { get; set; } // TAX_PCT_3
        public decimal? TaxAmtOvr3 { get; set; } // TAX_AMT_OVR_3
        public decimal? TaxPerUnit { get; set; } // TAX_PER_UNIT
        public string TaxRndMeth { get; set; } = "N"; // TAX_RND_METH (length: 1)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string UsePennyTaxTbl { get; set; } = "N"; // USE_PENNY_TAX_TBL (length: 1)
        public decimal? PennyTaxAmt0 { get; set; } // PENNY_TAX_AMT_0
        public decimal? PennyTaxAmt1 { get; set; } // PENNY_TAX_AMT_1
        public decimal? PennyTaxAmt2 { get; set; } // PENNY_TAX_AMT_2
        public decimal? PennyTaxAmt3 { get; set; } // PENNY_TAX_AMT_3
        public decimal? PennyTaxAmt4 { get; set; } // PENNY_TAX_AMT_4
        public decimal? PennyTaxAmt5 { get; set; } // PENNY_TAX_AMT_5
        public decimal? PennyTaxAmt6 { get; set; } // PENNY_TAX_AMT_6
        public decimal? PennyTaxAmt7 { get; set; } // PENNY_TAX_AMT_7
        public decimal? PennyTaxAmt8 { get; set; } // PENNY_TAX_AMT_8
        public decimal? PennyTaxAmt9 { get; set; } // PENNY_TAX_AMT_9
        public decimal? PennyTaxAmt10 { get; set; } // PENNY_TAX_AMT_10
        public decimal? PennyTaxAmt11 { get; set; } // PENNY_TAX_AMT_11
        public string TaxHoliday { get; set; } = "N"; // TAX_HOLIDAY (length: 1)
        public DateTime? TaxHolidayBeg { get; set; } // TAX_HOLIDAY_BEG
        public DateTime? TaxHolidayEnd { get; set; } // TAX_HOLIDAY_END
        public string RulApplyToCategMod { get; set; } = "*"; // RUL_APPLY_TO_CATEG_MOD (length: 1)
        public string TaxCategCod6 { get; set; } // TAX_CATEG_COD_6 (length: 10)
        public string TaxSvc { get; set; } = "N"; // TAX_SVC (length: 1)
        public string PoTaxAcctNo { get; set; } // PO_TAX_ACCT_NO (length: 20)
        public string PoTaxMeth { get; set; } = "!"; // PO_TAX_METH (length: 1)
        public string PoTaxMisc1 { get; set; } = "N"; // PO_TAX_MISC_1 (length: 1)
        public string PoTaxMisc2 { get; set; } = "N"; // PO_TAX_MISC_2 (length: 1)
        public string PoTaxMisc3 { get; set; } = "N"; // PO_TAX_MISC_3 (length: 1)
        public string PoTaxMisc4 { get; set; } = "N"; // PO_TAX_MISC_4 (length: 1)
        public string PoTaxMisc5 { get; set; } = "N"; // PO_TAX_MISC_5 (length: 1)

        // Foreign keys

        /// <summary>
        /// Parent SyTaxAuth pointed by [SY_TAX_AUTH_RUL].([AuthCod]) (FK_SY_TAX_AUTH_RUL_SY_TAX_AUTH)
        /// </summary>
        public virtual SyTaxAuth SyTaxAuth { get; set; } // FK_SY_TAX_AUTH_RUL_SY_TAX_AUTH
    }

}
// </auto-generated>

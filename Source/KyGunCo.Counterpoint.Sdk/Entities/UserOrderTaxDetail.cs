// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_ORDER_TAX_DETAILS
    public class UserOrderTaxDetail
    {
        public long DocId { get; set; } // DOC_ID
        public DateTime? BusDat { get; set; } // BUS_DAT
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public string WebOrdNo { get; set; } // WEB_ORD_NO (length: 15)
        public string AuthCod { get; set; } // AUTH_COD (length: 10)
        public string RulCod { get; set; } // RUL_COD (length: 10)
        public string TaxDocPart { get; set; } // TAX_DOC_PART (length: 1)
        public decimal? LinAmt { get; set; } // LIN_AMT
        public decimal? TxblLinAmt { get; set; } // TXBL_LIN_AMT
        public decimal? TxblMiscChgAmt1 { get; set; } // TXBL_MISC_CHG_AMT_1
        public decimal? TxblMiscChgAmt2 { get; set; } // TXBL_MISC_CHG_AMT_2
        public decimal? TxblMiscChgAmt3 { get; set; } // TXBL_MISC_CHG_AMT_3
        public decimal? TxblMiscChgAmt4 { get; set; } // TXBL_MISC_CHG_AMT_4
        public decimal? TxblMiscChgAmt5 { get; set; } // TXBL_MISC_CHG_AMT_5
        public decimal? TxblTaxAmt { get; set; } // TXBL_TAX_AMT
        public decimal? TxblQty { get; set; } // TXBL_QTY
        public decimal? TaxAmt { get; set; } // TAX_AMT
        public decimal? NormTaxAmt { get; set; } // NORM_TAX_AMT
        public decimal? TaxAmtExact { get; set; } // TAX_AMT_EXACT
        public decimal? NormTaxAmtExact { get; set; } // NORM_TAX_AMT_EXACT
        public decimal? TotTxblAmt { get; set; } // TOT_TXBL_AMT
    }

}
// </auto-generated>
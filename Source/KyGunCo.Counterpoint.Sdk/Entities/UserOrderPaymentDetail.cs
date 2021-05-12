// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_ORDER_PAYMENT_DETAILS
    public class UserOrderPaymentDetail
    {
        public long DocId { get; set; } // DOC_ID
        public DateTime? BusDat { get; set; } // BUS_DAT
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public string WebOrdNo { get; set; } // WEB_ORD_NO (length: 15)
        public int PmtSeqNo { get; set; } // PMT_SEQ_NO
        public string PayCodTyp { get; set; } // PAY_COD_TYP (length: 1)
        public decimal Amt { get; set; } // AMT
        public string FinalPmt { get; set; } // FINAL_PMT (length: 1)
        public string PmtLinTyp { get; set; } // PMT_LIN_TYP (length: 1)
        public string PayCod { get; set; } // PAY_COD (length: 10)
        public DateTime? PayDat { get; set; } // PAY_DAT
        public string Descr { get; set; } // DESCR (length: 30)
    }

}
// </auto-generated>

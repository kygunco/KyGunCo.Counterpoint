// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // SY_STC
    public class SyStc
    {
        public string StcNo { get; set; } // STC_NO (Primary key) (length: 30)
        public string Descr { get; set; } // DESCR (length: 30)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 30)
        public DateTime? OrigDat { get; set; } // ORIG_DAT
        public string OrigStrId { get; set; } // ORIG_STR_ID (length: 10)
        public string OrigStaId { get; set; } // ORIG_STA_ID (length: 10)
        public string OrigDocNo { get; set; } // ORIG_DOC_NO (length: 15)
        public string OrigCustNo { get; set; } // ORIG_CUST_NO (length: 15)
        public string GfcCod { get; set; } // GFC_COD (length: 10)
        public string PayCod { get; set; } // PAY_COD (length: 10)
        public DateTime? ExpDat { get; set; } // EXP_DAT
        public string NoExpDat { get; set; } = "N"; // NO_EXP_DAT (length: 1)
        public decimal OrigAmt { get; set; } // ORIG_AMT
        public decimal CurrAmt { get; set; } = 0m; // CURR_AMT
        public string CreateMeth { get; set; } = "S"; // CREATE_METH (length: 1)
        public string LiabAcctNo { get; set; } // LIAB_ACCT_NO (length: 20)
        public string RdmAcctNo { get; set; } // RDM_ACCT_NO (length: 20)
        public string RdmMeth { get; set; } = "!"; // RDM_METH (length: 1)
        public string ForfAcctNo { get; set; } // FORF_ACCT_NO (length: 20)
        public string IsVoid { get; set; } = "N"; // IS_VOID (length: 1)
        public DateTime? LstActivDat { get; set; } // LST_ACTIV_DAT
        public string ErrRef { get; set; } // ERR_REF (length: 255)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public long? OrigDocId { get; set; } // ORIG_DOC_ID
        public DateTime? OrigBusDat { get; set; } // ORIG_BUS_DAT
        public byte RsStat { get; set; } = 1; // RS_STAT

        // Reverse navigation

        /// <summary>
        /// Child SyStcActivs where [SY_STC_ACTIV].[STC_NO] point to this entity (FK_SY_STC_ACTIV_SY_STC)
        /// </summary>
        public virtual IList<SyStcActiv> SyStcActivs { get; set; } = new List<SyStcActiv>(); // SY_STC_ACTIV.FK_SY_STC_ACTIV_SY_STC
    }

}
// </auto-generated>

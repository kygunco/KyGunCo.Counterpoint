// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_ACCT_COD
    public class ImAcctCod
    {
        public string AcctCod { get; set; } // ACCT_COD (Primary key) (length: 10)
        public string Descr { get; set; } // DESCR (length: 30)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 30)
        public string BsInvAcctNo { get; set; } // BS_INV_ACCT_NO (length: 20)
        public string MitemExpAcctNo { get; set; } // MITEM_EXP_ACCT_NO (length: 20)
        public string MitemExpMeth { get; set; } = "!"; // MITEM_EXP_METH (length: 1)
        public string RecvAccruAcctNo { get; set; } // RECV_ACCRU_ACCT_NO (length: 20)
        public string RecvAccruMeth { get; set; } = "!"; // RECV_ACCRU_METH (length: 1)
        public string PurVarAcctNo { get; set; } // PUR_VAR_ACCT_NO (length: 20)
        public string PurVarMeth { get; set; } = "!"; // PUR_VAR_METH (length: 1)
        public string SlsAcctNo { get; set; } // SLS_ACCT_NO (length: 20)
        public string SlsMeth { get; set; } = "!"; // SLS_METH (length: 1)
        public string CogsAcctNo { get; set; } // COGS_ACCT_NO (length: 20)
        public string CogsMeth { get; set; } = "!"; // COGS_METH (length: 1)
        public string RetAcctNo { get; set; } // RET_ACCT_NO (length: 20)
        public string RetMeth { get; set; } = "!"; // RET_METH (length: 1)
        public string CogsRetAcctNo { get; set; } // COGS_RET_ACCT_NO (length: 20)
        public string CogsRetMeth { get; set; } = "!"; // COGS_RET_METH (length: 1)
        public string RtvAcctNo { get; set; } // RTV_ACCT_NO (length: 20)
        public string RtvMeth { get; set; } = "!"; // RTV_METH (length: 1)
        public string AdjAcctNo { get; set; } // ADJ_ACCT_NO (length: 20)
        public string AdjMeth { get; set; } = "!"; // ADJ_METH (length: 1)
        public string CostCorrAcctNo { get; set; } // COST_CORR_ACCT_NO (length: 20)
        public string CostCorrMeth { get; set; } = "!"; // COST_CORR_METH (length: 1)
        public string DropshipInvAcctNo { get; set; } // DROPSHIP_INV_ACCT_NO (length: 20)
        public string PhysCntAcctNo { get; set; } // PHYS_CNT_ACCT_NO (length: 20)
        public string PhysCntMeth { get; set; } = "!"; // PHYS_CNT_METH (length: 1)
        public string RecvAdjAcctNo { get; set; } // RECV_ADJ_ACCT_NO (length: 20)
        public string RecvAdjMeth { get; set; } = "!"; // RECV_ADJ_METH (length: 1)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string XferClrAcctNo { get; set; } // XFER_CLR_ACCT_NO (length: 20)
        public string RtvAdjMeth { get; set; } = "!"; // RTV_ADJ_METH (length: 1)
        public string RtvAdjAcctNo { get; set; } // RTV_ADJ_ACCT_NO (length: 20)
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT
    }

}
// </auto-generated>

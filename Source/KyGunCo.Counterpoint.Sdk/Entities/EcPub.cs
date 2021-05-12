// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // EC_PUB
    public class EcPub
    {
        public string PubId { get; set; } // PUB_ID (Primary key) (length: 10)
        public string Descr { get; set; } // DESCR (length: 30)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 30)
        public string ItemFilt { get; set; } // ITEM_FILT (length: 2147483647)
        public string ItemPubMode { get; set; } = "!"; // ITEM_PUB_MODE (length: 1)
        public string ItemFiltTmplt { get; set; } // ITEM_FILT_TMPLT (length: 2147483647)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string ItemFiltText { get; set; } // ITEM_FILT_TEXT (length: 2147483647)
        public string CustFilt { get; set; } // CUST_FILT (length: 2147483647)
        public string CustFiltTmplt { get; set; } // CUST_FILT_TMPLT (length: 2147483647)
        public string CustFiltText { get; set; } // CUST_FILT_TEXT (length: 2147483647)
        public string CustPubMode { get; set; } = "!"; // CUST_PUB_MODE (length: 1)
        public string PubOrds { get; set; } = "N"; // PUB_ORDS (length: 1)
        public string OrdFilt { get; set; } // ORD_FILT (length: 2147483647)
        public string OrdFiltTmplt { get; set; } // ORD_FILT_TMPLT (length: 2147483647)
        public string OrdFiltText { get; set; } // ORD_FILT_TEXT (length: 2147483647)
        public string PubTktHist { get; set; } = "N"; // PUB_TKT_HIST (length: 1)
        public string TktHistFilt { get; set; } // TKT_HIST_FILT (length: 2147483647)
        public string TktHistFiltTmplt { get; set; } // TKT_HIST_FILT_TMPLT (length: 2147483647)
        public string TktHistFiltText { get; set; } // TKT_HIST_FILT_TEXT (length: 2147483647)
    }

}
// </auto-generated>

// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // AR_RENUM_CUST_GRP
    public class ArRenumCustGrp
    {
        public string RenumGrpId { get; set; } // RENUM_GRP_ID (Primary key) (length: 10)
        public string Descr { get; set; } // DESCR (length: 30)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 30)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Reverse navigation

        /// <summary>
        /// Child ArRenumCusts where [AR_RENUM_CUST].[RENUM_GRP_ID] point to this entity (FK_AR_RENUM_CUST_AR_RENUM_CUST_GRP)
        /// </summary>
        public virtual IList<ArRenumCust> ArRenumCusts { get; set; } = new List<ArRenumCust>(); // AR_RENUM_CUST.FK_AR_RENUM_CUST_AR_RENUM_CUST_GRP
    }

}
// </auto-generated>

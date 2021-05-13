// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_VI_BOUND_BOOK_INTAKE_OPEN_ACQ
    public class UserViBoundBookIntakeOpenAcq
    {
        public string DocNo { get; set; } // DOC_NO (length: 15)
        public string IntakeType { get; set; } // INTAKE_TYPE (length: 10)
        public string AcqCustNo { get; set; } // ACQ_CUST_NO (length: 15)
        public string Descr { get; set; } // DESCR (length: 30)
        public string SerNo { get; set; } // SER_NO (length: 30)
        public string AcqName { get; set; } // ACQ_NAME (length: 40)
        public string UserManufacturer { get; set; } // USER_MANUFACTURER (length: 30)
        public string UserModel { get; set; } // USER_MODEL (length: 30)
        public string UserAction { get; set; } // USER_ACTION (length: 30)
        public string UserCaliberGauge { get; set; } // USER_CALIBER_GAUGE (length: 30)
        public string UserAtfType { get; set; } // USER_ATF_TYPE (length: 30)
        public DateTime? AcqDate { get; set; } // ACQ_DATE
        public string IntakeNote { get; set; } // INTAKE_NOTE (length: 500)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string TktNo { get; set; } // TKT_NO (length: 15)
    }

}
// </auto-generated>
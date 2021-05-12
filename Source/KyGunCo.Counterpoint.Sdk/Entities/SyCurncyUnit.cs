// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // SY_CURNCY_UNITS
    public class SyCurncyUnit
    {
        public string CurncyCod { get; set; } // CURNCY_COD (Primary key) (length: 10)
        public int SeqNo { get; set; } // SEQ_NO (Primary key)
        public string CurncyUnit { get; set; } // CURNCY_UNIT (length: 10)
        public string UnitTyp { get; set; } // UNIT_TYP (length: 1)
        public decimal Val { get; set; } // VAL
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent SyCurncyCod pointed by [SY_CURNCY_UNITS].([CurncyCod]) (FK_SY_CURNCY_UNITS_SY_CURNCY_COD)
        /// </summary>
        public virtual SyCurncyCod SyCurncyCod { get; set; } // FK_SY_CURNCY_UNITS_SY_CURNCY_COD
    }

}
// </auto-generated>

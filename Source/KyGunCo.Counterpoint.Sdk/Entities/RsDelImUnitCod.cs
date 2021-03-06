// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // RS_DEL_IM_UNIT_COD
    public class RsDelImUnitCod
    {
        public int DelId { get; set; } // DEL_ID (Primary key)
        public byte? RsStat { get; set; } = 1; // RS_STAT
        public DateTime? DeleteDt { get; set; } = DateTime.UtcNow; // DELETE_DT
        public string Unit { get; set; } // UNIT (length: 15)
    }

}
// </auto-generated>

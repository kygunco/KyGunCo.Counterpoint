// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DISC_COD
    public class PsDiscCod
    {
        public long DiscId { get; set; } // DISC_ID (Primary key)
        public string DiscCod { get; set; } // DISC_COD (length: 10)
        public string DiscDescr { get; set; } // DISC_DESCR (length: 30)
        public string DiscTyp { get; set; } = "Q"; // DISC_TYP (length: 1)
        public decimal? DiscAmt { get; set; } // DISC_AMT
        public string ApplyTo { get; set; } = "H"; // APPLY_TO (length: 1)
        public decimal? MinDiscntblAmt { get; set; } // MIN_DISCNTBL_AMT
        public string DiscValFor { get; set; } = "I"; // DISC_VAL_FOR (length: 1)
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT
    }

}
// </auto-generated>

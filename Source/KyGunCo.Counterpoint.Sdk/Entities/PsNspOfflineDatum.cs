// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_NSP_OFFLINE_DATA
    public class PsNspOfflineDatum
    {
        public string NspKey { get; set; } // NSP_KEY (Primary key) (length: 250)
        public string NspType { get; set; } // NSP_TYPE (Primary key) (length: 250)
        public string Value { get; set; } // VALUE (length: 7000)
        public byte[] ValueEnc { get; set; } // VALUE_ENC (length: 7000)
    }

}
// </auto-generated>
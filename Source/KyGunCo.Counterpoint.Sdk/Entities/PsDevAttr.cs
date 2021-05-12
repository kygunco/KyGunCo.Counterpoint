// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DEV_ATTR
    public class PsDevAttr
    {
        public long DevCfgId { get; set; } // DEV_CFG_ID (Primary key)
        public string AttrKey { get; set; } // ATTR_KEY (Primary key) (length: 250)
        public string AttrVal { get; set; } // ATTR_VAL (length: 8000)

        // Foreign keys

        /// <summary>
        /// Parent PsDevCfg pointed by [PS_DEV_ATTR].([DevCfgId]) (FK_PS_DEV_ATTR_PS_DEV_CFG)
        /// </summary>
        public virtual PsDevCfg PsDevCfg { get; set; } // FK_PS_DEV_ATTR_PS_DEV_CFG
    }

}
// </auto-generated>

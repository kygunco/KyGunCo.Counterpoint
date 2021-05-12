// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DEV_LD_EVENT_TYPE
    public class PsDevLdEventType
    {
        public long LdEventTypeId { get; set; } // LD_EVENT_TYPE_ID (Primary key)
        public string LdEventTypeNam { get; set; } // LD_EVENT_TYPE_NAM (length: 40)
        public string Descr { get; set; } // DESCR (length: 50)
        public string XmlNodeName { get; set; } // XML_NODE_NAME (length: 40)
        public string FieldTypes { get; set; } // FIELD_TYPES (length: 50)
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT

        // Reverse navigation

        /// <summary>
        /// Child PsDevLdMsgs where [PS_DEV_LD_MSG].[LD_EVENT_TYPE_ID] point to this entity (FK_PS_DEV_LD_MSG_PS_DEV_LD_EVENT_TYPE)
        /// </summary>
        public virtual IList<PsDevLdMsg> PsDevLdMsgs { get; set; } = new List<PsDevLdMsg>(); // PS_DEV_LD_MSG.FK_PS_DEV_LD_MSG_PS_DEV_LD_EVENT_TYPE
    }

}
// </auto-generated>

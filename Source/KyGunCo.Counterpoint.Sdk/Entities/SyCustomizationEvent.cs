// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // SY_CUSTOMIZATION_EVENT
    public class SyCustomizationEvent
    {
        public long EventId { get; set; } // EVENT_ID (Primary key)
        public string EventNam { get; set; } // EVENT_NAM (length: 128)
        public string Descr { get; set; } // DESCR (length: 80)
        public string Active { get; set; } = "N"; // ACTIVE (length: 1)
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT

        // Reverse navigation

        /// <summary>
        /// Child SyCustomizationEventHandlers where [SY_CUSTOMIZATION_EVENT_HANDLER].[EVENT_ID] point to this entity (FK_SY_CUSTOMIZATION_EVENT_HANDLER_SY_CUSTOMIZATION_EVENT)
        /// </summary>
        public virtual IList<SyCustomizationEventHandler> SyCustomizationEventHandlers { get; set; } = new List<SyCustomizationEventHandler>(); // SY_CUSTOMIZATION_EVENT_HANDLER.FK_SY_CUSTOMIZATION_EVENT_HANDLER_SY_CUSTOMIZATION_EVENT
    }

}
// </auto-generated>

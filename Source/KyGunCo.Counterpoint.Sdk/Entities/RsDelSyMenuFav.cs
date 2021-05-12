// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // RS_DEL_SY_MENU_FAV
    public class RsDelSyMenuFav
    {
        public int DelId { get; set; } // DEL_ID (Primary key)
        public byte? RsStat { get; set; } = 1; // RS_STAT
        public DateTime? DeleteDt { get; set; } = DateTime.UtcNow; // DELETE_DT
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string MenuItemId { get; set; } // MENU_ITEM_ID (length: 250)
    }

}
// </auto-generated>

// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PS_ITEM_MONTHLY_HIST
    public class ViPsItemMonthlyHist
    {
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string MonthAndYear { get; set; } // Month_and_Year (length: 40)
        public decimal? Returns { get; set; } // Returns
        public decimal? SalesExclReturns { get; set; } // Sales_excl_returns
        public decimal? Sales { get; set; } // Sales
        public decimal? QtySold { get; set; } // Qty_Sold
        public int? Tickets { get; set; } // Tickets
        public decimal? AvgTicket { get; set; } // Avg_Ticket
        public decimal? PctReturns { get; set; } // Pct_Returns
        public int PriorMonths { get; set; } // PriorMonths
    }

}
// </auto-generated>

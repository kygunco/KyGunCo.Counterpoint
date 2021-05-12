// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_ITEM_UPLOAD
    public class UserItemUpload
    {
        public int Id { get; set; } // Id (Primary key)
        public string Upc { get; set; } // UPC (length: 20)
        public string Brand { get; set; } // Brand (length: 30)
        public string Style { get; set; } // Style (length: 80)
        public string ItemNo { get; set; } // Item_No (length: 20)
        public string Description { get; set; } // Description (length: 80)
        public string ShortDescription { get; set; } // Short_Description (length: 15)
        public string LongDescription { get; set; } // Long_Description (length: 50)
        public string AdditionalDescription2 { get; set; } // Additional_Description_2 (length: 80)
        public string AdditionalDescription3 { get; set; } // Additional_Description_3 (length: 80)
        public decimal? Price1 { get; set; } // Price_1
        public decimal? WebPrice { get; set; } // Web_Price
        public decimal? GunShowPrice { get; set; } // Gun_Show_Price
        public decimal? Msrp { get; set; } // MSRP
        public decimal? Cost { get; set; } // Cost
        public string Taxable { get; set; } = "Y"; // Taxable (length: 1)
        public string Category { get; set; } // Category (length: 30)
        public string SubCategory { get; set; } // Sub_Category (length: 30)
        public string Shipping { get; set; } // Shipping (length: 30)
        public string ShippingSurcharge { get; set; } // Shipping_Surcharge (length: 30)
        public string FeedMarkup { get; set; } // Feed_Markup (length: 30)
        public string Map { get; set; } // MAP (length: 30)
        public string Backorder { get; set; } // Backorder (length: 30)
        public string Status { get; set; } // Status (length: 1)
        public decimal? OrderMax { get; set; } // Order_Max
        public decimal? WebAvailability { get; set; } // Web_Availability
        public decimal? Weight { get; set; } // Weight
        public decimal? QuantityAvailable { get; set; } // Quantity_Available
        public string EcommerceItem { get; set; } // Ecommerce_Item (length: 1)
        public string EcommerceCategory { get; set; } // Ecommerce_Category (length: 30)
        public string StockingUnit { get; set; } = "EACH"; // Stocking_Unit (length: 15)
        public decimal? MinQuantity { get; set; } // Min_Quantity
        public decimal? MaxQuantity { get; set; } // Max_Quantity
        public string IsFirearm { get; set; } = "N"; // Is_Firearm (length: 1)
        public string IsUsed { get; set; } // Is_Used (length: 1)
        public string AtfType { get; set; } // ATF_Type (length: 30)
        public string Manufacturer { get; set; } // Manufacturer (length: 30)
        public string Model { get; set; } // Model (length: 30)
        public string CaliberGauge { get; set; } // Caliber_Gauge (length: 30)
        public string Hand { get; set; } // Hand (length: 30)
        public string Finish { get; set; } // Finish (length: 30)
        public string Action { get; set; } // Action (length: 30)
        public string MagCapacity { get; set; } // Mag_Capacity (length: 10)
        public string BarrelLength { get; set; } // Barrel_Length (length: 10)
        public string OverallLength { get; set; } // Overall_Length (length: 10)
        public string TrackingMethod { get; set; } = "N"; // Tracking_Method (length: 1)
        public string ItemType { get; set; } = "I"; // Item_Type (length: 1)
        public decimal? ShippingWeight { get; set; } // Shipping_Weight
    }

}
// </auto-generated>

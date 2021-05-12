// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_GFT_RGSTRY_HDR
    public class PsGftRgstryHdr
    {
        public long GftRgstryId { get; set; } = 0; // GFT_RGSTRY_ID (Primary key)
        public string GftRgstryCpolId { get; set; } // GFT_RGSTRY_CPOL_ID (length: 15)
        public string GftRgstryEvntTyp { get; set; } // GFT_RGSTRY_EVNT_TYP (length: 10)
        public string EventNam { get; set; } // EVENT_NAM (length: 80)
        public DateTime EventDat { get; set; } // EVENT_DAT
        public DateTime? ExpDat { get; set; } // EXP_DAT
        public string EventCity { get; set; } // EVENT_CITY (length: 20)
        public string EventState { get; set; } // EVENT_STATE (length: 10)
        public string IsEcommReg { get; set; } = "N"; // IS_ECOMM_REG (length: 1)
        public string CustNo { get; set; } // CUST_NO (length: 15)
        public string OrigStrId { get; set; } // ORIG_STR_ID (length: 10)
        public string Reg1FstNam { get; set; } // REG1_FST_NAM (length: 15)
        public string Reg1LstNam { get; set; } // REG1_LST_NAM (length: 25)
        public string Reg2FstNam { get; set; } // REG2_FST_NAM (length: 15)
        public string Reg2LstNam { get; set; } // REG2_LST_NAM (length: 25)
        public string Commnt { get; set; } // COMMNT (length: 250)
        public string ShipAdrs1 { get; set; } // SHIP_ADRS_1 (length: 40)
        public string ShipAdrs2 { get; set; } // SHIP_ADRS_2 (length: 40)
        public string ShipCity { get; set; } // SHIP_CITY (length: 20)
        public string ShipState { get; set; } // SHIP_STATE (length: 10)
        public string ShipZipCod { get; set; } // SHIP_ZIP_COD (length: 15)
        public string ShipCntry { get; set; } // SHIP_CNTRY (length: 20)
        public string ContctPhone { get; set; } // CONTCT_PHONE (length: 25)
        public string EcommNxtHdrPubMode { get; set; } = "N"; // ECOMM_NXT_HDR_PUB_MODE (length: 1)
        public DateTime? EcommLstPubDt { get; set; } // ECOMM_LST_PUB_DT
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT

        // Reverse navigation

        /// <summary>
        /// Child PsGftRgstryLins where [PS_GFT_RGSTRY_LIN].[GFT_RGSTRY_ID] point to this entity (FK_PS_GFT_RGSTRY_LIN_PS_GFT_RGSTRY_HDR)
        /// </summary>
        public virtual IList<PsGftRgstryLin> PsGftRgstryLins { get; set; } = new List<PsGftRgstryLin>(); // PS_GFT_RGSTRY_LIN.FK_PS_GFT_RGSTRY_LIN_PS_GFT_RGSTRY_HDR

        // Foreign keys

        /// <summary>
        /// Parent PsGftRgstryEvntTyp pointed by [PS_GFT_RGSTRY_HDR].([GftRgstryEvntTyp]) (FK_PS_GFT_RGSTRY_HDR_PS_GFT_RGSTRY_EVNT_TYP)
        /// </summary>
        public virtual PsGftRgstryEvntTyp PsGftRgstryEvntTyp { get; set; } // FK_PS_GFT_RGSTRY_HDR_PS_GFT_RGSTRY_EVNT_TYP
    }

}
// </auto-generated>

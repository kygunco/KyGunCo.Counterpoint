// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_HOT_COLD_RPT_WRK
    public class ImHotColdRptWrk
    {
        public string SessId { get; set; } // SESS_ID (Primary key) (length: 40)
        public string GrpId { get; set; } // GRP_ID (Primary key) (length: 50)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public string HasMiscItem { get; set; } // HAS_MISC_ITEM (length: 1)
        public string HasNonmiscItem { get; set; } // HAS_NONMISC_ITEM (length: 1)
        public decimal? CurrQtyOnHnd { get; set; } // CURR_QTY_ON_HND
        public decimal? CurrCostOnHnd { get; set; } // CURR_COST_ON_HND
        public decimal? CurrRetlOnHnd { get; set; } // CURR_RETL_ON_HND
        public decimal? CurrQtyOnPo { get; set; } // CURR_QTY_ON_PO
        public decimal? CurrCostOnPo { get; set; } // CURR_COST_ON_PO
        public decimal? CurrRetlOnPo { get; set; } // CURR_RETL_ON_PO
        public DateTime? FstRecvDat { get; set; } // FST_RECV_DAT
        public DateTime? LstRecvDat { get; set; } // LST_RECV_DAT
        public DateTime? FstSalDat { get; set; } // FST_SAL_DAT
        public DateTime? LstSalDat { get; set; } // LST_SAL_DAT
        public DateTime? LstOrdDat { get; set; } // LST_ORD_DAT
        public DateTime? NxtExpectdDat { get; set; } // NXT_EXPECTD_DAT
        public decimal? PrdBegQtyOnHnd { get; set; } // PRD_BEG_QTY_ON_HND
        public decimal? PrdTrxQty { get; set; } // PRD_TRX_QTY
        public decimal? PrdTrxQtyAdj { get; set; } // PRD_TRX_QTY_ADJ
        public decimal? PrdTrxQtyRecvd { get; set; } // PRD_TRX_QTY_RECVD
        public decimal? PrdTrxQtyXferd { get; set; } // PRD_TRX_QTY_XFERD
        public decimal? PrdEndQtyOnHnd { get; set; } // PRD_END_QTY_ON_HND
        public decimal? PrdAvgQtyOnHnd { get; set; } // PRD_AVG_QTY_ON_HND
        public decimal? PrdBegCostOnHnd { get; set; } // PRD_BEG_COST_ON_HND
        public decimal? PrdTrxCost { get; set; } // PRD_TRX_COST
        public decimal? PrdTrxCostAdj { get; set; } // PRD_TRX_COST_ADJ
        public decimal? PrdTrxCostRecvd { get; set; } // PRD_TRX_COST_RECVD
        public decimal? PrdTrxCostXferd { get; set; } // PRD_TRX_COST_XFERD
        public decimal? PrdEndCostOnHnd { get; set; } // PRD_END_COST_ON_HND
        public decimal? PrdAvgCostOnHnd { get; set; } // PRD_AVG_COST_ON_HND
        public decimal? PrdBegRetlOnHnd { get; set; } // PRD_BEG_RETL_ON_HND
        public decimal? PrdTrxRetl { get; set; } // PRD_TRX_RETL
        public decimal? PrdTrxRetlAdj { get; set; } // PRD_TRX_RETL_ADJ
        public decimal? PrdTrxRetlRecvd { get; set; } // PRD_TRX_RETL_RECVD
        public decimal? PrdTrxRetlXferd { get; set; } // PRD_TRX_RETL_XFERD
        public decimal? PrdMkdns { get; set; } // PRD_MKDNS
        public decimal? PrdEndRetlOnHnd { get; set; } // PRD_END_RETL_ON_HND
        public decimal? PrdAvgRetlOnHnd { get; set; } // PRD_AVG_RETL_ON_HND
        public decimal? PrdQtySoldNoRets { get; set; } // PRD_QTY_SOLD_NO_RETS
        public decimal? PrdCostSoldNoRets { get; set; } // PRD_COST_SOLD_NO_RETS
        public decimal? PrdRetlSoldNoRets { get; set; } // PRD_RETL_SOLD_NO_RETS
        public decimal? PrdSlsNoRets { get; set; } // PRD_SLS_NO_RETS
        public decimal? PrdQtyRetd { get; set; } // PRD_QTY_RETD
        public decimal? PrdCostRetd { get; set; } // PRD_COST_RETD
        public decimal? PrdRetlRetd { get; set; } // PRD_RETL_RETD
        public decimal? PrdRets { get; set; } // PRD_RETS
        public decimal? PrdSlsIfAtRetlPrc { get; set; } // PRD_SLS_IF_AT_RETL_PRC
        public decimal? PrdSlsIfAtRegPrc { get; set; } // PRD_SLS_IF_AT_REG_PRC
        public decimal? PrdSlsIfAtCalcPrc { get; set; } // PRD_SLS_IF_AT_CALC_PRC
        public decimal? PrdQtySoldAtRetl { get; set; } // PRD_QTY_SOLD_AT_RETL
        public decimal? PrdCostSoldAtRetl { get; set; } // PRD_COST_SOLD_AT_RETL
        public decimal? PrdRetlSoldAtRetl { get; set; } // PRD_RETL_SOLD_AT_RETL
        public decimal? PrdSlsAtRetl { get; set; } // PRD_SLS_AT_RETL
        public decimal? PrdQtySoldAtRegPrc { get; set; } // PRD_QTY_SOLD_AT_REG_PRC
        public decimal? PrdCostSoldAtRegPrc { get; set; } // PRD_COST_SOLD_AT_REG_PRC
        public decimal? PrdRetlSoldAtRegPrc { get; set; } // PRD_RETL_SOLD_AT_REG_PRC
        public decimal? PrdSlsAtRegPrc { get; set; } // PRD_SLS_AT_REG_PRC
        public decimal? PrdQtySoldAtCalcPrc { get; set; } // PRD_QTY_SOLD_AT_CALC_PRC
        public decimal? PrdCostSoldAtCalcPrc { get; set; } // PRD_COST_SOLD_AT_CALC_PRC
        public decimal? PrdRetlSoldAtCalcPrc { get; set; } // PRD_RETL_SOLD_AT_CALC_PRC
        public decimal? PrdSlsAtCalcPrc { get; set; } // PRD_SLS_AT_CALC_PRC
        public int? PrdTrxCnt { get; set; } // PRD_TRX_CNT
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public decimal? PrdSlsIfAtPrc1 { get; set; } // PRD_SLS_IF_AT_PRC_1
        public decimal? PrdQtySoldAtPrc1 { get; set; } // PRD_QTY_SOLD_AT_PRC_1
        public decimal? PrdCostSoldAtPrc1 { get; set; } // PRD_COST_SOLD_AT_PRC_1
        public decimal? PrdRetlSoldAtPrc1 { get; set; } // PRD_RETL_SOLD_AT_PRC_1
        public decimal? PrdSlsAtPrc1 { get; set; } // PRD_SLS_AT_PRC_1
        public decimal? PrdTrxQtyBomNet { get; set; } // PRD_TRX_QTY_BOM_NET
        public decimal? PrdTrxCostBomNet { get; set; } // PRD_TRX_COST_BOM_NET
        public decimal? PrdTrxRetlBomNet { get; set; } // PRD_TRX_RETL_BOM_NET
        public DateTime? PrdFstTrxDatNoMkdns { get; set; } // PRD_FST_TRX_DAT_NO_MKDNS
        public DateTime? PrdLstTrxDatNoMkdns { get; set; } // PRD_LST_TRX_DAT_NO_MKDNS
        public DateTime? PrdFstMkdnDat { get; set; } // PRD_FST_MKDN_DAT
        public DateTime? PrdLstMkdnDat { get; set; } // PRD_LST_MKDN_DAT
    }

}
// </auto-generated>

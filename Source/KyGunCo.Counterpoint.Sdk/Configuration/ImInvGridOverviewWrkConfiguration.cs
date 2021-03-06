// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_INV_GRID_OVERVIEW_WRK
    public class ImInvGridOverviewWrkConfiguration : IEntityTypeConfiguration<ImInvGridOverviewWrk>
    {
        public void Configure(EntityTypeBuilder<ImInvGridOverviewWrk> builder)
        {
            builder.ToTable("IM_INV_GRID_OVERVIEW_WRK", "dbo");
            builder.HasKey(x => new { x.SessId, x.ItemNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_IM_INV_GRID_OVERVIEW_WRK").IsClustered();

            builder.Property(x => x.SessId).HasColumnName(@"SESS_ID").HasColumnType("varchar(40)").IsRequired().IsUnicode(false).HasMaxLength(40).ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CategCod).HasColumnName(@"CATEG_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SubcatCod).HasColumnName(@"SUBCAT_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.VendNo).HasColumnName(@"VEND_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.QtyDecs).HasColumnName(@"QTY_DECS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DimCount).HasColumnName(@"DIM_COUNT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.TotQtyOnHnd).HasColumnName(@"TOT_QTY_ON_HND").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyOnPo).HasColumnName(@"QTY_ON_PO").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.MinQty).HasColumnName(@"MIN_QTY").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.MaxQty).HasColumnName(@"MAX_QTY").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyAvail).HasColumnName(@"QTY_AVAIL").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CellExtCost).HasColumnName(@"CELL_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.CellExtPrc1).HasColumnName(@"CELL_EXT_PRC_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.EarliestPostDat).HasColumnName(@"EARLIEST_POST_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LatestPostDat).HasColumnName(@"LATEST_POST_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.DaysInPeriod).HasColumnName(@"DAYS_IN_PERIOD").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.WeeksInPeriod).HasColumnName(@"WEEKS_IN_PERIOD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.WeeksOnHnd).HasColumnName(@"WEEKS_ON_HND").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Sales).HasColumnName(@"SALES").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ExtCost).HasColumnName(@"EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.GrsPft).HasColumnName(@"GRS_PFT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotQtySold).HasColumnName(@"TOT_QTY_SOLD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.MuPct).HasColumnName(@"MU_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.GrsPftPct).HasColumnName(@"GRS_PFT_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.DisplayLabel1).HasColumnName(@"DisplayLabel1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DisplayLabel2).HasColumnName(@"DisplayLabel2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DisplayLabel3).HasColumnName(@"DisplayLabel3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DisplayDim1Value).HasColumnName(@"DisplayDim1Value").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DisplayDim2Value).HasColumnName(@"DisplayDim2Value").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DisplayDim3Value).HasColumnName(@"DisplayDim3Value").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DisplayDim1SeqNo).HasColumnName(@"DisplayDim1SeqNo").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DisplayDim2SeqNo).HasColumnName(@"DisplayDim2SeqNo").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DisplayDim3SeqNo).HasColumnName(@"DisplayDim3SeqNo").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>

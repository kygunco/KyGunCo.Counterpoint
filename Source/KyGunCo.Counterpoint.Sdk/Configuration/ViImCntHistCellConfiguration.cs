// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_IM_CNT_HIST_CELL
    public class ViImCntHistCellConfiguration : IEntityTypeConfiguration<ViImCntHistCell>
    {
        public void Configure(EntityTypeBuilder<ViImCntHistCell> builder)
        {
            builder.ToView("VI_IM_CNT_HIST_CELL", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CntQty1).HasColumnName(@"CNT_QTY_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CntQty2).HasColumnName(@"CNT_QTY_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CntQty3).HasColumnName(@"CNT_QTY_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CntQty4).HasColumnName(@"CNT_QTY_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CntQty5).HasColumnName(@"CNT_QTY_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CntQty6).HasColumnName(@"CNT_QTY_6").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.FrzQtyOnHnd).HasColumnName(@"FRZ_QTY_ON_HND").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyCntd).HasColumnName(@"QTY_CNTD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyOnHndBefore).HasColumnName(@"QTY_ON_HND_BEFORE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.AssumedCnt).HasColumnName(@"ASSUMED_CNT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.NoOfCnts).HasColumnName(@"NO_OF_CNTS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DisplayLabel1).HasColumnName(@"DisplayLabel1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DisplayLabel2).HasColumnName(@"DisplayLabel2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DisplayLabel3).HasColumnName(@"DisplayLabel3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DisplayDim1Value).HasColumnName(@"DisplayDim1Value").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DisplayDim2Value).HasColumnName(@"DisplayDim2Value").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DisplayDim3Value).HasColumnName(@"DisplayDim3Value").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DisplayDim1SeqNo).HasColumnName(@"DisplayDim1SeqNo").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DisplayDim2SeqNo).HasColumnName(@"DisplayDim2SeqNo").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DisplayDim3SeqNo).HasColumnName(@"DisplayDim3SeqNo").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.TotCntQty).HasColumnName(@"TOT_CNT_QTY").HasColumnType("decimal(38,15)").IsRequired(false);
        }
    }

}
// </auto-generated>
// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PO_CUST_ORD_WRK_CELL
    public class ViPoCustOrdWrkCellConfiguration : IEntityTypeConfiguration<ViPoCustOrdWrkCell>
    {
        public void Configure(EntityTypeBuilder<ViPoCustOrdWrkCell> builder)
        {
            builder.ToView("VI_PO_CUST_ORD_WRK_CELL", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.SessId).HasColumnName(@"SESS_ID").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.TktLinSeqNo).HasColumnName(@"TKT_LIN_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Qty).HasColumnName(@"QTY").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyOnHnd).HasColumnName(@"QTY_ON_HND").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyOnPo).HasColumnName(@"QTY_ON_PO").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyCommit).HasColumnName(@"QTY_COMMIT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyOnBo).HasColumnName(@"QTY_ON_BO").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.MinQty).HasColumnName(@"MIN_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.MaxQty).HasColumnName(@"MAX_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.QtyOnSo).HasColumnName(@"QTY_ON_SO").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyOnOrd).HasColumnName(@"QTY_ON_ORD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyOnLwy).HasColumnName(@"QTY_ON_LWY").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.NetQty).HasColumnName(@"NET_QTY").HasColumnType("decimal(18,4)").IsRequired(false);
            builder.Property(x => x.QtyAvail).HasColumnName(@"QTY_AVAIL").HasColumnType("decimal(16,4)").IsRequired(false);
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.Dim1).HasColumnName(@"DIM_1").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim2).HasColumnName(@"DIM_2").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim3).HasColumnName(@"DIM_3").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
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

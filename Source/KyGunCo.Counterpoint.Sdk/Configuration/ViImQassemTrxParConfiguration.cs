// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_IM_QASSEM_TRX_PAR
    public class ViImQassemTrxParConfiguration : IEntityTypeConfiguration<ViImQassemTrxPar>
    {
        public void Configure(EntityTypeBuilder<ViImQassemTrxPar> builder)
        {
            builder.ToView("VI_IM_QASSEM_TRX_PAR", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TrxDat).HasColumnName(@"TRX_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.DocNo).HasColumnName(@"DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Qty).HasColumnName(@"QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.Unit).HasColumnName(@"UNIT").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CellDescr).HasColumnName(@"CELL_DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ErrRef).HasColumnName(@"ERR_REF").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
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

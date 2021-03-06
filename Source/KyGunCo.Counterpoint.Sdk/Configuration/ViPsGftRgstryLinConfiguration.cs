// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_GFT_RGSTRY_LIN
    public class ViPsGftRgstryLinConfiguration : IEntityTypeConfiguration<ViPsGftRgstryLin>
    {
        public void Configure(EntityTypeBuilder<ViPsGftRgstryLin> builder)
        {
            builder.ToView("VI_PS_GFT_RGSTRY_LIN", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.GftRgstryId).HasColumnName(@"GFT_RGSTRY_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.GftItemNo).HasColumnName(@"GFT_ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.QtyReqstdUnitFlg).HasColumnName(@"QTY_REQSTD_UNIT_FLG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.QtyReqstd).HasColumnName(@"QTY_REQSTD").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyFilled).HasColumnName(@"QTY_FILLED").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyRemain).HasColumnName(@"QTY_REMAIN").HasColumnType("decimal(16,4)").IsRequired(false);
            builder.Property(x => x.UnitName).HasColumnName(@"_UNIT_NAME").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Prc1).HasColumnName(@"PRC_1").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.CategCod).HasColumnName(@"CATEG_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SubcatCod).HasColumnName(@"SUBCAT_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.QtyDecs).HasColumnName(@"QTY_DECS").HasColumnType("int").IsRequired();
            builder.Property(x => x.DimCount).HasColumnName(@"DIM_COUNT").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.TrkMeth).HasColumnName(@"TRK_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
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

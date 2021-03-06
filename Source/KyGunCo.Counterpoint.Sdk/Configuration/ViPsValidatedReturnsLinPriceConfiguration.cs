// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_VALIDATED_RETURNS_LIN_PRICE
    public class ViPsValidatedReturnsLinPriceConfiguration : IEntityTypeConfiguration<ViPsValidatedReturnsLinPrice>
    {
        public void Configure(EntityTypeBuilder<ViPsValidatedReturnsLinPrice> builder)
        {
            builder.ToView("VI_PS_VALIDATED_RETURNS_LIN_PRICE", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.PrcSeqNo).HasColumnName(@"PRC_SEQ_NO").HasColumnType("smallint").IsRequired();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.QtyPrcd).HasColumnName(@"QTY_PRCD").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.UnitPrc).HasColumnName(@"UNIT_PRC").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.PrcGrpTyp).HasColumnName(@"PRC_GRP_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PrcGrpCod).HasColumnName(@"PRC_GRP_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PrcGrpDescr).HasColumnName(@"PRC_GRP_DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PrcRulDescr).HasColumnName(@"PRC_RUL_DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PrcRulSeqNo).HasColumnName(@"PRC_RUL_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.PrcBrkDescr).HasColumnName(@"PRC_BRK_DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.PrcJustStr).HasColumnName(@"PRC_JUST_STR").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
        }
    }

}
// </auto-generated>

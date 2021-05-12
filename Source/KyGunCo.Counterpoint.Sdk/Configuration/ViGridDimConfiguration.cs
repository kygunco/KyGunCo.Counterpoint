// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_GRID_DIMS
    public class ViGridDimConfiguration : IEntityTypeConfiguration<ViGridDim>
    {
        public void Configure(EntityTypeBuilder<ViGridDim> builder)
        {
            builder.ToView("VI_GRID_DIMS", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim1).HasColumnName(@"DIM_1").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim1SeqNo).HasColumnName(@"DIM_1_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim2).HasColumnName(@"DIM_2").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim2SeqNo).HasColumnName(@"DIM_2_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim3).HasColumnName(@"DIM_3").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim3SeqNo).HasColumnName(@"DIM_3_SEQ_NO").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>

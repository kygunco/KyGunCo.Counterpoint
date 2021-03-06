// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_DIM_3
    public class ViDim3Configuration : IEntityTypeConfiguration<ViDim3>
    {
        public void Configure(EntityTypeBuilder<ViDim3> builder)
        {
            builder.ToView("VI_DIM_3", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.Dim3).HasColumnName(@"DIM_3").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
        }
    }

}
// </auto-generated>

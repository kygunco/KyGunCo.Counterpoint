// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_DIM_2
    public class ViDim2Configuration : IEntityTypeConfiguration<ViDim2>
    {
        public void Configure(EntityTypeBuilder<ViDim2> builder)
        {
            builder.ToView("VI_DIM_2", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.Dim2).HasColumnName(@"DIM_2").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
        }
    }

}
// </auto-generated>

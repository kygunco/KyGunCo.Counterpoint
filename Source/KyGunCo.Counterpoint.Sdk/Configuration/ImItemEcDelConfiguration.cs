// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_ITEM_EC_DEL
    public class ImItemEcDelConfiguration : IEntityTypeConfiguration<ImItemEcDel>
    {
        public void Configure(EntityTypeBuilder<ImItemEcDel> builder)
        {
            builder.ToTable("IM_ITEM_EC_DEL", "dbo");
            builder.HasKey(x => x.OldItemNo).HasName("PK_IM_ITEM_EC_DEL").IsClustered();

            builder.Property(x => x.OldItemNo).HasColumnName(@"OLD_ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.DelUtcDt).HasColumnName(@"DEL_UTC_DT").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_ECOMM_ATTR_TYPE
    public class UserEcommAttrTypeConfiguration : IEntityTypeConfiguration<UserEcommAttrType>
    {
        public void Configure(EntityTypeBuilder<UserEcommAttrType> builder)
        {
            builder.ToTable("USER_ECOMM_ATTR_TYPE", "dbo");
            builder.HasKey(x => x.EcommAttrType).HasName("PK_USER_ECOMM_ATTR_TYPE").IsClustered();

            builder.Property(x => x.EcommAttrType).HasColumnName(@"ECOMM_ATTR_TYPE").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();
        }
    }

}
// </auto-generated>

// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // RS_SITE_STR
    public class RsSiteStrConfiguration : IEntityTypeConfiguration<RsSiteStr>
    {
        public void Configure(EntityTypeBuilder<RsSiteStr> builder)
        {
            builder.ToTable("RS_SITE_STR", "dbo");
            builder.HasKey(x => x.KeyId).HasName("PK_RS_SITE_STR").IsClustered();

            builder.Property(x => x.KeyId).HasColumnName(@"KEY_ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AddedDt).HasColumnName(@"ADDED_DT").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>

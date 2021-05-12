// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_DB
    public class SyDbConfiguration : IEntityTypeConfiguration<SyDb>
    {
        public void Configure(EntityTypeBuilder<SyDb> builder)
        {
            builder.ToTable("SY_DB", "dbo");
            builder.HasKey(x => x.DbId).HasName("PK_SY_DB").IsClustered();

            builder.Property(x => x.DbId).HasColumnName(@"DB_ID").HasColumnType("smallint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DbName).HasColumnName(@"DB_NAME").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.MsSiteId).HasColumnName(@"MS_SITE_ID").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>

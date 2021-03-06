// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_KEY_CTR
    public class SyKeyCtrConfiguration : IEntityTypeConfiguration<SyKeyCtr>
    {
        public void Configure(EntityTypeBuilder<SyKeyCtr> builder)
        {
            builder.ToTable("SY_KEY_CTR", "dbo");
            builder.HasKey(x => x.KeyId).HasName("PK_SY_KEY_CTR").IsClustered();

            builder.Property(x => x.KeyId).HasColumnName(@"KEY_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.NextKey).HasColumnName(@"NEXT_KEY").HasColumnType("bigint").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.SyKey).WithOne(b => b.SyKeyCtr).HasForeignKey<SyKeyCtr>(c => c.KeyId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SY_KEY_CTR_SY_KEY");
        }
    }

}
// </auto-generated>

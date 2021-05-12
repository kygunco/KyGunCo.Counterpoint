// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // KeyValueData
    public class KeyValueDataConfiguration : IEntityTypeConfiguration<KeyValueData>
    {
        public void Configure(EntityTypeBuilder<KeyValueData> builder)
        {
            builder.ToTable("KeyValueData", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__KeyValue__3214EC07F4248EA6").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Key).HasColumnName(@"Key").HasColumnType("varchar(8000)").IsRequired().IsUnicode(false).HasMaxLength(8000);
            builder.Property(x => x.Type).HasColumnName(@"Type").HasColumnType("varchar(8000)").IsRequired().IsUnicode(false).HasMaxLength(8000);
            builder.Property(x => x.Value).HasColumnName(@"Value").HasColumnType("varchar(max)").IsRequired(false).IsUnicode(false);

            builder.HasIndex(x => new { x.Key, x.Type }).HasDatabaseName("idx_keyvaluedata_key_type");
        }
    }

}
// </auto-generated>

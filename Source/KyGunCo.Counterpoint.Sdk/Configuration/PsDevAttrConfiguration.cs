// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_DEV_ATTR
    public class PsDevAttrConfiguration : IEntityTypeConfiguration<PsDevAttr>
    {
        public void Configure(EntityTypeBuilder<PsDevAttr> builder)
        {
            builder.ToTable("PS_DEV_ATTR", "dbo");
            builder.HasKey(x => new { x.DevCfgId, x.AttrKey }).HasName("PK_PS_DEV_ATTR").IsClustered();

            builder.Property(x => x.DevCfgId).HasColumnName(@"DEV_CFG_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.AttrKey).HasColumnName(@"ATTR_KEY").HasColumnType("varchar(250)").IsRequired().IsUnicode(false).HasMaxLength(250).ValueGeneratedNever();
            builder.Property(x => x.AttrVal).HasColumnName(@"ATTR_VAL").HasColumnType("varchar(8000)").IsRequired(false).IsUnicode(false).HasMaxLength(8000);

            // Foreign keys
            builder.HasOne(a => a.PsDevCfg).WithMany(b => b.PsDevAttrs).HasForeignKey(c => c.DevCfgId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_DEV_ATTR_PS_DEV_CFG");
        }
    }

}
// </auto-generated>

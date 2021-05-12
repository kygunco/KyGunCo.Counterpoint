// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_GFT_RGSTRY_LIN_MSD
    public class PsGftRgstryLinMsdConfiguration : IEntityTypeConfiguration<PsGftRgstryLinMsd>
    {
        public void Configure(EntityTypeBuilder<PsGftRgstryLinMsd> builder)
        {
            builder.ToTable("PS_GFT_RGSTRY_LIN_MSD", "dbo");
            builder.HasKey(x => new { x.SiteId, x.GftRgstryId, x.SeqNo }).HasName("PK_PS_GFT_RGSTRY_LIN_MSD").IsClustered();

            builder.Property(x => x.SiteId).HasColumnName(@"SITE_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.GftRgstryId).HasColumnName(@"GFT_RGSTRY_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.QtyFilled).HasColumnName(@"QTY_FILLED").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyFilledDelta).HasColumnName(@"QTY_FILLED_DELTA").HasColumnType("decimal(15,4)").IsRequired(false);
        }
    }

}
// </auto-generated>

// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_LOC_HIST
    public class ImLocHistConfiguration : IEntityTypeConfiguration<ImLocHist>
    {
        public void Configure(EntityTypeBuilder<ImLocHist> builder)
        {
            builder.ToTable("IM_LOC_HIST", "dbo");
            builder.HasKey(x => x.LocId).HasName("PK_IM_LOC_HIST").IsClustered();

            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
        }
    }

}
// </auto-generated>

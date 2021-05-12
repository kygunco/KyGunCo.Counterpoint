// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_LOC_GRP
    public class ImLocGrpConfiguration : IEntityTypeConfiguration<ImLocGrp>
    {
        public void Configure(EntityTypeBuilder<ImLocGrp> builder)
        {
            builder.ToTable("IM_LOC_GRP", "dbo");
            builder.HasKey(x => x.LocGrpId).HasName("PK_IM_LOC_GRP").IsClustered();

            builder.Property(x => x.LocGrpId).HasColumnName(@"LOC_GRP_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            builder.HasIndex(x => new { x.DescrUpr, x.LocGrpId }).HasDatabaseName("IM_LOC_GRP_X1");
        }
    }

}
// </auto-generated>

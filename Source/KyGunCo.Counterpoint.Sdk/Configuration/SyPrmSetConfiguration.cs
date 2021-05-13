// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_PRM_SET
    public class SyPrmSetConfiguration : IEntityTypeConfiguration<SyPrmSet>
    {
        public void Configure(EntityTypeBuilder<SyPrmSet> builder)
        {
            builder.ToTable("SY_PRM_SET", "dbo");
            builder.HasKey(x => new { x.PrmSetNam, x.PrmSetTyp }).HasName("PK_SY_PRM_SET").IsClustered();

            builder.Property(x => x.PrmSetNam).HasColumnName(@"PRM_SET_NAM").HasColumnType("varchar(40)").IsRequired().IsUnicode(false).HasMaxLength(40).ValueGeneratedNever();
            builder.Property(x => x.PrmSetTyp).HasColumnName(@"PRM_SET_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedNever();
            builder.Property(x => x.Source).HasColumnName(@"SOURCE").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.Dest).HasColumnName(@"DEST").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.Prms).HasColumnName(@"PRMS").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.Comment).HasColumnName(@"COMMENT").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
        }
    }

}
// </auto-generated>
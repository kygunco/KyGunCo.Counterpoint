// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // DM_CAL_DAY
    public class DmCalDayConfiguration : IEntityTypeConfiguration<DmCalDay>
    {
        public void Configure(EntityTypeBuilder<DmCalDay> builder)
        {
            builder.ToTable("DM_CAL_DAY", "dbo");
            builder.HasKey(x => x.Dat).HasName("PK_DM_CAL_DAY").IsClustered();

            builder.Property(x => x.Dat).HasColumnName(@"DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.YrId).HasColumnName(@"YR_ID").HasColumnType("int").IsRequired();
            builder.Property(x => x.DayOfYr).HasColumnName(@"DAY_OF_YR").HasColumnType("int").IsRequired();
            builder.Property(x => x.SameDayLstYr).HasColumnName(@"SAME_DAY_LST_YR").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.WeekId).HasColumnName(@"WEEK_ID").HasColumnType("int").IsRequired();
            builder.Property(x => x.MnthId).HasColumnName(@"MNTH_ID").HasColumnType("int").IsRequired();
            builder.Property(x => x.SeasId).HasColumnName(@"SEAS_ID").HasColumnType("int").IsRequired();
            builder.Property(x => x.CalndrId).HasColumnName(@"CALNDR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.DayOfWeek).HasColumnName(@"DAY_OF_WEEK").HasColumnType("int").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.DmCalYr).WithMany(b => b.DmCalDays).HasForeignKey(c => c.YrId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_DM_CAL_DAY_DM_CAL_YR");
        }
    }

}
// </auto-generated>

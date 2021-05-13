// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // DM_STATS_STR_USR_DAY
    public class DmStatsStrUsrDayConfiguration : IEntityTypeConfiguration<DmStatsStrUsrDay>
    {
        public void Configure(EntityTypeBuilder<DmStatsStrUsrDay> builder)
        {
            builder.ToTable("DM_STATS_STR_USR_DAY", "dbo");
            builder.HasKey(x => new { x.StrId, x.UsrId, x.Dat }).HasName("PK_DM_STATS_STR_USR_DAY").IsClustered();

            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Dat).HasColumnName(@"DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.TktCnt).HasColumnName(@"TKT_CNT").HasColumnType("int").IsRequired();
            builder.Property(x => x.TktAmt).HasColumnName(@"TKT_AMT").HasColumnType("money").IsRequired();
            builder.Property(x => x.LinCnt).HasColumnName(@"LIN_CNT").HasColumnType("int").IsRequired();
            builder.Property(x => x.OvrShrt).HasColumnName(@"OVR_SHRT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.HoursWrkd).HasColumnName(@"HOURS_WRKD").HasColumnType("money").IsRequired();
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.DmStrHist).WithMany(b => b.DmStatsStrUsrDays).HasForeignKey(c => c.StrId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_DM_STATS_STR_USR_DAY_DM_STR_HIST");
        }
    }

}
// </auto-generated>
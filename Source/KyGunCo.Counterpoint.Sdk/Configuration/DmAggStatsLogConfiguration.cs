// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // DM_AGG_STATS_LOG
    public class DmAggStatsLogConfiguration : IEntityTypeConfiguration<DmAggStatsLog>
    {
        public void Configure(EntityTypeBuilder<DmAggStatsLog> builder)
        {
            builder.ToTable("DM_AGG_STATS_LOG", "dbo");
            builder.HasKey(x => new { x.AggExecId, x.AggId }).HasName("PK_DM_AGG_STATS_LOG").IsClustered();

            builder.Property(x => x.AggExecId).HasColumnName(@"AGG_EXEC_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.AggId).HasColumnName(@"AGG_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.AggDurationMs).HasColumnName(@"AGG_DURATION_MS").HasColumnType("int").IsRequired();
            builder.Property(x => x.UpdatedRowCnt).HasColumnName(@"UPDATED_ROW_CNT").HasColumnType("int").IsRequired();
            builder.Property(x => x.InsertedRowCnt).HasColumnName(@"INSERTED_ROW_CNT").HasColumnType("int").IsRequired();
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.DmAggLog).WithMany(b => b.DmAggStatsLogs).HasForeignKey(c => c.AggExecId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_DM_AGG_STATS_LOG_DM_AGG_LOG");
        }
    }

}
// </auto-generated>

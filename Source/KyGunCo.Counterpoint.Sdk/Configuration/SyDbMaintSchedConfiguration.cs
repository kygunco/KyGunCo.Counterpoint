// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_DB_MAINT_SCHED
    public class SyDbMaintSchedConfiguration : IEntityTypeConfiguration<SyDbMaintSched>
    {
        public void Configure(EntityTypeBuilder<SyDbMaintSched> builder)
        {
            builder.ToTable("SY_DB_MAINT_SCHED", "dbo");
            builder.HasKey(x => new { x.DbId, x.SeqNo }).HasName("PK_SY_DB_MAINT_SCHED").IsClustered();

            builder.Property(x => x.DbId).HasColumnName(@"DB_ID").HasColumnType("smallint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DowId).HasColumnName(@"DOW_ID").HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.StartTim).HasColumnName(@"START_TIM").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.EndTim).HasColumnName(@"END_TIM").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);

            // Foreign keys
            builder.HasOne(a => a.SyDb).WithMany(b => b.SyDbMaintScheds).HasForeignKey(c => c.DbId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SY_DB_MAINT_SCHED_SY_DB");
        }
    }

}
// </auto-generated>

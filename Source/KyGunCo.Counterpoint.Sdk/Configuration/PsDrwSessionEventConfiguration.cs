// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_DRW_SESSION_EVENT
    public class PsDrwSessionEventConfiguration : IEntityTypeConfiguration<PsDrwSessionEvent>
    {
        public void Configure(EntityTypeBuilder<PsDrwSessionEvent> builder)
        {
            builder.ToTable("PS_DRW_SESSION_EVENT", "dbo");
            builder.HasKey(x => new { x.StrId, x.DrwId, x.DrwSessionId, x.EventId }).HasName("PK_PS_DRW_SESSION_EVENT").IsClustered();

            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.DrwId).HasColumnName(@"DRW_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.DrwSessionId).HasColumnName(@"DRW_SESSION_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.EventId).HasColumnName(@"EVENT_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.EventDt).HasColumnName(@"EVENT_DT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.EventTyp).HasColumnName(@"EVENT_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EventStat).HasColumnName(@"EVENT_STAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.IsAutoEvent).HasColumnName(@"IS_AUTO_EVENT").HasColumnType("bit").IsRequired();
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.OverShortAmt).HasColumnName(@"OVER_SHORT_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.IsOffline).HasColumnName(@"IS_OFFLINE").HasColumnType("bit").IsRequired();
            builder.Property(x => x.ReconForced).HasColumnName(@"RECON_FORCED").HasColumnType("bit").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PsDrwSession).WithMany(b => b.PsDrwSessionEvents).HasForeignKey(c => new { c.StrId, c.DrwId, c.DrwSessionId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_DRW_SESSION_EVENT_PS_DRW_SESSION");
            builder.HasOne(a => a.SyUsr).WithMany(b => b.PsDrwSessionEvents).HasForeignKey(c => c.UsrId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_DRW_SESSION_EVENT_SY_USR");
        }
    }

}
// </auto-generated>
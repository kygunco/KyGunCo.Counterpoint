// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_CUSTOMIZATION_EVENT_HANDLER
    public class SyCustomizationEventHandlerConfiguration : IEntityTypeConfiguration<SyCustomizationEventHandler>
    {
        public void Configure(EntityTypeBuilder<SyCustomizationEventHandler> builder)
        {
            builder.ToTable("SY_CUSTOMIZATION_EVENT_HANDLER", "dbo");
            builder.HasKey(x => new { x.EventId, x.HandlerId }).HasName("PK_SY_CUSTOMIZATION_EVENT_HANDLER").IsClustered();

            builder.Property(x => x.EventId).HasColumnName(@"EVENT_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.HandlerId).HasColumnName(@"HANDLER_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.HandlerNam).HasColumnName(@"HANDLER_NAM").HasColumnType("varchar(128)").IsRequired(false).IsUnicode(false).HasMaxLength(128);
            builder.Property(x => x.HandlerTyp).HasColumnName(@"HANDLER_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.HandlerSeqNo).HasColumnName(@"HANDLER_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(80)").IsRequired(false).IsUnicode(false).HasMaxLength(80);
            builder.Property(x => x.Active).HasColumnName(@"ACTIVE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.SyCustomizationEvent).WithMany(b => b.SyCustomizationEventHandlers).HasForeignKey(c => c.EventId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SY_CUSTOMIZATION_EVENT_HANDLER_SY_CUSTOMIZATION_EVENT");
        }
    }

}
// </auto-generated>

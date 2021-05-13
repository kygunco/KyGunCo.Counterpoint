// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_MENU_REC_USED
    public class SyMenuRecUsedConfiguration : IEntityTypeConfiguration<SyMenuRecUsed>
    {
        public void Configure(EntityTypeBuilder<SyMenuRecUsed> builder)
        {
            builder.ToTable("SY_MENU_REC_USED", "dbo");
            builder.HasKey(x => new { x.UsrId, x.MenuItemId }).HasName("PK_SY_MENU_REC_USED").IsClustered();

            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.MenuItemId).HasColumnName(@"MENU_ITEM_ID").HasColumnType("varchar(250)").IsRequired().IsUnicode(false).HasMaxLength(250).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("SY_MENU_REC_USED_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("SY_MENU_REC_USED_X_RS_UTC_DT");
        }
    }

}
// </auto-generated>
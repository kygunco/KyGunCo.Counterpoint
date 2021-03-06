// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_MAIL_GRP
    public class SyMailGrpConfiguration : IEntityTypeConfiguration<SyMailGrp>
    {
        public void Configure(EntityTypeBuilder<SyMailGrp> builder)
        {
            builder.ToTable("SY_MAIL_GRP", "dbo");
            builder.HasKey(x => x.MailGrpId).HasName("PK_SY_MAIL_GRP").IsClustered();

            builder.Property(x => x.MailGrpId).HasColumnName(@"MAIL_GRP_ID").HasColumnType("varchar(25)").IsRequired().IsUnicode(false).HasMaxLength(25).ValueGeneratedNever();
            builder.Property(x => x.DisplayNam).HasColumnName(@"DISPLAY_NAM").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Commnt).HasColumnName(@"COMMNT").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);

            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("SY_MAIL_GRP_X_RS_UTC_DT");
            builder.HasIndex(x => new { x.DisplayNam, x.MailGrpId }).HasDatabaseName("SY_MAIL_GRP_X1");
        }
    }

}
// </auto-generated>

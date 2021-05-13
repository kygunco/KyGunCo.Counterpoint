// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_MAIL_GRP_USR
    public class SyMailGrpUsrConfiguration : IEntityTypeConfiguration<SyMailGrpUsr>
    {
        public void Configure(EntityTypeBuilder<SyMailGrpUsr> builder)
        {
            builder.ToTable("SY_MAIL_GRP_USR", "dbo");
            builder.HasKey(x => new { x.MailGrpId, x.SeqNo }).HasName("PK_SY_MAIL_GRP_USR").IsClustered();

            builder.Property(x => x.MailGrpId).HasColumnName(@"MAIL_GRP_ID").HasColumnType("varchar(25)").IsRequired().IsUnicode(false).HasMaxLength(25).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);

            // Foreign keys
            builder.HasOne(a => a.SyMailGrp).WithMany(b => b.SyMailGrpUsrs).HasForeignKey(c => c.MailGrpId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SY_MAIL_GRP_USR_SY_MAIL_GRP");
            builder.HasOne(a => a.SyUsr).WithMany(b => b.SyMailGrpUsrs).HasForeignKey(c => c.UsrId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SY_MAIL_GRP_USR_SY_USR");

            builder.HasIndex(x => new { x.MailGrpId, x.UsrId, x.SeqNo }).HasDatabaseName("SY_MAIL_GRP_USR_X1");
        }
    }

}
// </auto-generated>
// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_DEV_LD_MSG
    public class PsDevLdMsgConfiguration : IEntityTypeConfiguration<PsDevLdMsg>
    {
        public void Configure(EntityTypeBuilder<PsDevLdMsg> builder)
        {
            builder.ToTable("PS_DEV_LD_MSG", "dbo");
            builder.HasKey(x => x.LdMsgId).HasName("PK_PS_DEV_LD_MSG").IsClustered();

            builder.Property(x => x.LdMsgId).HasColumnName(@"LD_MSG_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LdEventTypeId).HasColumnName(@"LD_EVENT_TYPE_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.LdMsgSetId).HasColumnName(@"LD_MSG_SET_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.MsgXml).HasColumnName(@"MSG_XML").HasColumnType("text(2147483647)").IsRequired().IsUnicode(false).HasMaxLength(2147483647);

            // Foreign keys
            builder.HasOne(a => a.PsDevLdEventType).WithMany(b => b.PsDevLdMsgs).HasForeignKey(c => c.LdEventTypeId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_DEV_LD_MSG_PS_DEV_LD_EVENT_TYPE");
            builder.HasOne(a => a.PsDevLdMsgSet).WithMany(b => b.PsDevLdMsgs).HasForeignKey(c => c.LdMsgSetId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_DEV_LD_MSG_PS_DEV_LD_MSG_SET");
        }
    }

}
// </auto-generated>

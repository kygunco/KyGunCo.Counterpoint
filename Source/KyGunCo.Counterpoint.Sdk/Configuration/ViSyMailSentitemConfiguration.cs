// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_SY_MAIL_SENTITEMS
    public class ViSyMailSentitemConfiguration : IEntityTypeConfiguration<ViSyMailSentitem>
    {
        public void Configure(EntityTypeBuilder<ViSyMailSentitem> builder)
        {
            builder.ToView("VI_SY_MAIL_SENTITEMS", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.SenderId).HasColumnName(@"SENDER_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.MailId).HasColumnName(@"MAIL_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.SentDt).HasColumnName(@"SENT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Msg).HasColumnName(@"MSG").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.MsgTxt).HasColumnName(@"MSG_TXT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.Sender).HasColumnName(@"SENDER").HasColumnType("varchar(40)").IsRequired().IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.Subj).HasColumnName(@"SUBJ").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Importance).HasColumnName(@"IMPORTANCE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SentTo).HasColumnName(@"SENT_TO").HasColumnType("text(2147483647)").IsRequired().IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.IsPopup).HasColumnName(@"IS_POPUP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DeltdBySender).HasColumnName(@"DELTD_BY_SENDER").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AutoDelPopup).HasColumnName(@"AUTO_DEL_POPUP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
        }
    }

}
// </auto-generated>

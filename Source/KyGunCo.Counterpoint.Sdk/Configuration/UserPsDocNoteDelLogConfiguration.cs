// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_PS_DOC_NOTE_DEL_LOG
    public class UserPsDocNoteDelLogConfiguration : IEntityTypeConfiguration<UserPsDocNoteDelLog>
    {
        public void Configure(EntityTypeBuilder<UserPsDocNoteDelLog> builder)
        {
            builder.ToTable("USER_PS_DOC_NOTE_DEL_LOG", "dbo");
            builder.HasKey(x => new { x.DocId, x.NoteId, x.NoteSeqNo });

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.NoteId).HasColumnName(@"NOTE_ID").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.NoteSeqNo).HasColumnName(@"NOTE_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.NoteDat).HasColumnName(@"NOTE_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Note).HasColumnName(@"NOTE").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.NoteTxt).HasColumnName(@"NOTE_TXT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.LinGuid).HasColumnName(@"LIN_GUID").HasColumnType("uniqueidentifier").IsRequired(false);
            builder.Property(x => x.DelUsrId).HasColumnName(@"DEL_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DelDt).HasColumnName(@"DEL_DT").HasColumnType("datetime").IsRequired(false);
        }
    }

}
// </auto-generated>
// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_PREQ_NOTE
    public class PoPreqNoteConfiguration : IEntityTypeConfiguration<PoPreqNote>
    {
        public void Configure(EntityTypeBuilder<PoPreqNote> builder)
        {
            builder.ToTable("PO_PREQ_NOTE", "dbo");
            builder.HasKey(x => new { x.PreqNo, x.NoteId }).HasName("PK_PO_PREQ_NOTE").IsClustered();

            builder.Property(x => x.PreqNo).HasColumnName(@"PREQ_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.NoteId).HasColumnName(@"NOTE_ID").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.NoteDat).HasColumnName(@"NOTE_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Note).HasColumnName(@"NOTE").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.NoteTxt).HasColumnName(@"NOTE_TXT").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PoPreqHdr).WithMany(b => b.PoPreqNotes).HasForeignKey(c => c.PreqNo).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_PREQ_NOTE_PO_PREQ_HDR");

            builder.HasIndex(x => new { x.PreqNo, x.NoteDat, x.NoteId }).HasDatabaseName("PO_PREQ_NOTE_X1");
        }
    }

}
// </auto-generated>

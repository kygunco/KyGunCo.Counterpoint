// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_XFER_OUT_NOTE
    public class ImXferOutNoteConfiguration : IEntityTypeConfiguration<ImXferOutNote>
    {
        public void Configure(EntityTypeBuilder<ImXferOutNote> builder)
        {
            builder.ToTable("IM_XFER_OUT_NOTE", "dbo");
            builder.HasKey(x => new { x.XferNo, x.NoteId }).HasName("PK_IM_XFER_OUT_NOTE").IsClustered();

            builder.Property(x => x.XferNo).HasColumnName(@"XFER_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
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
            builder.HasOne(a => a.ImXferOutHdr).WithMany(b => b.ImXferOutNotes).HasForeignKey(c => c.XferNo).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_XFER_OUT_NOTE_IM_XFER_OUT_HDR");

            builder.HasIndex(x => new { x.XferNo, x.NoteDat, x.NoteId }).HasDatabaseName("IM_XFER_OUT_NOTE_X1");
        }
    }

}
// </auto-generated>

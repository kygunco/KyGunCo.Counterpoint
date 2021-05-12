// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_PREQ_LIN_LOC
    public class PoPreqLinLocConfiguration : IEntityTypeConfiguration<PoPreqLinLoc>
    {
        public void Configure(EntityTypeBuilder<PoPreqLinLoc> builder)
        {
            builder.ToTable("PO_PREQ_LIN_LOC", "dbo");
            builder.HasKey(x => new { x.PreqNo, x.SeqNo, x.LocId }).HasName("PK_PO_PREQ_LIN_LOC").IsClustered();

            builder.Property(x => x.PreqNo).HasColumnName(@"PREQ_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.OrdQty).HasColumnName(@"ORD_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PoPreqLin).WithMany(b => b.PoPreqLinLocs).HasForeignKey(c => new { c.PreqNo, c.SeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_PREQ_LIN_LOC_PO_PREQ_LIN");
        }
    }

}
// </auto-generated>

// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_RENUM_VEND
    public class PoRenumVendConfiguration : IEntityTypeConfiguration<PoRenumVend>
    {
        public void Configure(EntityTypeBuilder<PoRenumVend> builder)
        {
            builder.ToTable("PO_RENUM_VEND", "dbo");
            builder.HasKey(x => new { x.RenumGrpId, x.SeqNo }).HasName("PK_PO_RENUM_VEND").IsClustered();

            builder.Property(x => x.RenumGrpId).HasColumnName(@"RENUM_GRP_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.OldVendNo).HasColumnName(@"OLD_VEND_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.NewVendNo).HasColumnName(@"NEW_VEND_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ErrRef).HasColumnName(@"ERR_REF").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.PoRenumVendGrp).WithMany(b => b.PoRenumVends).HasForeignKey(c => c.RenumGrpId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_RENUM_VEND_PO_RENUM_VEND_GRP");
        }
    }

}
// </auto-generated>

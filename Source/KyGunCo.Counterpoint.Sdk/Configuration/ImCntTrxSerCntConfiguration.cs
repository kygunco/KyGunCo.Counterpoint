// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_CNT_TRX_SER_CNT
    public class ImCntTrxSerCntConfiguration : IEntityTypeConfiguration<ImCntTrxSerCnt>
    {
        public void Configure(EntityTypeBuilder<ImCntTrxSerCnt> builder)
        {
            builder.ToTable("IM_CNT_TRX_SER_CNT", "dbo");
            builder.HasKey(x => new { x.ItemNo, x.LocId, x.SerNo }).HasName("PK_IM_CNT_TRX_SER_CNT").IsClustered();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();
            builder.Property(x => x.ErrRef).HasColumnName(@"ERR_REF").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImCntTrx).WithMany(b => b.ImCntTrxSerCnts).HasForeignKey(c => new { c.ItemNo, c.LocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_CNT_TRX_SER_CNT_IM_CNT_TRX");
        }
    }

}
// </auto-generated>

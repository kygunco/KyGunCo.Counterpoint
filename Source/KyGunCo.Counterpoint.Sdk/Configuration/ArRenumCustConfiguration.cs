// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AR_RENUM_CUST
    public class ArRenumCustConfiguration : IEntityTypeConfiguration<ArRenumCust>
    {
        public void Configure(EntityTypeBuilder<ArRenumCust> builder)
        {
            builder.ToTable("AR_RENUM_CUST", "dbo");
            builder.HasKey(x => new { x.RenumGrpId, x.SeqNo }).HasName("PK_AR_RENUM_CUST").IsClustered();

            builder.Property(x => x.RenumGrpId).HasColumnName(@"RENUM_GRP_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.OldCustNo).HasColumnName(@"OLD_CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.NewCustNo).HasColumnName(@"NEW_CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ErrRef).HasColumnName(@"ERR_REF").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.ArRenumCustGrp).WithMany(b => b.ArRenumCusts).HasForeignKey(c => c.RenumGrpId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AR_RENUM_CUST_AR_RENUM_CUST_GRP");
        }
    }

}
// </auto-generated>

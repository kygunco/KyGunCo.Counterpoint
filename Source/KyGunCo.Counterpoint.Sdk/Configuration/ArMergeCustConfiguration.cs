// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AR_MERGE_CUST
    public class ArMergeCustConfiguration : IEntityTypeConfiguration<ArMergeCust>
    {
        public void Configure(EntityTypeBuilder<ArMergeCust> builder)
        {
            builder.ToTable("AR_MERGE_CUST", "dbo");
            builder.HasKey(x => new { x.MergeGrpId, x.SeqNo }).HasName("PK_AR_MERGE_CUST").IsClustered();

            builder.Property(x => x.MergeGrpId).HasColumnName(@"MERGE_GRP_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.FromCustNo).HasColumnName(@"FROM_CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ToCustNo).HasColumnName(@"TO_CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ErrRef).HasColumnName(@"ERR_REF").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.ArMergeCustGrp).WithMany(b => b.ArMergeCusts).HasForeignKey(c => c.MergeGrpId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AR_MERGE_CUST_AR_MERGE_CUST_GRP");
        }
    }

}
// </auto-generated>
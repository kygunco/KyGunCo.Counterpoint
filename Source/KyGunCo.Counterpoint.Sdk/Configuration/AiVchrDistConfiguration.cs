// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AI_VCHR_DIST
    public class AiVchrDistConfiguration : IEntityTypeConfiguration<AiVchrDist>
    {
        public void Configure(EntityTypeBuilder<AiVchrDist> builder)
        {
            builder.ToTable("AI_VCHR_DIST", "dbo");
            builder.HasKey(x => new { x.VchrVendNo, x.VchrNo, x.SeqNo }).HasName("PK_AI_VCHR_DIST").IsClustered();

            builder.Property(x => x.VchrVendNo).HasColumnName(@"VCHR_VEND_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.VchrNo).HasColumnName(@"VCHR_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.AcctNo).HasColumnName(@"ACCT_NO").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.CpAcctNo).HasColumnName(@"CP_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.AiVchr).WithMany(b => b.AiVchrDists).HasForeignKey(c => new { c.VchrVendNo, c.VchrNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AI_VCHR_DIST_AI_VCHR");
        }
    }

}
// </auto-generated>

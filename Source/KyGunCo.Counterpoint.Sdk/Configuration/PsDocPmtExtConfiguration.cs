// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_DOC_PMT_EXT
    public class PsDocPmtExtConfiguration : IEntityTypeConfiguration<PsDocPmtExt>
    {
        public void Configure(EntityTypeBuilder<PsDocPmtExt> builder)
        {
            builder.ToTable("PS_DOC_PMT_EXT", "dbo");
            builder.HasKey(x => new { x.DocIdExt, x.PmtSeqNoExt }).HasName("PK_PS_DOC_PMT_EXT").IsClustered();

            builder.Property(x => x.DocIdExt).HasColumnName(@"DOC_ID_EXT").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PmtSeqNoExt).HasColumnName(@"PMT_SEQ_NO_EXT").HasColumnType("int").IsRequired().ValueGeneratedNever();

            // Foreign keys
            builder.HasOne(a => a.PsDocPmt).WithOne(b => b.PsDocPmtExt).HasForeignKey<PsDocPmtExt>(c => new { c.DocIdExt, c.PmtSeqNoExt }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_DOC_PMT_EXT_PS_DOC_PMT");
        }
    }

}
// </auto-generated>
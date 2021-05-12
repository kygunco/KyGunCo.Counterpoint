// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_ORD_HIST_LIN_SER_EXT
    public class PsOrdHistLinSerExtConfiguration : IEntityTypeConfiguration<PsOrdHistLinSerExt>
    {
        public void Configure(EntityTypeBuilder<PsOrdHistLinSerExt> builder)
        {
            builder.ToTable("PS_ORD_HIST_LIN_SER_EXT", "dbo");
            builder.HasKey(x => new { x.BusDatExt, x.DocIdExt, x.LinSeqNoExt, x.SerNoExt }).HasName("PK_PS_ORD_HIST_LIN_SER_EXT").IsClustered();

            builder.Property(x => x.BusDatExt).HasColumnName(@"BUS_DAT_EXT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocIdExt).HasColumnName(@"DOC_ID_EXT").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNoExt).HasColumnName(@"LIN_SEQ_NO_EXT").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SerNoExt).HasColumnName(@"SER_NO_EXT").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();

            // Foreign keys
            builder.HasOne(a => a.PsOrdHistLinSer).WithOne(b => b.PsOrdHistLinSerExt).HasForeignKey<PsOrdHistLinSerExt>(c => new { c.BusDatExt, c.DocIdExt, c.LinSeqNoExt, c.SerNoExt }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_LIN_SER_EXT_PS_ORD_HIST_LIN_SER");
        }
    }

}
// </auto-generated>

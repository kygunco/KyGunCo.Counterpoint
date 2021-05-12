// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_VOID_HIST_PAY_IOA
    public class PsVoidHistPayIoaConfiguration : IEntityTypeConfiguration<PsVoidHistPayIoa>
    {
        public void Configure(EntityTypeBuilder<PsVoidHistPayIoa> builder)
        {
            builder.ToTable("PS_VOID_HIST_PAY_IOA", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId }).HasName("PK_PS_VOID_HIST_PAY_IOA").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocDescr).HasColumnName(@"DOC_DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PayAcctNo).HasColumnName(@"PAY_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.PayApplyMeth).HasColumnName(@"PAY_APPLY_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PayAmt).HasColumnName(@"PAY_AMT").HasColumnType("decimal(15,2)").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PsVoidHist).WithOne(b => b.PsVoidHistPayIoa).HasForeignKey<PsVoidHistPayIoa>(c => new { c.BusDat, c.DocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_VOID_HIST_PAY_IOA_PS_VOID_HIST");
        }
    }

}
// </auto-generated>

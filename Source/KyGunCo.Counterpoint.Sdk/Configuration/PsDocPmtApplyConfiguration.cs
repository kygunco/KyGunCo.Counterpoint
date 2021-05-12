// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_DOC_PMT_APPLY
    public class PsDocPmtApplyConfiguration : IEntityTypeConfiguration<PsDocPmtApply>
    {
        public void Configure(EntityTypeBuilder<PsDocPmtApply> builder)
        {
            builder.ToTable("PS_DOC_PMT_APPLY", "dbo");
            builder.HasKey(x => new { x.DocId, x.PmtSeqNo, x.ApplTyp }).HasName("PK_PS_DOC_PMT_APPLY").IsClustered();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PmtSeqNo).HasColumnName(@"PMT_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ApplTyp).HasColumnName(@"APPL_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedNever();
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.HomeCurncyAmt).HasColumnName(@"HOME_CURNCY_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.ExchLoss).HasColumnName(@"EXCH_LOSS").HasColumnType("decimal(15,2)").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.PsDocPmt).WithMany(b => b.PsDocPmtApplies).HasForeignKey(c => new { c.DocId, c.PmtSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_DOC_PMT_APPLY_PS_DOC_PMT");
        }
    }

}
// </auto-generated>

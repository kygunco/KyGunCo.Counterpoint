// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_VOID_HIST_SVC
    public class PsVoidHistSvcConfiguration : IEntityTypeConfiguration<PsVoidHistSvc>
    {
        public void Configure(EntityTypeBuilder<PsVoidHistSvc> builder)
        {
            builder.ToTable("PS_VOID_HIST_SVC", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.SvcSeqNo }).HasName("PK_PS_VOID_HIST_SVC").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SvcSeqNo).HasColumnName(@"SVC_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SvcCod).HasColumnName(@"SVC_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SvcNo).HasColumnName(@"SVC_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.SvcTyp).HasColumnName(@"SVC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SvcRefNo).HasColumnName(@"SVC_REF_NO").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.SvcBalRemain).HasColumnName(@"SVC_BAL_REMAIN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ProcessorTransId).HasColumnName(@"PROCESSOR_TRANS_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.UniqueTransId).HasColumnName(@"UNIQUE_TRANS_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);

            // Foreign keys
            builder.HasOne(a => a.PsVoidHist).WithMany(b => b.PsVoidHistSvcs).HasForeignKey(c => new { c.BusDat, c.DocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_VOID_HIST_SVC_PS_VOID_HIST");
        }
    }

}
// </auto-generated>

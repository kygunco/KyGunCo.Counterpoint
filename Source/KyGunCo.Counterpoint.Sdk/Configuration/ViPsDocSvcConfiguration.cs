// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_DOC_SVC
    public class ViPsDocSvcConfiguration : IEntityTypeConfiguration<ViPsDocSvc>
    {
        public void Configure(EntityTypeBuilder<ViPsDocSvc> builder)
        {
            builder.ToView("VI_PS_DOC_SVC", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.SvcSeqNo).HasColumnName(@"SVC_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.SvcCod).HasColumnName(@"SVC_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SvcNo).HasColumnName(@"SVC_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.SvcTyp).HasColumnName(@"SVC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SvcRefNo).HasColumnName(@"SVC_REF_NO").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.SvcBalRemain).HasColumnName(@"SVC_BAL_REMAIN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ProcessorTransId).HasColumnName(@"PROCESSOR_TRANS_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.UniqueTransId).HasColumnName(@"UNIQUE_TRANS_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
        }
    }

}
// </auto-generated>

// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_FILL_BO_RSLT_LIN_WRK
    public class PsFillBoRsltLinWrkConfiguration : IEntityTypeConfiguration<PsFillBoRsltLinWrk>
    {
        public void Configure(EntityTypeBuilder<PsFillBoRsltLinWrk> builder)
        {
            builder.ToTable("PS_FILL_BO_RSLT_LIN_WRK", "dbo");
            builder.HasKey(x => new { x.SessId, x.DocId, x.LinSeqNo }).HasName("PK_PS_FILL_BO_RSLT_LIN_WRK").IsClustered();

            builder.Property(x => x.SessId).HasColumnName(@"SESS_ID").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.QtyFilled).HasColumnName(@"QTY_FILLED").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
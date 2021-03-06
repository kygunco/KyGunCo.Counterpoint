// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_VOID_HIST_RECEIPT_HEADER
    public class ViVoidHistReceiptHeaderConfiguration : IEntityTypeConfiguration<ViVoidHistReceiptHeader>
    {
        public void Configure(EntityTypeBuilder<ViVoidHistReceiptHeader> builder)
        {
            builder.ToView("VI_VOID_HIST_RECEIPT_HEADER", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
        }
    }

}
// </auto-generated>

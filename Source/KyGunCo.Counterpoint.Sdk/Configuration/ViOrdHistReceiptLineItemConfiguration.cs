// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_ORD_HIST_RECEIPT_LINE_ITEMS
    public class ViOrdHistReceiptLineItemConfiguration : IEntityTypeConfiguration<ViOrdHistReceiptLineItem>
    {
        public void Configure(EntityTypeBuilder<ViOrdHistReceiptLineItem> builder)
        {
            builder.ToView("VI_ORD_HIST_RECEIPT_LINE_ITEMS", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.LinSeqNo).HasColumnName(@"LIN_SEQ_NO").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>

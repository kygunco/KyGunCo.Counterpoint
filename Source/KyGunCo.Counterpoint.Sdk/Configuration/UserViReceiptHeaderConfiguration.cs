// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_VI_RECEIPT_HEADER
    public class UserViReceiptHeaderConfiguration : IEntityTypeConfiguration<UserViReceiptHeader>
    {
        public void Configure(EntityTypeBuilder<UserViReceiptHeader> builder)
        {
            builder.ToView("USER_VI_RECEIPT_HEADER", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.OpenAcq).HasColumnName(@"OPEN_ACQ").HasColumnType("varchar(4000)").IsRequired(false).IsUnicode(false).HasMaxLength(4000);
            builder.Property(x => x.BuybackTradein).HasColumnName(@"BUYBACK_TRADEIN").HasColumnType("varchar(4000)").IsRequired(false).IsUnicode(false).HasMaxLength(4000);
            builder.Property(x => x.Consignments).HasColumnName(@"CONSIGNMENTS").HasColumnType("varchar(4000)").IsRequired(false).IsUnicode(false).HasMaxLength(4000);
            builder.Property(x => x.StoreNameLine1).HasColumnName(@"STORE_NAME_LINE_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.StoreNameLine2).HasColumnName(@"STORE_NAME_LINE_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
        }
    }

}
// </auto-generated>
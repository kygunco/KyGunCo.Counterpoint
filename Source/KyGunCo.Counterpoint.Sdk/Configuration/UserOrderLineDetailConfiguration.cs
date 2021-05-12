// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_ORDER_LINE_DETAILS
    public class UserOrderLineDetailConfiguration : IEntityTypeConfiguration<UserOrderLineDetail>
    {
        public void Configure(EntityTypeBuilder<UserOrderLineDetail> builder)
        {
            builder.ToView("USER_ORDER_LINE_DETAILS", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.WebOrderNo).HasColumnName(@"WEB_ORDER_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.OrigQty).HasColumnName(@"ORIG_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyShipped).HasColumnName(@"QTY_SHIPPED").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyUnit).HasColumnName(@"QTY_UNIT").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.QtySold).HasColumnName(@"QTY_SOLD").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.Prc).HasColumnName(@"PRC").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.Prc1).HasColumnName(@"PRC_1").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.NoOfSersEntd).HasColumnName(@"NO_OF_SERS_ENTD").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Style).HasColumnName(@"STYLE").HasColumnType("varchar(80)").IsRequired(false).IsUnicode(false).HasMaxLength(80);
            builder.Property(x => x.SerNos).HasColumnName(@"SER_NOS").HasColumnType("nvarchar(max)").IsRequired(false);
        }
    }

}
// </auto-generated>

// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PO_ORD_LIN
    public class ViPoOrdLinConfiguration : IEntityTypeConfiguration<ViPoOrdLin>
    {
        public void Configure(EntityTypeBuilder<ViPoOrdLin> builder)
        {
            builder.ToView("VI_PO_ORD_LIN", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.PoNo).HasColumnName(@"PO_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.AllocLocId).HasColumnName(@"ALLOC_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.OrdQty).HasColumnName(@"ORD_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyRecvd).HasColumnName(@"QTY_RECVD").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyExpectd).HasColumnName(@"QTY_EXPECTD").HasColumnType("decimal(15,4)").IsRequired();
        }
    }

}
// </auto-generated>
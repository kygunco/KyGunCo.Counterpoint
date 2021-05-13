// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_ORDER_TRACKING_DETAILS
    public class UserOrderTrackingDetailConfiguration : IEntityTypeConfiguration<UserOrderTrackingDetail>
    {
        public void Configure(EntityTypeBuilder<UserOrderTrackingDetail> builder)
        {
            builder.ToView("USER_ORDER_TRACKING_DETAILS", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.WebOrdNo).HasColumnName(@"WEB_ORD_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PkgTrkSeqNo).HasColumnName(@"PKG_TRK_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.PkgTrkNo).HasColumnName(@"PKG_TRK_NO").HasColumnType("varchar(25)").IsRequired().IsUnicode(false).HasMaxLength(25);
        }
    }

}
// </auto-generated>
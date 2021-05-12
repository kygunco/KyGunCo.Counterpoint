// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_ORDER_LOG_DETAILS
    public class UserOrderLogDetailConfiguration : IEntityTypeConfiguration<UserOrderLogDetail>
    {
        public void Configure(EntityTypeBuilder<UserOrderLogDetail> builder)
        {
            builder.ToView("USER_ORDER_LOG_DETAILS", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.WebOrdNo).HasColumnName(@"WEB_ORD_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LogSeqNo).HasColumnName(@"LOG_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.DocTyp).HasColumnName(@"DOC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Activ).HasColumnName(@"ACTIV").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LogEntry).HasColumnName(@"LOG_ENTRY").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.LinkDocNo).HasColumnName(@"LINK_DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LstUsrId).HasColumnName(@"LST_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>

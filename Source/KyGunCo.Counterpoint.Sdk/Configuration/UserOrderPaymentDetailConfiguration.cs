// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_ORDER_PAYMENT_DETAILS
    public class UserOrderPaymentDetailConfiguration : IEntityTypeConfiguration<UserOrderPaymentDetail>
    {
        public void Configure(EntityTypeBuilder<UserOrderPaymentDetail> builder)
        {
            builder.ToView("USER_ORDER_PAYMENT_DETAILS", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.WebOrdNo).HasColumnName(@"WEB_ORD_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PmtSeqNo).HasColumnName(@"PMT_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.PayCodTyp).HasColumnName(@"PAY_COD_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.FinalPmt).HasColumnName(@"FINAL_PMT").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PmtLinTyp).HasColumnName(@"PMT_LIN_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PayCod).HasColumnName(@"PAY_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PayDat).HasColumnName(@"PAY_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
        }
    }

}
// </auto-generated>

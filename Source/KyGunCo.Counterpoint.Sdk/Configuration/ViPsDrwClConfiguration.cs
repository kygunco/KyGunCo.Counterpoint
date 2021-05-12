// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_DRW_CLS
    public class ViPsDrwClConfiguration : IEntityTypeConfiguration<ViPsDrwCl>
    {
        public void Configure(EntityTypeBuilder<ViPsDrwCl> builder)
        {
            builder.ToView("VI_PS_DRW_CLS", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DrwId).HasColumnName(@"DRW_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DrwSessionId).HasColumnName(@"DRW_SESSION_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.PayCod).HasColumnName(@"PAY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BegAmt).HasColumnName(@"BEG_AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.DropAmt).HasColumnName(@"DROP_AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.LoanAmt).HasColumnName(@"LOAN_AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.ClsAmt).HasColumnName(@"CLS_AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.ReconAmt).HasColumnName(@"RECON_AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.NormActiv).HasColumnName(@"NORM_ACTIV").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.NormCnt).HasColumnName(@"NORM_CNT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.NormRecon).HasColumnName(@"NORM_RECON").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
        }
    }

}
// </auto-generated>

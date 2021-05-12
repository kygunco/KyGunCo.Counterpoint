// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_VALIDATED_RETURNS_HDR
    public class ViPsValidatedReturnsHdrConfiguration : IEntityTypeConfiguration<ViPsValidatedReturnsHdr>
    {
        public void Configure(EntityTypeBuilder<ViPsValidatedReturnsHdr> builder)
        {
            builder.ToView("VI_PS_VALIDATED_RETURNS_HDR", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.TktDt).HasColumnName(@"TKT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Nam).HasColumnName(@"NAM").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.TaxCod).HasColumnName(@"TAX_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CustPoNo).HasColumnName(@"CUST_PO_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.SlsRep).HasColumnName(@"SLS_REP").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.SubTot).HasColumnName(@"SUB_TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TotMisc).HasColumnName(@"TOT_MISC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TaxAmt).HasColumnName(@"TAX_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.Tot).HasColumnName(@"TOT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.CustIsDefaultCust).HasColumnName(@"CUST_IS_DEFAULT_CUST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.HasTaxOvrd).HasColumnName(@"HAS_TAX_OVRD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxOvrdReas).HasColumnName(@"TAX_OVRD_REAS").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.NormTaxAmt).HasColumnName(@"NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired();
        }
    }

}
// </auto-generated>

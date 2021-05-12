// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_ORD_HIST_TAX
    public class ViPsOrdHistTaxConfiguration : IEntityTypeConfiguration<ViPsOrdHistTax>
    {
        public void Configure(EntityTypeBuilder<ViPsOrdHistTax> builder)
        {
            builder.ToView("VI_PS_ORD_HIST_TAX", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.AuthCod).HasColumnName(@"AUTH_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RulCod).HasColumnName(@"RUL_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxDocPart).HasColumnName(@"TAX_DOC_PART").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.TxblQty).HasColumnName(@"TXBL_QTY").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.LinAmt).HasColumnName(@"LIN_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblLinAmt).HasColumnName(@"TXBL_LIN_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt1).HasColumnName(@"TXBL_MISC_CHG_AMT_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt2).HasColumnName(@"TXBL_MISC_CHG_AMT_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt3).HasColumnName(@"TXBL_MISC_CHG_AMT_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt4).HasColumnName(@"TXBL_MISC_CHG_AMT_4").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt5).HasColumnName(@"TXBL_MISC_CHG_AMT_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblTaxAmt).HasColumnName(@"TXBL_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt).HasColumnName(@"TXBL_MISC_CHG_AMT").HasColumnType("decimal(19,2)").IsRequired(false);
            builder.Property(x => x.TotTxblAmt).HasColumnName(@"TOT_TXBL_AMT").HasColumnType("decimal(21,2)").IsRequired(false);
            builder.Property(x => x.NormTaxAmt).HasColumnName(@"NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TaxAmt).HasColumnName(@"TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.NormTaxAmtExact).HasColumnName(@"NORM_TAX_AMT_EXACT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.TaxAmtExact).HasColumnName(@"TAX_AMT_EXACT").HasColumnType("decimal(15,4)").IsRequired(false);
        }
    }

}
// </auto-generated>

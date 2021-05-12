// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_ORD_HIST_TAX
    public class PsOrdHistTaxConfiguration : IEntityTypeConfiguration<PsOrdHistTax>
    {
        public void Configure(EntityTypeBuilder<PsOrdHistTax> builder)
        {
            builder.ToTable("PS_ORD_HIST_TAX", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.AuthCod, x.RulCod }).HasName("PK_PS_ORD_HIST_TAX").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.AuthCod).HasColumnName(@"AUTH_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.RulCod).HasColumnName(@"RUL_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.LinAmt).HasColumnName(@"LIN_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblLinAmt).HasColumnName(@"TXBL_LIN_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt1).HasColumnName(@"TXBL_MISC_CHG_AMT_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt2).HasColumnName(@"TXBL_MISC_CHG_AMT_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt3).HasColumnName(@"TXBL_MISC_CHG_AMT_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt4).HasColumnName(@"TXBL_MISC_CHG_AMT_4").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt5).HasColumnName(@"TXBL_MISC_CHG_AMT_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblTaxAmt).HasColumnName(@"TXBL_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblQty).HasColumnName(@"TXBL_QTY").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.TaxAmt).HasColumnName(@"TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.NormTaxAmt).HasColumnName(@"NORM_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TaxAmtExact).HasColumnName(@"TAX_AMT_EXACT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.NormTaxAmtExact).HasColumnName(@"NORM_TAX_AMT_EXACT").HasColumnType("decimal(15,4)").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PsOrdHist).WithMany(b => b.PsOrdHistTaxes).HasForeignKey(c => new { c.BusDat, c.DocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_TAX_PS_ORD_HIST");
        }
    }

}
// </auto-generated>

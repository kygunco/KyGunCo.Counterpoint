// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_RTV_TAX
    public class PoRtvTaxConfiguration : IEntityTypeConfiguration<PoRtvTax>
    {
        public void Configure(EntityTypeBuilder<PoRtvTax> builder)
        {
            builder.ToTable("PO_RTV_TAX", "dbo");
            builder.HasKey(x => new { x.RtvNo, x.AuthCod, x.RulCod }).HasName("PK_PO_RTV_TAX").IsClustered();

            builder.Property(x => x.RtvNo).HasColumnName(@"RTV_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.AuthCod).HasColumnName(@"AUTH_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.RulCod).HasColumnName(@"RUL_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.LinAmtHome).HasColumnName(@"LIN_AMT_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblLinAmtHome).HasColumnName(@"TXBL_LIN_AMT_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt1Home).HasColumnName(@"TXBL_MISC_CHG_AMT_1_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt2Home).HasColumnName(@"TXBL_MISC_CHG_AMT_2_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt3Home).HasColumnName(@"TXBL_MISC_CHG_AMT_3_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt4Home).HasColumnName(@"TXBL_MISC_CHG_AMT_4_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblMiscChgAmt5Home).HasColumnName(@"TXBL_MISC_CHG_AMT_5_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblTaxAmtHome).HasColumnName(@"TXBL_TAX_AMT_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TxblQty).HasColumnName(@"TXBL_QTY").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.TaxAmtHome).HasColumnName(@"TAX_AMT_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TaxAmtNormHome).HasColumnName(@"TAX_AMT_NORM_HOME").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TaxAmtExactHome).HasColumnName(@"TAX_AMT_EXACT_HOME").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.TaxAmtExactNormHome).HasColumnName(@"TAX_AMT_EXACT_NORM_HOME").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.TotTxblAmtHome).HasColumnName(@"TOT_TXBL_AMT_HOME").HasColumnType("decimal(21,2)").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.PoRtvHdr).WithMany(b => b.PoRtvTaxes).HasForeignKey(c => c.RtvNo).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_RTV_TAX_PO_RTV_HDR");
        }
    }

}
// </auto-generated>

// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_ORD_HIST_MISC_CHRG
    public class PsOrdHistMiscChrgConfiguration : IEntityTypeConfiguration<PsOrdHistMiscChrg>
    {
        public void Configure(EntityTypeBuilder<PsOrdHistMiscChrg> builder)
        {
            builder.ToTable("PS_ORD_HIST_MISC_CHRG", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.MiscChrgNo }).HasName("PK_PS_ORD_HIST_MISC_CHRG").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.MiscChrgNo).HasColumnName(@"MISC_CHRG_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.MiscTyp).HasColumnName(@"MISC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MiscAmt).HasColumnName(@"MISC_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.MiscPct).HasColumnName(@"MISC_PCT").HasColumnType("decimal(9,3)").IsRequired();
            builder.Property(x => x.MiscAmtShipped).HasColumnName(@"MISC_AMT_SHIPPED").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.MiscTaxAmtAlloc).HasColumnName(@"MISC_TAX_AMT_ALLOC").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.MiscNormTaxAmtAlloc).HasColumnName(@"MISC_NORM_TAX_AMT_ALLOC").HasColumnType("decimal(15,2)").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.PsOrdHist).WithMany(b => b.PsOrdHistMiscChrgs).HasForeignKey(c => new { c.BusDat, c.DocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_MISC_CHRG_PS_ORD_HIST");

            builder.HasIndex(x => new { x.MiscChrgNo, x.DocId }).HasDatabaseName("IX_PS_ORD_HIST_MISC_CHRG_MISC_CHRG_NO_DOC_ID");
        }
    }

}
// </auto-generated>

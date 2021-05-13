// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AI_VCHR
    public class AiVchrConfiguration : IEntityTypeConfiguration<AiVchr>
    {
        public void Configure(EntityTypeBuilder<AiVchr> builder)
        {
            builder.ToTable("AI_VCHR", "dbo");
            builder.HasKey(x => new { x.VchrVendNo, x.VchrNo }).HasName("PK_AI_VCHR").IsClustered();

            builder.Property(x => x.VchrVendNo).HasColumnName(@"VCHR_VEND_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.VchrNo).HasColumnName(@"VCHR_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.VchrDistDat).HasColumnName(@"VCHR_DIST_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.VchrInvcDat).HasColumnName(@"VCHR_INVC_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.VchrInvcNo).HasColumnName(@"VCHR_INVC_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.VchrRef).HasColumnName(@"VCHR_REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.VendNam).HasColumnName(@"VEND_NAM").HasColumnType("varchar(40)").IsRequired(false).IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.NonDiscAmt).HasColumnName(@"NON_DISC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DueDat).HasColumnName(@"DUE_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.DiscDat).HasColumnName(@"DISC_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.DiscAmt).HasColumnName(@"DISC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.VarianceAmt).HasColumnName(@"VARIANCE_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PoNo).HasColumnName(@"PO_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.VchrMiscAmt1).HasColumnName(@"VCHR_MISC_AMT_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt2).HasColumnName(@"VCHR_MISC_AMT_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt3).HasColumnName(@"VCHR_MISC_AMT_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt4).HasColumnName(@"VCHR_MISC_AMT_4").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.VchrMiscAmt5).HasColumnName(@"VCHR_MISC_AMT_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.VchrTotMisc).HasColumnName(@"VCHR_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.VchrSubTot).HasColumnName(@"VCHR_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.VchrSubTotLanded).HasColumnName(@"VCHR_SUB_TOT_LANDED").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.VchrTot).HasColumnName(@"VCHR_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LinMiscChrg1).HasColumnName(@"LIN_MISC_CHRG_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LinMiscChrg2).HasColumnName(@"LIN_MISC_CHRG_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LinMiscChrg3).HasColumnName(@"LIN_MISC_CHRG_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LinMiscChrg4).HasColumnName(@"LIN_MISC_CHRG_4").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LinMiscChrg5).HasColumnName(@"LIN_MISC_CHRG_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotLinMiscChrg).HasColumnName(@"TOT_LIN_MISC_CHRG").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.NoOfRecvrs).HasColumnName(@"NO_OF_RECVRS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.RecvrMiscAmt1).HasColumnName(@"RECVR_MISC_AMT_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.RecvrMiscAmt2).HasColumnName(@"RECVR_MISC_AMT_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.RecvrMiscAmt3).HasColumnName(@"RECVR_MISC_AMT_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.RecvrMiscAmt4).HasColumnName(@"RECVR_MISC_AMT_4").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.RecvrMiscAmt5).HasColumnName(@"RECVR_MISC_AMT_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.RecvrTotMisc).HasColumnName(@"RECVR_TOT_MISC").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.RecvrSubTot).HasColumnName(@"RECVR_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.RecvrTot).HasColumnName(@"RECVR_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TermsCod).HasColumnName(@"TERMS_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DueDays).HasColumnName(@"DUE_DAYS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DiscDays).HasColumnName(@"DISC_DAYS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.DiscPct).HasColumnName(@"DISC_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.DiscAcctNo).HasColumnName(@"DISC_ACCT_NO").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.CpDiscAcctNo).HasColumnName(@"CP_DISC_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.SpecTerms).HasColumnName(@"SPEC_TERMS").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.VendTerms).HasColumnName(@"VEND_TERMS").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.VchrTaxAmt).HasColumnName(@"VCHR_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.RecvrTaxAmt).HasColumnName(@"RECVR_TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
        }
    }

}
// </auto-generated>
// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_APPLY_TO_GRPS
    public class ViApplyToGrpConfiguration : IEntityTypeConfiguration<ViApplyToGrp>
    {
        public void Configure(EntityTypeBuilder<ViApplyToGrp> builder)
        {
            builder.ToView("VI_APPLY_TO_GRPS", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DocDat).HasColumnName(@"DOC_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DocNo).HasColumnName(@"DOC_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DocTyp).HasColumnName(@"DOC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TermsCod).HasColumnName(@"TERMS_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DueDat).HasColumnName(@"DUE_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DiscDat).HasColumnName(@"DISC_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DiscPct).HasColumnName(@"DISC_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.SlsRep).HasColumnName(@"SLS_REP").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CustPoNo).HasColumnName(@"CUST_PO_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ApplIsOpen).HasColumnName(@"APPL_IS_OPEN").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OrigAmt).HasColumnName(@"ORIG_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrigEntdAmt).HasColumnName(@"ORIG_ENTD_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TotDiscntblAmt).HasColumnName(@"TOT_DISCNTBL_AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.TotDiscUsed).HasColumnName(@"TOT_DISC_USED").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.TotWrtoffAmt).HasColumnName(@"TOT_WRTOFF_AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.DocBal).HasColumnName(@"DOC_BAL").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.OrigDiscAvail).HasColumnName(@"ORIG_DISC_AVAIL").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DiscAvail).HasColumnName(@"DISC_AVAIL").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.NoOfAppls).HasColumnName(@"NO_OF_APPLS").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>

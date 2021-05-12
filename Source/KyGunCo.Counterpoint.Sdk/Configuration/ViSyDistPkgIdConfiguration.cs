// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_SY_DIST_PKG_ID
    public class ViSyDistPkgIdConfiguration : IEntityTypeConfiguration<ViSyDistPkgId>
    {
        public void Configure(EntityTypeBuilder<ViSyDistPkgId> builder)
        {
            builder.ToView("VI_SY_DIST_PKG_ID", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.AcctNo).HasColumnName(@"ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.DistDat).HasColumnName(@"DIST_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.ActTyp).HasColumnName(@"ACT_TYP").HasColumnType("varchar(3)").IsRequired().IsUnicode(false).HasMaxLength(3);
            builder.Property(x => x.PkgId).HasColumnName(@"PKG_ID").HasColumnType("varchar(2)").IsRequired().IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.DistGrp).HasColumnName(@"DIST_GRP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DistTyp).HasColumnName(@"DIST_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.AccountNo).HasColumnName(@"ACCOUNT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.GlAcctNo).HasColumnName(@"GL_ACCT_NO").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Intrfacd).HasColumnName(@"INTRFACD").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.FstDocNo).HasColumnName(@"FST_DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.FstRef).HasColumnName(@"FST_REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.DebitAmt).HasColumnName(@"DEBIT_AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.CreditAmt).HasColumnName(@"CREDIT_AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(38,2)").IsRequired(false);
            builder.Property(x => x.NoEntries).HasColumnName(@"NO_ENTRIES").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>

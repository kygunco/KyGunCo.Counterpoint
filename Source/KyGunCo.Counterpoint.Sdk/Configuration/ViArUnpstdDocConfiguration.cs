// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_AR_UNPSTD_DOC
    public class ViArUnpstdDocConfiguration : IEntityTypeConfiguration<ViArUnpstdDoc>
    {
        public void Configure(EntityTypeBuilder<ViArUnpstdDoc> builder)
        {
            builder.ToView("VI_AR_UNPSTD_DOC", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.Type).HasColumnName(@"TYPE").HasColumnType("varchar(5)").IsRequired().IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DocDat).HasColumnName(@"DOC_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.DocNo).HasColumnName(@"DOC_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DocTyp).HasColumnName(@"DOC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ApplyToMeth).HasColumnName(@"APPLY_TO_METH").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ApplyToDocDat).HasColumnName(@"APPLY_TO_DOC_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ApplyToDocNo).HasColumnName(@"APPLY_TO_DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ApplyToDocTyp).HasColumnName(@"APPLY_TO_DOC_TYP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AcctNo).HasColumnName(@"ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.TermsCod).HasColumnName(@"TERMS_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DueDat).HasColumnName(@"DUE_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.DiscDat).HasColumnName(@"DISC_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.DiscPct).HasColumnName(@"DISC_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.SlsRep).HasColumnName(@"SLS_REP").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PayCod).HasColumnName(@"PAY_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
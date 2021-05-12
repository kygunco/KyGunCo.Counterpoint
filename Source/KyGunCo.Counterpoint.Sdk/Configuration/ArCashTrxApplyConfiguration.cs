// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AR_CASH_TRX_APPLY
    public class ArCashTrxApplyConfiguration : IEntityTypeConfiguration<ArCashTrxApply>
    {
        public void Configure(EntityTypeBuilder<ArCashTrxApply> builder)
        {
            builder.ToTable("AR_CASH_TRX_APPLY", "dbo");
            builder.HasKey(x => new { x.CustNo, x.DocNo, x.ApplyToDocDat, x.ApplyToDocNo, x.ApplyToDocTyp }).HasName("PK_AR_CASH_TRX_APPLY").IsClustered();

            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.DocNo).HasColumnName(@"DOC_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.ApplyToDocDat).HasColumnName(@"APPLY_TO_DOC_DAT").HasColumnType("datetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ApplyToDocNo).HasColumnName(@"APPLY_TO_DOC_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.ApplyToDocTyp).HasColumnName(@"APPLY_TO_DOC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.DiscAmt).HasColumnName(@"DISC_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.DiscAcctNo).HasColumnName(@"DISC_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.DiscAcctFromTerms).HasColumnName(@"DISC_ACCT_FROM_TERMS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.WrtoffAmt).HasColumnName(@"WRTOFF_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.WrtoffAcctNo).HasColumnName(@"WRTOFF_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.UseDfltWrtoffAcct).HasColumnName(@"USE_DFLT_WRTOFF_ACCT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LinIsOpn).HasColumnName(@"LIN_IS_OPN").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.ArCashTrx).WithMany(b => b.ArCashTrxApplies).HasForeignKey(c => new { c.CustNo, c.DocNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AR_CASH_TRX_APPLY_AR_CASH_TRX");

            builder.HasIndex(x => new { x.CustNo, x.DocNo, x.SeqNo }).HasDatabaseName("AR_CASH_TRX_APPLY_X1");
        }
    }

}
// </auto-generated>

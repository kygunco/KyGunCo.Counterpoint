// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AR_ADJ_TRX
    public class ArAdjTrxConfiguration : IEntityTypeConfiguration<ArAdjTrx>
    {
        public void Configure(EntityTypeBuilder<ArAdjTrx> builder)
        {
            builder.ToTable("AR_ADJ_TRX", "dbo");
            builder.HasKey(x => new { x.CustNo, x.DocDat, x.DocNo, x.DocTyp }).HasName("PK_AR_ADJ_TRX").IsClustered();

            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.DocDat).HasColumnName(@"DOC_DAT").HasColumnType("datetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocNo).HasColumnName(@"DOC_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.DocTyp).HasColumnName(@"DOC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedNever();
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.EntrySeqNo).HasColumnName(@"ENTRY_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.ApplyToMeth).HasColumnName(@"APPLY_TO_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ApplyToDocDat).HasColumnName(@"APPLY_TO_DOC_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ApplyToDocNo).HasColumnName(@"APPLY_TO_DOC_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.ApplyToDocTyp).HasColumnName(@"APPLY_TO_DOC_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.EntdAmt).HasColumnName(@"ENTD_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.AcctNo).HasColumnName(@"ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.TermsCod).HasColumnName(@"TERMS_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.DueDat).HasColumnName(@"DUE_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DiscDat).HasColumnName(@"DISC_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DiscPct).HasColumnName(@"DISC_PCT").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.SlsRep).HasColumnName(@"SLS_REP").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ErrRef).HasColumnName(@"ERR_REF").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ArCust).WithMany(b => b.ArAdjTrxes).HasForeignKey(c => c.CustNo).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_AR_ADJ_TRX_AR_CUST");

            builder.HasIndex(x => new { x.BatId, x.EntrySeqNo, x.CustNo, x.DocDat, x.DocNo, x.DocTyp }).HasDatabaseName("AR_ADJ_TRX_X1");
        }
    }

}
// </auto-generated>

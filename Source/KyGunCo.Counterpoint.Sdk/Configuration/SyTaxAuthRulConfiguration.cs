// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_TAX_AUTH_RUL
    public class SyTaxAuthRulConfiguration : IEntityTypeConfiguration<SyTaxAuthRul>
    {
        public void Configure(EntityTypeBuilder<SyTaxAuthRul> builder)
        {
            builder.ToTable("SY_TAX_AUTH_RUL", "dbo");
            builder.HasKey(x => new { x.AuthCod, x.RulSeqNo }).HasName("PK_SY_TAX_AUTH_RUL").IsClustered();

            builder.Property(x => x.AuthCod).HasColumnName(@"AUTH_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.RulCod).HasColumnName(@"RUL_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RulSeqNo).HasColumnName(@"RUL_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.StopChrgngTax).HasColumnName(@"STOP_CHRGNG_TAX").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxIsTxbl).HasColumnName(@"TAX_IS_TXBL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxAcctNo).HasColumnName(@"TAX_ACCT_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.TaxMeth).HasColumnName(@"TAX_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxCategCod1).HasColumnName(@"TAX_CATEG_COD_1").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCategCod2).HasColumnName(@"TAX_CATEG_COD_2").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCategCod3).HasColumnName(@"TAX_CATEG_COD_3").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCategCod4).HasColumnName(@"TAX_CATEG_COD_4").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxCategCod5).HasColumnName(@"TAX_CATEG_COD_5").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxGfc).HasColumnName(@"TAX_GFC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxMisc1).HasColumnName(@"TAX_MISC_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxMisc2).HasColumnName(@"TAX_MISC_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxMisc3).HasColumnName(@"TAX_MISC_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxMisc4).HasColumnName(@"TAX_MISC_4").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxMisc5).HasColumnName(@"TAX_MISC_5").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.MinUnitTxblAmt).HasColumnName(@"MIN_UNIT_TXBL_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.MaxUnitTxblAmt).HasColumnName(@"MAX_UNIT_TXBL_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.NoMaxUnitTxblAmt).HasColumnName(@"NO_MAX_UNIT_TXBL_AMT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UnitAmtBelowMinTxbl).HasColumnName(@"UNIT_AMT_BELOW_MIN_TXBL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxPct1).HasColumnName(@"TAX_PCT_1").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.TaxAmtOvr1).HasColumnName(@"TAX_AMT_OVR_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TaxPct2).HasColumnName(@"TAX_PCT_2").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.TaxAmtOvr2).HasColumnName(@"TAX_AMT_OVR_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TaxPct3).HasColumnName(@"TAX_PCT_3").HasColumnType("decimal(9,3)").IsRequired(false);
            builder.Property(x => x.TaxAmtOvr3).HasColumnName(@"TAX_AMT_OVR_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TaxPerUnit).HasColumnName(@"TAX_PER_UNIT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.TaxRndMeth).HasColumnName(@"TAX_RND_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.UsePennyTaxTbl).HasColumnName(@"USE_PENNY_TAX_TBL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PennyTaxAmt0).HasColumnName(@"PENNY_TAX_AMT_0").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PennyTaxAmt1).HasColumnName(@"PENNY_TAX_AMT_1").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PennyTaxAmt2).HasColumnName(@"PENNY_TAX_AMT_2").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PennyTaxAmt3).HasColumnName(@"PENNY_TAX_AMT_3").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PennyTaxAmt4).HasColumnName(@"PENNY_TAX_AMT_4").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PennyTaxAmt5).HasColumnName(@"PENNY_TAX_AMT_5").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PennyTaxAmt6).HasColumnName(@"PENNY_TAX_AMT_6").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PennyTaxAmt7).HasColumnName(@"PENNY_TAX_AMT_7").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PennyTaxAmt8).HasColumnName(@"PENNY_TAX_AMT_8").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PennyTaxAmt9).HasColumnName(@"PENNY_TAX_AMT_9").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PennyTaxAmt10).HasColumnName(@"PENNY_TAX_AMT_10").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.PennyTaxAmt11).HasColumnName(@"PENNY_TAX_AMT_11").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TaxHoliday).HasColumnName(@"TAX_HOLIDAY").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxHolidayBeg).HasColumnName(@"TAX_HOLIDAY_BEG").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.TaxHolidayEnd).HasColumnName(@"TAX_HOLIDAY_END").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RulApplyToCategMod).HasColumnName(@"RUL_APPLY_TO_CATEG_MOD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TaxCategCod6).HasColumnName(@"TAX_CATEG_COD_6").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TaxSvc).HasColumnName(@"TAX_SVC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoTaxAcctNo).HasColumnName(@"PO_TAX_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.PoTaxMeth).HasColumnName(@"PO_TAX_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoTaxMisc1).HasColumnName(@"PO_TAX_MISC_1").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoTaxMisc2).HasColumnName(@"PO_TAX_MISC_2").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoTaxMisc3).HasColumnName(@"PO_TAX_MISC_3").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoTaxMisc4).HasColumnName(@"PO_TAX_MISC_4").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PoTaxMisc5).HasColumnName(@"PO_TAX_MISC_5").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);

            // Foreign keys
            builder.HasOne(a => a.SyTaxAuth).WithMany(b => b.SyTaxAuthRuls).HasForeignKey(c => c.AuthCod).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SY_TAX_AUTH_RUL_SY_TAX_AUTH");

            builder.HasIndex(x => new { x.AuthCod, x.RulCod, x.RulSeqNo }).HasDatabaseName("SY_TAX_AUTH_RUL_X1");
            builder.HasIndex(x => new { x.DescrUpr, x.AuthCod, x.RulSeqNo }).HasDatabaseName("SY_TAX_AUTH_RUL_X2");
        }
    }

}
// </auto-generated>

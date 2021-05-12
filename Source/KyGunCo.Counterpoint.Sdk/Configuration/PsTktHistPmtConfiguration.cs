// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_TKT_HIST_PMT
    public class PsTktHistPmtConfiguration : IEntityTypeConfiguration<PsTktHistPmt>
    {
        public void Configure(EntityTypeBuilder<PsTktHistPmt> builder)
        {
            builder.ToTable("PS_TKT_HIST_PMT", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.PmtSeqNo }).HasName("PK_PS_TKT_HIST_PMT").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PmtSeqNo).HasColumnName(@"PMT_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PmtLinTyp).HasColumnName(@"PMT_LIN_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PayCod).HasColumnName(@"PAY_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PayCodTyp).HasColumnName(@"PAY_COD_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PayDat).HasColumnName(@"PAY_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.HomeCurncyAmt).HasColumnName(@"HOME_CURNCY_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.ExchLoss).HasColumnName(@"EXCH_LOSS").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.CurncyCod).HasColumnName(@"CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ExchRateNumer).HasColumnName(@"EXCH_RATE_NUMER").HasColumnType("money").IsRequired();
            builder.Property(x => x.ExchRateDenom).HasColumnName(@"EXCH_RATE_DENOM").HasColumnType("money").IsRequired();
            builder.Property(x => x.Swiped).HasColumnName(@"SWIPED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CardNo).HasColumnName(@"CARD_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CardIsNew).HasColumnName(@"CARD_IS_NEW").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SigImg).HasColumnName(@"SIG_IMG").HasColumnType("image(2147483647)").IsRequired(false).HasMaxLength(2147483647);
            builder.Property(x => x.SigImgVector).HasColumnName(@"SIG_IMG_VECTOR").HasColumnType("image(2147483647)").IsRequired(false).HasMaxLength(2147483647);
            builder.Property(x => x.SecureEcommTrx).HasColumnName(@"SECURE_ECOMM_TRX").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EdcAuthCod).HasColumnName(@"EDC_AUTH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.EbtBalRemain).HasColumnName(@"EBT_BAL_REMAIN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LoyPtsRdm).HasColumnName(@"LOY_PTS_RDM").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SvcBalRemain).HasColumnName(@"SVC_BAL_REMAIN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SvcRefNo).HasColumnName(@"SVC_REF_NO").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RoundGainLoss).HasColumnName(@"ROUND_GAIN_LOSS").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.HomeCurncyRoundGainLoss).HasColumnName(@"HOME_CURNCY_ROUND_GAIN_LOSS").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TipAmt).HasColumnName(@"TIP_AMT").HasColumnType("decimal(15,2)").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.PsTktHist).WithMany(b => b.PsTktHistPmts).HasForeignKey(c => new { c.BusDat, c.DocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_TKT_HIST_PMT_PS_TKT_HIST");

            builder.HasIndex(x => new { x.StrId, x.StaId, x.TktNo, x.PmtSeqNo }).HasDatabaseName("PS_TKT_HIST_PMT_X1");
        }
    }

}
// </auto-generated>

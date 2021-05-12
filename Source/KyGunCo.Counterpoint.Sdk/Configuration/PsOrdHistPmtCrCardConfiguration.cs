// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_ORD_HIST_PMT_CR_CARD
    public class PsOrdHistPmtCrCardConfiguration : IEntityTypeConfiguration<PsOrdHistPmtCrCard>
    {
        public void Configure(EntityTypeBuilder<PsOrdHistPmtCrCard> builder)
        {
            builder.ToTable("PS_ORD_HIST_PMT_CR_CARD", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.PmtSeqNo }).HasName("PK_PS_ORD_HIST_PMT_CR_CARD").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PmtSeqNo).HasColumnName(@"PMT_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.CrCardNo).HasColumnName(@"CR_CARD_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CrCardNoEnc).HasColumnName(@"CR_CARD_NO_ENC").HasColumnType("varbinary(32)").IsRequired(false).HasMaxLength(32);
            builder.Property(x => x.CrCardNoMsk).HasColumnName(@"CR_CARD_NO_MSK").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CrCardNam).HasColumnName(@"CR_CARD_NAM").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CrCardExpDat).HasColumnName(@"CR_CARD_EXP_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.AvsAdrs).HasColumnName(@"AVS_ADRS").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.AvsZipCod).HasColumnName(@"AVS_ZIP_COD").HasColumnType("varchar(9)").IsRequired(false).IsUnicode(false).HasMaxLength(9);
            builder.Property(x => x.AvsCod).HasColumnName(@"AVS_COD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SkipAvs).HasColumnName(@"SKIP_AVS").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CvvCod).HasColumnName(@"CVV_COD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SkipCvv).HasColumnName(@"SKIP_CVV").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.IsPurchCard).HasColumnName(@"IS_PURCH_CARD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CrCardNoKid).HasColumnName(@"CR_CARD_NO_KID").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.OfflineGuid).HasColumnName(@"OFFLINE_GUID").HasColumnType("uniqueidentifier").IsRequired(false);
            builder.Property(x => x.IsEbtFood).HasColumnName(@"IS_EBT_FOOD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);

            // Foreign keys
            builder.HasOne(a => a.PsOrdHistPmt).WithOne(b => b.PsOrdHistPmtCrCard).HasForeignKey<PsOrdHistPmtCrCard>(c => new { c.BusDat, c.DocId, c.PmtSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_ORD_HIST_PMT_CR_CARD_PS_ORD_HIST_PMT");
        }
    }

}
// </auto-generated>

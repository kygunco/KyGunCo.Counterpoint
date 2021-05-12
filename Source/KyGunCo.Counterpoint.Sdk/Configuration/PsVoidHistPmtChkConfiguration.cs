// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_VOID_HIST_PMT_CHK
    public class PsVoidHistPmtChkConfiguration : IEntityTypeConfiguration<PsVoidHistPmtChk>
    {
        public void Configure(EntityTypeBuilder<PsVoidHistPmtChk> builder)
        {
            builder.ToTable("PS_VOID_HIST_PMT_CHK", "dbo");
            builder.HasKey(x => new { x.BusDat, x.DocId, x.PmtSeqNo }).HasName("PK_PS_VOID_HIST_PMT_CHK").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PmtSeqNo).HasColumnName(@"PMT_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ChkAcctNo).HasColumnName(@"CHK_ACCT_NO").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.ChkTransitNo).HasColumnName(@"CHK_TRANSIT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ChkNo).HasColumnName(@"CHK_NO").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ChkDrivLicNo).HasColumnName(@"CHK_DRIV_LIC_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ChkDrivLicState).HasColumnName(@"CHK_DRIV_LIC_STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ChkBirthDat).HasColumnName(@"CHK_BIRTH_DAT").HasColumnType("datetime").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.PsVoidHistPmt).WithOne(b => b.PsVoidHistPmtChk).HasForeignKey<PsVoidHistPmtChk>(c => new { c.BusDat, c.DocId, c.PmtSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PS_VOID_HIST_PMT_CHK_PS_VOID_HIST_PMT");
        }
    }

}
// </auto-generated>

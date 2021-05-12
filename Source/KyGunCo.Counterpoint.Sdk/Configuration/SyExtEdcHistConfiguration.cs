// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_EXT_EDC_HIST
    public class SyExtEdcHistConfiguration : IEntityTypeConfiguration<SyExtEdcHist>
    {
        public void Configure(EntityTypeBuilder<SyExtEdcHist> builder)
        {
            builder.ToTable("SY_EXT_EDC_HIST", "dbo");
            builder.HasKey(x => x.EventNo).HasName("PK_SY_EXT_EDC_HIST").IsClustered();

            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.BatchNo).HasColumnName(@"BATCH_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.TermId).HasColumnName(@"TERM_ID").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);

            builder.HasIndex(x => new { x.StrId, x.BusDat, x.EventNo }).HasDatabaseName("SY_EXT_EDC_HIST_X1");
        }
    }

}
// </auto-generated>

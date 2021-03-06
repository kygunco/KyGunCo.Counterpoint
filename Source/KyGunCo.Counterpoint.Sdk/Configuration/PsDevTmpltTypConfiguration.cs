// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PS_DEV_TMPLT_TYP
    public class PsDevTmpltTypConfiguration : IEntityTypeConfiguration<PsDevTmpltTyp>
    {
        public void Configure(EntityTypeBuilder<PsDevTmpltTyp> builder)
        {
            builder.ToTable("PS_DEV_TMPLT_TYP", "dbo");
            builder.HasKey(x => x.DevTmpltTypId).HasName("PK_PS_DEV_TMPLT_TYP").IsClustered();

            builder.Property(x => x.DevTmpltTypId).HasColumnName(@"DEV_TMPLT_TYP_ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Nam).HasColumnName(@"NAM").HasColumnType("varchar(40)").IsRequired().IsUnicode(false).HasMaxLength(40);
            builder.Property(x => x.RsUtcDt).HasColumnName(@"RS_UTC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired();

            builder.HasIndex(x => x.RsStat).HasDatabaseName("PS_DEV_TMPLT_TYP_X_RS_STAT");
            builder.HasIndex(x => x.RsUtcDt).HasDatabaseName("PS_DEV_TMPLT_TYP_X_RS_UTC_DT");
        }
    }

}
// </auto-generated>

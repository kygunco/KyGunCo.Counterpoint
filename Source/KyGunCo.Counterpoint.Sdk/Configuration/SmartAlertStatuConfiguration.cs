// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SmartAlertStatus
    public class SmartAlertStatuConfiguration : IEntityTypeConfiguration<SmartAlertStatu>
    {
        public void Configure(EntityTypeBuilder<SmartAlertStatu> builder)
        {
            builder.ToTable("SmartAlertStatus", "dbo");
            builder.HasKey(x => new { x.Id, x.CompareTxt }).HasName("PK_SmartAlertStatus").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("varchar(64)").IsRequired().IsUnicode(false).HasMaxLength(64).ValueGeneratedNever();
            builder.Property(x => x.CompareTxt).HasColumnName(@"CompareTxt").HasColumnType("varchar(255)").IsRequired().IsUnicode(false).HasMaxLength(255).ValueGeneratedNever();
            builder.Property(x => x.LastModifiedTimeStamp).HasColumnName(@"LastModifiedTimeStamp").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>

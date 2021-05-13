// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_BOUND_BOOK_ITEM_COUNTRY
    public class UserBoundBookItemCountryConfiguration : IEntityTypeConfiguration<UserBoundBookItemCountry>
    {
        public void Configure(EntityTypeBuilder<UserBoundBookItemCountry> builder)
        {
            builder.ToTable("USER_BOUND_BOOK_ITEM_COUNTRY", "dbo");
            builder.HasKey(x => x.UserCountry);

            builder.Property(x => x.UserCountry).HasColumnName(@"USER_COUNTRY").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50).ValueGeneratedNever();
            builder.Property(x => x.UserIsoCountryCode).HasColumnName(@"USER_ISO_COUNTRY_CODE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
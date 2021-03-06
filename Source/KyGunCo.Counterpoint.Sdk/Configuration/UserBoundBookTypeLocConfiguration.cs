// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_BOUND_BOOK_TYPE_LOC
    public class UserBoundBookTypeLocConfiguration : IEntityTypeConfiguration<UserBoundBookTypeLoc>
    {
        public void Configure(EntityTypeBuilder<UserBoundBookTypeLoc> builder)
        {
            builder.ToTable("USER_BOUND_BOOK_TYPE_LOC", "dbo");
            builder.HasKey(x => new { x.LocId, x.UserBoundBookType }).HasName("PK_USER_BOUND_BOOK_TYPE_LOC");

            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.UserBoundBookType).HasColumnName(@"USER_BOUND_BOOK_TYPE").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50).ValueGeneratedNever();
            builder.Property(x => x.UserFfl).HasColumnName(@"USER_FFL").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.UserFflAllowUpdate).HasColumnName(@"USER_FFL_ALLOW_UPDATE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
        }
    }

}
// </auto-generated>

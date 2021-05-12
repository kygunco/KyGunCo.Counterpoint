// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_BOUND_BOOK_CTL
    public class UserBoundBookCtlConfiguration : IEntityTypeConfiguration<UserBoundBookCtl>
    {
        public void Configure(EntityTypeBuilder<UserBoundBookCtl> builder)
        {
            builder.ToTable("USER_BOUND_BOOK_CTL", "dbo");
            builder.HasKey(x => x.KeyId).HasName("PK_USER_BOUND_BOOK_CTL").IsClustered();

            builder.Property(x => x.KeyId).HasColumnName(@"KEY_ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.BoundBookVersion).HasColumnName(@"BOUND_BOOK_VERSION").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.RangeManagementVersion).HasColumnName(@"RANGE_MANAGEMENT_VERSION").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.E4473Version).HasColumnName(@"E4473_VERSION").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.FirearmRentalVersion).HasColumnName(@"FIREARM_RENTAL_VERSION").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
        }
    }

}
// </auto-generated>

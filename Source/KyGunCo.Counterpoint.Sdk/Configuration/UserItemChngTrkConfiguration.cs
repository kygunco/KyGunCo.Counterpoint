// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_ITEM_CHNG_TRK
    public class UserItemChngTrkConfiguration : IEntityTypeConfiguration<UserItemChngTrk>
    {
        public void Configure(EntityTypeBuilder<UserItemChngTrk> builder)
        {
            builder.ToTable("USER_ITEM_CHNG_TRK", "dbo");
            builder.HasKey(x => new { x.ItemNo, x.ChngDt, x.UsrId }).HasName("PK_USER_ITEM_CHNG_TRK").IsClustered();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.ChngDt).HasColumnName(@"CHNG_DT").HasColumnType("datetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.ChngMade).HasColumnName(@"CHNG_MADE").HasColumnType("varchar(1000)").IsRequired(false).IsUnicode(false).HasMaxLength(1000);
        }
    }

}
// </auto-generated>

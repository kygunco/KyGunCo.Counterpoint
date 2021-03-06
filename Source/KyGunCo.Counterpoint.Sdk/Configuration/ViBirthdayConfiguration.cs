// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_Birthday
    public class ViBirthdayConfiguration : IEntityTypeConfiguration<ViBirthday>
    {
        public void Configure(EntityTypeBuilder<ViBirthday> builder)
        {
            builder.ToView("VI_Birthday", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.UserDlNo).HasColumnName(@"USER_DL_NO").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.FstNam).HasColumnName(@"FST_NAM").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LstNam).HasColumnName(@"LST_NAM").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.UserDob).HasColumnName(@"USER_DOB").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.EmailAdrs1).HasColumnName(@"EMAIL_ADRS_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.State).HasColumnName(@"STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
        }
    }

}
// </auto-generated>

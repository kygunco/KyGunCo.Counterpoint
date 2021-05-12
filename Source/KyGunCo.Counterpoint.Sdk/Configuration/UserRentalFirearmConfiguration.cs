// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_RENTAL_FIREARM
    public class UserRentalFirearmConfiguration : IEntityTypeConfiguration<UserRentalFirearm>
    {
        public void Configure(EntityTypeBuilder<UserRentalFirearm> builder)
        {
            builder.ToTable("USER_RENTAL_FIREARM", "dbo");
            builder.HasKey(x => x.ItemNo).HasName("PK_USER_RENTAL_FIREARM").IsClustered();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.QtyRentalA).HasColumnName(@"QTY_RENTAL_A").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.QtyRoundsA).HasColumnName(@"QTY_ROUNDS_A").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.MaxRentalA).HasColumnName(@"MAX_RENTAL_A").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.MaxRoundsA).HasColumnName(@"MAX_ROUNDS_A").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.QtyRentalB).HasColumnName(@"QTY_RENTAL_B").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.QtyRoundsB).HasColumnName(@"QTY_ROUNDS_B").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.MaxRentalB).HasColumnName(@"MAX_RENTAL_B").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.MaxRoundsB).HasColumnName(@"MAX_ROUNDS_B").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.QtyRentalC).HasColumnName(@"QTY_RENTAL_C").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.QtyRoundsC).HasColumnName(@"QTY_ROUNDS_C").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.MaxRentalC).HasColumnName(@"MAX_RENTAL_C").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.MaxRoundsC).HasColumnName(@"MAX_ROUNDS_C").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.QtyRentalLifetime).HasColumnName(@"QTY_RENTAL_LIFETIME").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.QtyRoundsLifetime).HasColumnName(@"QTY_ROUNDS_LIFETIME").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.MaxRentalLifetime).HasColumnName(@"MAX_RENTAL_LIFETIME").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.MaxRoundsLifetime).HasColumnName(@"MAX_ROUNDS_LIFETIME").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.MaintLblA).HasColumnName(@"MAINT_LBL_A").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.MaintLblB).HasColumnName(@"MAINT_LBL_B").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.MaintLblC).HasColumnName(@"MAINT_LBL_C").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.MaintLblLifetime).HasColumnName(@"MAINT_LBL_LIFETIME").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.DashLbl).HasColumnName(@"DASH_LBL").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Prc1).HasColumnName(@"PRC_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.MaintNote).HasColumnName(@"MAINT_NOTE").HasColumnType("text(2147483647)").IsRequired(false).IsUnicode(false).HasMaxLength(2147483647);
        }
    }

}
// </auto-generated>

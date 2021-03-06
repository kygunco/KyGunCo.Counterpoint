// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // USER_BOUND_BOOK_INTAKE_TO_INV
    public class UserBoundBookIntakeToInvConfiguration : IEntityTypeConfiguration<UserBoundBookIntakeToInv>
    {
        public void Configure(EntityTypeBuilder<UserBoundBookIntakeToInv> builder)
        {
            builder.ToTable("USER_BOUND_BOOK_INTAKE_TO_INV", "dbo");
            builder.HasKey(x => new { x.DocNo, x.IntakeType }).HasName("PK_USER_BOUND_BOOK_INTAKE_TO_INV").IsClustered();

            builder.Property(x => x.IntakeType).HasColumnName(@"INTAKE_TYPE").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.DocNo).HasColumnName(@"DOC_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Cost).HasColumnName(@"COST").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>

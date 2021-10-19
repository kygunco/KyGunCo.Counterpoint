// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_KIT_PAR
    public class ImKitParConfiguration : IEntityTypeConfiguration<ImKitPar>
    {
        public void Configure(EntityTypeBuilder<ImKitPar> builder)
        {
            builder.ToTable("IM_KIT_PAR", "dbo");
            builder.HasKey(x => x.ItemNo).HasName("PK_IM_KIT_PAR").IsClustered();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.KitTyp).HasColumnName(@"KIT_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.InclPar).HasColumnName(@"INCL_PAR").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Commnt).HasColumnName(@"COMMNT").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.DsplyNote).HasColumnName(@"DSPLY_NOTE").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImItem).WithOne(b => b.ImKitPar).HasForeignKey<ImKitPar>(c => c.ItemNo).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_KIT_PAR_IM_ITEM");
        }
    }

}
// </auto-generated>

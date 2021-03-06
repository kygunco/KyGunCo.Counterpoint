// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // RS_DEL_SY_MENU_REC_USED
    public class RsDelSyMenuRecUsedConfiguration : IEntityTypeConfiguration<RsDelSyMenuRecUsed>
    {
        public void Configure(EntityTypeBuilder<RsDelSyMenuRecUsed> builder)
        {
            builder.ToTable("RS_DEL_SY_MENU_REC_USED", "dbo");
            builder.HasKey(x => x.DelId).HasName("PK_RS_DEL_SY_MENU_REC_USED").IsClustered();

            builder.Property(x => x.DelId).HasColumnName(@"DEL_ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.DeleteDt).HasColumnName(@"DELETE_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.MenuItemId).HasColumnName(@"MENU_ITEM_ID").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
        }
    }

}
// </auto-generated>

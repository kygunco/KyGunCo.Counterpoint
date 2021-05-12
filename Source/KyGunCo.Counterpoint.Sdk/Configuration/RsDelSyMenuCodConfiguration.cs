// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // RS_DEL_SY_MENU_COD
    public class RsDelSyMenuCodConfiguration : IEntityTypeConfiguration<RsDelSyMenuCod>
    {
        public void Configure(EntityTypeBuilder<RsDelSyMenuCod> builder)
        {
            builder.ToTable("RS_DEL_SY_MENU_COD", "dbo");
            builder.HasKey(x => x.DelId).HasName("PK_RS_DEL_SY_MENU_COD").IsClustered();

            builder.Property(x => x.DelId).HasColumnName(@"DEL_ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.DeleteDt).HasColumnName(@"DELETE_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.MenuCod).HasColumnName(@"MENU_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>

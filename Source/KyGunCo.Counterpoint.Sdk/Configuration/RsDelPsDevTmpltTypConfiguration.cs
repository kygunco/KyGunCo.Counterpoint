// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // RS_DEL_PS_DEV_TMPLT_TYP
    public class RsDelPsDevTmpltTypConfiguration : IEntityTypeConfiguration<RsDelPsDevTmpltTyp>
    {
        public void Configure(EntityTypeBuilder<RsDelPsDevTmpltTyp> builder)
        {
            builder.ToTable("RS_DEL_PS_DEV_TMPLT_TYP", "dbo");
            builder.HasKey(x => x.DelId).HasName("PK_RS_DEL_PS_DEV_TMPLT_TYP").IsClustered();

            builder.Property(x => x.DelId).HasColumnName(@"DEL_ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.DeleteDt).HasColumnName(@"DELETE_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.DevTmpltTypId).HasColumnName(@"DEV_TMPLT_TYP_ID").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>

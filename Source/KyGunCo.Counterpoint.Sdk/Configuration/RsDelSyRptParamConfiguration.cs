// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // RS_DEL_SY_RPT_PARAMS
    public class RsDelSyRptParamConfiguration : IEntityTypeConfiguration<RsDelSyRptParam>
    {
        public void Configure(EntityTypeBuilder<RsDelSyRptParam> builder)
        {
            builder.ToTable("RS_DEL_SY_RPT_PARAMS", "dbo");
            builder.HasKey(x => x.DelId).HasName("PK_RS_DEL_SY_RPT_PARAMS").IsClustered();

            builder.Property(x => x.DelId).HasColumnName(@"DEL_ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.DeleteDt).HasColumnName(@"DELETE_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.FrmClass).HasColumnName(@"FRM_CLASS").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.UsrId).HasColumnName(@"USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RptNam).HasColumnName(@"RPT_NAM").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);
        }
    }

}
// </auto-generated>

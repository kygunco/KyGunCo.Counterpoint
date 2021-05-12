// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // RS_DEL_SY_ACCT
    public class RsDelSyAcctConfiguration : IEntityTypeConfiguration<RsDelSyAcct>
    {
        public void Configure(EntityTypeBuilder<RsDelSyAcct> builder)
        {
            builder.ToTable("RS_DEL_SY_ACCT", "dbo");
            builder.HasKey(x => x.DelId).HasName("PK_RS_DEL_SY_ACCT").IsClustered();

            builder.Property(x => x.DelId).HasColumnName(@"DEL_ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.RsStat).HasColumnName(@"RS_STAT").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.DeleteDt).HasColumnName(@"DELETE_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.AcctNo).HasColumnName(@"ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
        }
    }

}
// </auto-generated>

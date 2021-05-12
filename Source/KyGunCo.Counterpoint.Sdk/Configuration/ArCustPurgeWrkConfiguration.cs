// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AR_CUST_PURGE_WRK
    public class ArCustPurgeWrkConfiguration : IEntityTypeConfiguration<ArCustPurgeWrk>
    {
        public void Configure(EntityTypeBuilder<ArCustPurgeWrk> builder)
        {
            builder.ToTable("AR_CUST_PURGE_WRK", "dbo");
            builder.HasKey(x => new { x.SessId, x.CustNo }).HasName("PK_AR_CUST_PURGE_WRK").IsClustered();

            builder.Property(x => x.SessId).HasColumnName(@"SESS_ID").HasColumnType("varchar(40)").IsRequired().IsUnicode(false).HasMaxLength(40).ValueGeneratedNever();
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.PurgeStat).HasColumnName(@"PURGE_STAT").HasColumnType("varchar(4000)").IsRequired(false).IsUnicode(false).HasMaxLength(4000);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.CanPurge).HasColumnName(@"CAN_PURGE").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedOnAddOrUpdate();
        }
    }

}
// </auto-generated>

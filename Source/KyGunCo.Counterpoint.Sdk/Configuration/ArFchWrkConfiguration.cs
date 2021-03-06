// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // AR_FCH_WRK
    public class ArFchWrkConfiguration : IEntityTypeConfiguration<ArFchWrk>
    {
        public void Configure(EntityTypeBuilder<ArFchWrk> builder)
        {
            builder.ToTable("AR_FCH_WRK", "dbo");
            builder.HasKey(x => new { x.SessId, x.CustNo }).HasName("PK_AR_FCH_WRK").IsClustered();

            builder.Property(x => x.SessId).HasColumnName(@"SESS_ID").HasColumnType("varchar(40)").IsRequired().IsUnicode(false).HasMaxLength(40).ValueGeneratedNever();
            builder.Property(x => x.CustNo).HasColumnName(@"CUST_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.CalcFchCod).HasColumnName(@"CALC_FCH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CalcAmtPastDue).HasColumnName(@"CALC_AMT_PAST_DUE").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.CalcFchAmt).HasColumnName(@"CALC_FCH_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.CalcDt).HasColumnName(@"CALC_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
        }
    }

}
// </auto-generated>

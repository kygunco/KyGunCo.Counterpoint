// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_CNT_HIST_SER
    public class ImCntHistSerConfiguration : IEntityTypeConfiguration<ImCntHistSer>
    {
        public void Configure(EntityTypeBuilder<ImCntHistSer> builder)
        {
            builder.ToTable("IM_CNT_HIST_SER", "dbo");
            builder.HasKey(x => new { x.EventNo, x.ItemNo, x.LocId, x.SerNo }).HasName("PK_IM_CNT_HIST_SER").IsClustered();

            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();
            builder.Property(x => x.WasFrz).HasColumnName(@"WAS_FRZ").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.WasCntd).HasColumnName(@"WAS_CNTD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.FrzStat).HasColumnName(@"FRZ_STAT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.StatAtPost).HasColumnName(@"STAT_AT_POST").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SerCostAtPost).HasColumnName(@"SER_COST_AT_POST").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.ReconActiv).HasColumnName(@"RECON_ACTIV").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.ImCntHist).WithMany(b => b.ImCntHistSers).HasForeignKey(c => new { c.EventNo, c.ItemNo, c.LocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_CNT_HIST_SER_IM_CNT_HIST");
        }
    }

}
// </auto-generated>

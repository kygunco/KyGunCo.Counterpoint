// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_XFER_RECON_HIST
    public class ImXferReconHistConfiguration : IEntityTypeConfiguration<ImXferReconHist>
    {
        public void Configure(EntityTypeBuilder<ImXferReconHist> builder)
        {
            builder.ToTable("IM_XFER_RECON_HIST", "dbo");
            builder.HasKey(x => x.XferNo).HasName("PK_IM_XFER_RECON_HIST").IsClustered();

            builder.Property(x => x.XferNo).HasColumnName(@"XFER_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.FromLocId).HasColumnName(@"FROM_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ToLocId).HasColumnName(@"TO_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ReconDat).HasColumnName(@"RECON_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ReconBy).HasColumnName(@"RECON_BY").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Commnt1).HasColumnName(@"COMMNT_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt2).HasColumnName(@"COMMNT_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt3).HasColumnName(@"COMMNT_3").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImLocHist).WithMany(b => b.ImXferReconHists).HasForeignKey(c => c.FromLocId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_XFER_RECON_HIST_IM_LOC_HIST");

            builder.HasIndex(x => new { x.FromLocId, x.ToLocId, x.XferNo }).HasDatabaseName("IM_XFER_RECON_HIST_X1");
            builder.HasIndex(x => new { x.ToLocId, x.FromLocId, x.XferNo }).HasDatabaseName("IM_XFER_RECON_HIST_X2");
            builder.HasIndex(x => new { x.EventNo, x.XferNo }).HasDatabaseName("IM_XFER_RECON_HIST_X3");
            builder.HasIndex(x => new { x.ReconDat, x.XferNo }).HasDatabaseName("IM_XFER_RECON_HIST_X4");
        }
    }

}
// </auto-generated>

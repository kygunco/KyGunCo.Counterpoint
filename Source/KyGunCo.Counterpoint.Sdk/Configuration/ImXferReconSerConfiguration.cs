// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_XFER_RECON_SER
    public class ImXferReconSerConfiguration : IEntityTypeConfiguration<ImXferReconSer>
    {
        public void Configure(EntityTypeBuilder<ImXferReconSer> builder)
        {
            builder.ToTable("IM_XFER_RECON_SER", "dbo");
            builder.HasKey(x => new { x.XferNo, x.XferLinSeqNo, x.SerNo }).HasName("PK_IM_XFER_RECON_SER").IsClustered();

            builder.Property(x => x.XferNo).HasColumnName(@"XFER_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.XferLinSeqNo).HasColumnName(@"XFER_LIN_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30).ValueGeneratedNever();
            builder.Property(x => x.SerSeqNo).HasColumnName(@"SER_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SerNoRecvd).HasColumnName(@"SER_NO_RECVD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImXferReconLin).WithMany(b => b.ImXferReconSers).HasForeignKey(c => new { c.XferNo, c.XferLinSeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_XFER_RECON_SER_IM_XFER_RECON_LIN");

            builder.HasIndex(x => new { x.XferNo, x.XferLinSeqNo, x.SerSeqNo }).HasDatabaseName("IM_XFER_RECON_SER_X1");
        }
    }

}
// </auto-generated>

// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_XFER_IN_HDR
    public class ImXferInHdrConfiguration : IEntityTypeConfiguration<ImXferInHdr>
    {
        public void Configure(EntityTypeBuilder<ImXferInHdr> builder)
        {
            builder.ToTable("IM_XFER_IN_HDR", "dbo");
            builder.HasKey(x => x.XferNo).HasName("PK_IM_XFER_IN_HDR").IsClustered();

            builder.Property(x => x.XferNo).HasColumnName(@"XFER_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.FromLocId).HasColumnName(@"FROM_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ToLocId).HasColumnName(@"TO_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RecvdDat).HasColumnName(@"RECVD_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RecvdBy).HasColumnName(@"RECVD_BY").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TotSelLins).HasColumnName(@"TOT_SEL_LINS").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.TotQtyRecvd).HasColumnName(@"TOT_QTY_RECVD").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.XferInMiscAmt).HasColumnName(@"XFER_IN_MISC_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.Commnt1).HasColumnName(@"COMMNT_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt2).HasColumnName(@"COMMNT_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt3).HasColumnName(@"COMMNT_3").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ErrRef).HasColumnName(@"ERR_REF").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false);
            builder.Property(x => x.EstRecvdSubTot).HasColumnName(@"EST_RECVD_SUB_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.EstRecvdTot).HasColumnName(@"EST_RECVD_TOT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LinCnt).HasColumnName(@"LIN_CNT").HasColumnType("int").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.ImLoc).WithMany(b => b.ImXferInHdrs).HasForeignKey(c => c.ToLocId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_XFER_IN_HDR_IM_LOC");

            builder.HasIndex(x => new { x.FromLocId, x.ToLocId, x.XferNo }).HasDatabaseName("IM_XFER_IN_HDR_X1");
            builder.HasIndex(x => new { x.ToLocId, x.FromLocId, x.XferNo }).HasDatabaseName("IM_XFER_IN_HDR_X2");
        }
    }

}
// </auto-generated>

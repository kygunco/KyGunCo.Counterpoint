// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_QXFER_TRX
    public class ImQxferTrxConfiguration : IEntityTypeConfiguration<ImQxferTrx>
    {
        public void Configure(EntityTypeBuilder<ImQxferTrx> builder)
        {
            builder.ToTable("IM_QXFER_TRX", "dbo");
            builder.HasKey(x => new { x.BatId, x.ItemNo, x.FromLocId, x.ToLocId, x.TrxDat, x.SeqNo }).HasName("PK_IM_QXFER_TRX").IsClustered();

            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.FromLocId).HasColumnName(@"FROM_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.ToLocId).HasColumnName(@"TO_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.TrxDat).HasColumnName(@"TRX_DAT").HasColumnType("datetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Qty).HasColumnName(@"QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyUnit).HasColumnName(@"QTY_UNIT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.QtyNumer).HasColumnName(@"QTY_NUMER").HasColumnType("decimal(11,0)").IsRequired();
            builder.Property(x => x.QtyDenom).HasColumnName(@"QTY_DENOM").HasColumnType("decimal(11,0)").IsRequired();
            builder.Property(x => x.Unit).HasColumnName(@"UNIT").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.MiscChrgAmt).HasColumnName(@"MISC_CHRG_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.DocNo).HasColumnName(@"DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ErrRef).HasColumnName(@"ERR_REF").HasColumnType("varchar(255)").IsRequired(false).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.CellDescr).HasColumnName(@"CELL_DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.IsSingleCell).HasColumnName(@"IS_SINGLE_CELL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.SerNo).HasColumnName(@"SER_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.NoOfSersEntd).HasColumnName(@"NO_OF_SERS_ENTD").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImLoc).WithMany(b => b.ImQxferTrxes).HasForeignKey(c => c.FromLocId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_QXFER_TRX_IM_LOC");

            builder.HasIndex(x => new { x.FromLocId, x.BatId, x.ItemNo, x.ToLocId, x.TrxDat, x.SeqNo }).HasDatabaseName("IM_QXFER_TRX_X1");
        }
    }

}
// </auto-generated>

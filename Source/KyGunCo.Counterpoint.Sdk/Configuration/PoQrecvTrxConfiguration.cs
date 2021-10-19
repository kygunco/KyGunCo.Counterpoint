// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_QRECV_TRX
    public class PoQrecvTrxConfiguration : IEntityTypeConfiguration<PoQrecvTrx>
    {
        public void Configure(EntityTypeBuilder<PoQrecvTrx> builder)
        {
            builder.ToTable("PO_QRECV_TRX", "dbo");
            builder.HasKey(x => new { x.BatId, x.ItemNo, x.LocId, x.TrxDat, x.SeqNo }).HasName("PK_PO_QRECV_TRX").IsClustered();

            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.TrxDat).HasColumnName(@"TRX_DAT").HasColumnType("datetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Qty).HasColumnName(@"QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyUnit).HasColumnName(@"QTY_UNIT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.QtyNumer).HasColumnName(@"QTY_NUMER").HasColumnType("decimal(11,0)").IsRequired();
            builder.Property(x => x.QtyDenom).HasColumnName(@"QTY_DENOM").HasColumnType("decimal(11,0)").IsRequired();
            builder.Property(x => x.Unit).HasColumnName(@"UNIT").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CostEntd).HasColumnName(@"COST_ENTD").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.DocNo).HasColumnName(@"DOC_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Ref).HasColumnName(@"REF").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.VendNo).HasColumnName(@"VEND_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
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
            builder.Property(x => x.UserIntakeDocNo).HasColumnName(@"USER_INTAKE_DOC_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.UserIntakeType).HasColumnName(@"USER_INTAKE_TYPE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);

            // Foreign keys
            builder.HasOne(a => a.ImLoc).WithMany(b => b.PoQrecvTrxes).HasForeignKey(c => c.LocId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_QRECV_TRX_IM_LOC");

            builder.HasIndex(x => new { x.LocId, x.BatId, x.ItemNo, x.TrxDat, x.SeqNo }).HasDatabaseName("PO_QRECV_TRX_X1");
        }
    }

}
// </auto-generated>

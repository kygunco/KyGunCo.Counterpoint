// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_CNT_TRX_CELL
    public class ImCntTrxCellConfiguration : IEntityTypeConfiguration<ImCntTrxCell>
    {
        public void Configure(EntityTypeBuilder<ImCntTrxCell> builder)
        {
            builder.ToTable("IM_CNT_TRX_CELL", "dbo");
            builder.HasKey(x => new { x.ItemNo, x.LocId, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr }).HasName("PK_IM_CNT_TRX_CELL").IsClustered();

            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.CntQty1).HasColumnName(@"CNT_QTY_1").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CntQty2).HasColumnName(@"CNT_QTY_2").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CntQty3).HasColumnName(@"CNT_QTY_3").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CntQty4).HasColumnName(@"CNT_QTY_4").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CntQty5).HasColumnName(@"CNT_QTY_5").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CntQty6).HasColumnName(@"CNT_QTY_6").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.FrzQtyOnHnd).HasColumnName(@"FRZ_QTY_ON_HND").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.NoOfCnts).HasColumnName(@"NO_OF_CNTS").HasColumnType("int").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImCntTrx).WithMany(b => b.ImCntTrxCells).HasForeignKey(c => new { c.ItemNo, c.LocId }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_CNT_TRX_CELL_IM_CNT_TRX");
        }
    }

}
// </auto-generated>

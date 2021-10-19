// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // IM_QASSEM_HIST_COMP
    public class ImQassemHistCompConfiguration : IEntityTypeConfiguration<ImQassemHistComp>
    {
        public void Configure(EntityTypeBuilder<ImQassemHistComp> builder)
        {
            builder.ToTable("IM_QASSEM_HIST_COMP", "dbo");
            builder.HasKey(x => new { x.EventNo, x.BatId, x.ItemNo, x.Dim1Upr, x.Dim2Upr, x.Dim3Upr, x.LocId, x.TrxDat, x.SeqNo, x.CompSeqNo }).HasName("PK_IM_QASSEM_HIST_COMP").IsClustered();

            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.BatId).HasColumnName(@"BAT_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.LocId).HasColumnName(@"LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
            builder.Property(x => x.TrxDat).HasColumnName(@"TRX_DAT").HasColumnType("datetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.CompSeqNo).HasColumnName(@"COMP_SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.CompItemNo).HasColumnName(@"COMP_ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.CompDim1Upr).HasColumnName(@"COMP_DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CompDim2Upr).HasColumnName(@"COMP_DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CompDim3Upr).HasColumnName(@"COMP_DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CompCellDescr).HasColumnName(@"COMP_CELL_DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.CompUnitQty).HasColumnName(@"COMP_UNIT_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.CompExtQty).HasColumnName(@"COMP_EXT_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.CompAddlQty).HasColumnName(@"COMP_ADDL_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.CompTotQty).HasColumnName(@"COMP_TOT_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.CompUnit).HasColumnName(@"COMP_UNIT").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CompLocId).HasColumnName(@"COMP_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CompSerNo).HasColumnName(@"COMP_SER_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Commnt).HasColumnName(@"COMMNT").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.OrigCompItemNo).HasColumnName(@"ORIG_COMP_ITEM_NO").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.OrigCompDim1Upr).HasColumnName(@"ORIG_COMP_DIM_1_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OrigCompDim2Upr).HasColumnName(@"ORIG_COMP_DIM_2_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OrigCompDim3Upr).HasColumnName(@"ORIG_COMP_DIM_3_UPR").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.OrigCompCellDescr).HasColumnName(@"ORIG_COMP_CELL_DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.OrigCompUnitQty).HasColumnName(@"ORIG_COMP_UNIT_QTY").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.CompDescr).HasColumnName(@"COMP_DESCR").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CompItemTyp).HasColumnName(@"COMP_ITEM_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CompTrkMeth).HasColumnName(@"COMP_TRK_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CompCategCod).HasColumnName(@"COMP_CATEG_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CompSubcatCod).HasColumnName(@"COMP_SUBCAT_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CompItemVendNo).HasColumnName(@"COMP_ITEM_VEND_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CompQtyOnHndBefore).HasColumnName(@"COMP_QTY_ON_HND_BEFORE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CompAvgCostBefore).HasColumnName(@"COMP_AVG_COST_BEFORE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CompAvgCostAfter).HasColumnName(@"COMP_AVG_COST_AFTER").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CompStdCost).HasColumnName(@"COMP_STD_COST").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CompExtCost).HasColumnName(@"COMP_EXT_COST").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.CompTotCostCorr).HasColumnName(@"COMP_TOT_COST_CORR").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.CompUnitRetlVal).HasColumnName(@"COMP_UNIT_RETL_VAL").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.CompCost).HasColumnName(@"COMP_COST").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.CompCellQtyOnHndBefore).HasColumnName(@"COMP_CELL_QTY_ON_HND_BEFORE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.ImQassemHistPar).WithMany(b => b.ImQassemHistComps).HasForeignKey(c => new { c.EventNo, c.BatId, c.ItemNo, c.Dim1Upr, c.Dim2Upr, c.Dim3Upr, c.LocId, c.TrxDat, c.SeqNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_IM_QASSEM_HIST_COMP_IM_QASSEM_HIST_PAR");

            builder.HasIndex(x => new { x.TrxDat, x.LocId, x.ItemNo }).HasDatabaseName("IM_QASSEM_HIST_COMP_X1");
        }
    }

}
// </auto-generated>

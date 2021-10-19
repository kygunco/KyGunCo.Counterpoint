// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // PO_ADJ_HIST_LIN
    public class PoAdjHistLinConfiguration : IEntityTypeConfiguration<PoAdjHistLin>
    {
        public void Configure(EntityTypeBuilder<PoAdjHistLin> builder)
        {
            builder.ToTable("PO_ADJ_HIST_LIN", "dbo");
            builder.HasKey(x => new { x.EventNo, x.RecvrNo, x.SeqNo }).HasName("PK_PO_ADJ_HIST_LIN").IsClustered();

            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.RecvrNo).HasColumnName(@"RECVR_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15).ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ItemNo).HasColumnName(@"ITEM_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.VendNo).HasColumnName(@"VEND_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.VendItemNo).HasColumnName(@"VEND_ITEM_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.DescrUpr).HasColumnName(@"DESCR_UPR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ItemDescr).HasColumnName(@"ITEM_DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ItemDescrUpr).HasColumnName(@"ITEM_DESCR_UPR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.QtyRecvd).HasColumnName(@"QTY_RECVD").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.QtyUnit).HasColumnName(@"QTY_UNIT").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.QtyRecvdUnit).HasColumnName(@"QTY_RECVD_UNIT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.QtyRecvdNumer).HasColumnName(@"QTY_RECVD_NUMER").HasColumnType("decimal(11,0)").IsRequired();
            builder.Property(x => x.QtyRecvdDenom).HasColumnName(@"QTY_RECVD_DENOM").HasColumnType("decimal(11,0)").IsRequired();
            builder.Property(x => x.PrevRecvdCost).HasColumnName(@"PREV_RECVD_COST").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.PrevRecvdExtCost).HasColumnName(@"PREV_RECVD_EXT_COST").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjRecvdCost).HasColumnName(@"ADJ_RECVD_COST").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjRecvdExtCost).HasColumnName(@"ADJ_RECVD_EXT_COST").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.PrevLinMiscChrg1).HasColumnName(@"PREV_LIN_MISC_CHRG_1").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.PrevLinMiscChrg2).HasColumnName(@"PREV_LIN_MISC_CHRG_2").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.PrevLinMiscChrg3).HasColumnName(@"PREV_LIN_MISC_CHRG_3").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.PrevLinMiscChrg4).HasColumnName(@"PREV_LIN_MISC_CHRG_4").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.PrevLinMiscChrg5).HasColumnName(@"PREV_LIN_MISC_CHRG_5").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.PrevTotLinMiscChrg).HasColumnName(@"PREV_TOT_LIN_MISC_CHRG").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AdjLinMiscChrg1).HasColumnName(@"ADJ_LIN_MISC_CHRG_1").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjLinMiscChrg2).HasColumnName(@"ADJ_LIN_MISC_CHRG_2").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjLinMiscChrg3).HasColumnName(@"ADJ_LIN_MISC_CHRG_3").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjLinMiscChrg4).HasColumnName(@"ADJ_LIN_MISC_CHRG_4").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjLinMiscChrg5).HasColumnName(@"ADJ_LIN_MISC_CHRG_5").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjTotLinMiscChrg).HasColumnName(@"ADJ_TOT_LIN_MISC_CHRG").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.PrevCost).HasColumnName(@"PREV_COST").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.PrevExtCost).HasColumnName(@"PREV_EXT_COST").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjCost).HasColumnName(@"ADJ_COST").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.AdjExtCost).HasColumnName(@"ADJ_EXT_COST").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.QtyAdj).HasColumnName(@"QTY_ADJ").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.BsInvAdjAmt).HasColumnName(@"BS_INV_ADJ_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.CogsAdjAmt).HasColumnName(@"COGS_ADJ_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.MiscItemAdjAmt).HasColumnName(@"MISC_ITEM_ADJ_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AvgCostBefore).HasColumnName(@"AVG_COST_BEFORE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.AvgCostAfter).HasColumnName(@"AVG_COST_AFTER").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.StdCost).HasColumnName(@"STD_COST").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.TotCostCorr).HasColumnName(@"TOT_COST_CORR").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.CellDescr).HasColumnName(@"CELL_DESCR").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.IsSingleCell).HasColumnName(@"IS_SINGLE_CELL").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Dim1Upr).HasColumnName(@"DIM_1_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim2Upr).HasColumnName(@"DIM_2_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Dim3Upr).HasColumnName(@"DIM_3_UPR").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.RecvAccruAcctNo).HasColumnName(@"RECV_ACCRU_ACCT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Commnt1).HasColumnName(@"COMMNT_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt2).HasColumnName(@"COMMNT_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Commnt3).HasColumnName(@"COMMNT_3").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.TrkMeth).HasColumnName(@"TRK_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ItemVendNo).HasColumnName(@"ITEM_VEND_NO").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.CategCod).HasColumnName(@"CATEG_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ItemTyp).HasColumnName(@"ITEM_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SubcatCod).HasColumnName(@"SUBCAT_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AdjDat).HasColumnName(@"ADJ_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RecvrLocId).HasColumnName(@"RECVR_LOC_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstMaintDt).HasColumnName(@"LST_MAINT_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LstMaintUsrId).HasColumnName(@"LST_MAINT_USR_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LstLckDt).HasColumnName(@"LST_LCK_DT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RowTs).HasColumnName(@"ROW_TS").HasColumnType("timestamp").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.NoOfSersAdj).HasColumnName(@"NO_OF_SERS_ADJ").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.UnitWeight).HasColumnName(@"UNIT_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.ExtWeight).HasColumnName(@"EXT_WEIGHT").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.UnitCube).HasColumnName(@"UNIT_CUBE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.ExtCube).HasColumnName(@"EXT_CUBE").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.QtyRecvdInStkUnits).HasColumnName(@"QTY_RECVD_IN_STK_UNITS").HasColumnType("decimal(15,4)").IsRequired(false);
            builder.Property(x => x.LinAdjMeth).HasColumnName(@"LIN_ADJ_METH").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PrevNormTaxAmtAllocHome).HasColumnName(@"PREV_NORM_TAX_AMT_ALLOC_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.PrevTaxAmtAllocHome).HasColumnName(@"PREV_TAX_AMT_ALLOC_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjNormTaxAmtAllocHome).HasColumnName(@"ADJ_NORM_TAX_AMT_ALLOC_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AdjTaxAmtAllocHome).HasColumnName(@"ADJ_TAX_AMT_ALLOC_HOME").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.LinGuid).HasColumnName(@"LIN_GUID").HasColumnType("uniqueidentifier").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.PoAdjHist).WithMany(b => b.PoAdjHistLins).HasForeignKey(c => new { c.EventNo, c.RecvrNo }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PO_ADJ_HIST_LIN_PO_ADJ_HIST");

            builder.HasIndex(x => new { x.ItemNo, x.EventNo, x.RecvrNo, x.SeqNo }).HasDatabaseName("PO_ADJ_HIST_LIN_X1");
            builder.HasIndex(x => new { x.VendItemNo, x.EventNo, x.RecvrNo, x.SeqNo }).HasDatabaseName("PO_ADJ_HIST_LIN_X2");
            builder.HasIndex(x => new { x.ItemDescrUpr, x.EventNo, x.RecvrNo, x.SeqNo }).HasDatabaseName("PO_ADJ_HIST_LIN_X3");
            builder.HasIndex(x => new { x.DescrUpr, x.EventNo, x.RecvrNo, x.SeqNo }).HasDatabaseName("PO_ADJ_HIST_LIN_X4");
            builder.HasIndex(x => new { x.AdjDat, x.EventNo, x.RecvrNo, x.SeqNo }).HasDatabaseName("PO_ADJ_HIST_LIN_X5");
        }
    }

}
// </auto-generated>
